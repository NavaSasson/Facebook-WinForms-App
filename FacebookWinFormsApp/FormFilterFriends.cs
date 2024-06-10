using FacebookWrapper.ObjectModel;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormFilterFriends : Form
    {
        private const string GroupLink = "https://www.facebook.com/share/KSTYh7VQqk8NVcyz/?mibextid=K35XfP";
        private FilterFriendsLogic m_FilterFriendsLogic = new FilterFriendsLogic();

        public FormFilterFriends()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            populateCheckedListBoxFilterFeatures();
            populateComboBoxPrivacy();
        }

        private void populateCheckedListBoxFilterFeatures()
        {
            checkedListBoxFilterFeatures.Items.Clear();

            foreach (string feature in m_FilterFriendsLogic.FilterFeatures)
            {
                checkedListBoxFilterFeatures.Items.Add(feature);
            }
        }

        private void populateComboBoxPrivacy()
        {
            foreach (Group.ePrivacy privacyType in Enum.GetValues(typeof(Group.ePrivacy)))
            {
                comboBoxPrivacy.Items.Add(privacyType);
            }
        }

        private void buttonCreateGroup_Click(object sender, EventArgs e)
        {
            if (FormMainLogic.IsLoggedInUser)
            {
                if (checkIfGroupCreationIsLegal())
                {
                    string groupName = titleledTextBoxGroupName.UserText;
                    string groupPrivacy = comboBoxPrivacy.SelectedItem.ToString();
                    if (FBGroup.CreateFacebookGroup(groupName, groupPrivacy, GroupLink))
                    {
                        MessageBox.Show("Group created successfully!");
                        if (EmailSender.SendEmails(groupName, GroupLink, m_FilterFriendsLogic.FilteredFriendsEmailsList))
                        {
                            MessageBox.Show("All emails have been sent successfully");
                        }
                        else
                        {
                            MessageBox.Show("An error occurred - sending some of the emails failed");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Group creation failed :(");
                    }
                }
            }
            else
            {
                FormMain.DisplayIfNotLoggedInUser();
            }
        }

        private bool checkIfGroupCreationIsLegal()
        {
            bool isGroupCreationLegal = true;

            if (m_FilterFriendsLogic.CheckIfEmptyFilteredFriendsList())
            {
                isGroupCreationLegal = false;
                MessageBox.Show("According to the selected filter, no friends were found to create a group with");
            }
            else if (!FBGroup.CheckIfLegaleGroupName(titleledTextBoxGroupName.UserText))
            {
                isGroupCreationLegal = false;
                MessageBox.Show("No name was chosen for the group");
            }
            else if (!FBGroup.CheckIfLegaleGroupPrivacy(comboBoxPrivacy.SelectedItem))
            {
                isGroupCreationLegal = false;
                MessageBox.Show("No privacy was chosen for the group");
            }

            return isGroupCreationLegal;
        }

        private void buttonShowFilteredFriendsList_Click(object sender, EventArgs e)
        {
            if (FormMainLogic.IsLoggedInUser)
            {
                m_FilterFriendsLogic.FilteredFriendsList.Clear();
                listBoxFriendsListAfterFilter.Items.Clear();
                checkedListBoxFilterFeatures.ClearSelected();
                fetchFriendsByUserFilterFeaturesSelection();
                fetchFriendsEmailsAferFilter();
            }
            else
            {
                FormMain.DisplayIfNotLoggedInUser();
            }
        }

        private void fetchFriendsByUserFilterFeaturesSelection()
        {
            listBoxFriendsListAfterFilter.DisplayMember = "Name";
            m_FilterFriendsLogic.FetchFriendsByUserFilterFeaturesSelection(checkedListBoxFilterFeatures.CheckedItems.Cast<string>().ToList());
            foreach (User friend in m_FilterFriendsLogic.FilteredFriendsList)
            {
                listBoxFriendsListAfterFilter.Items.Add(friend);
            }

            if (m_FilterFriendsLogic.CheckIfEmptyFilteredFriendsList())
            {
                MessageBox.Show("No Friends to retrieve :(");
            }
        }

        private void fetchFriendsEmailsAferFilter()
        {
            m_FilterFriendsLogic.FetchEmailsFromFriendsListAferFilter();
        }
    }
}