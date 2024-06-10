using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private const int ScreenshotX = 1200;
        private const int ScreenshotY = 270;
        private const int ScreenshotWidth = 650;
        private const int ScreenshotHeight = 500;
        private FormMainLogic m_FormMainLogic = new FormMainLogic();
        private FormFilterFriends m_FormFilterFriends = null;
        private bool m_IsUserClickedShowStatistics = false;

        public static User LoggedInUser { get; set; }
        public static LoginResult LoginResult { get; set; } = new LoginResult();

        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 25;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");

            if (!m_FormMainLogic.CheckLoggedInUser(LoginResult.AccessToken))
            {
                login();
            }
        }

        private void login()
        {
            LoginResult = m_FormMainLogic.Login(textBoxAppID.Text);
            if (FormMainLogic.IsLoggedInUser)
            {
                LoggedInUser = LoginResult.LoggedInUser;
                buttonLogin.Text = $"Logged in as {LoggedInUser.Name}";
                buttonLogin.BackColor = Color.LightGreen;
                pictureBoxProfile.ImageLocation = LoggedInUser.PictureNormalURL;
                buttonLogin.Enabled = false;
                buttonLogout.Enabled = true;
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            LoginResult = null;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
            FormMainLogic.IsLoggedInUser = false;
        }

        private void titledListBoxAlbums_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (FormMainLogic.IsLoggedInUser)
            {
                fetchAlbums();
            }
            else
            {
                DisplayIfNotLoggedInUser();
            }
        }

        private void fetchAlbums()
        {
            titledListBoxAlbums.ItemsClear();
            titledListBoxAlbums.DisplayMember = "Name";
            foreach (Album album in LoggedInUser.Albums)
            {
                titledListBoxAlbums.ItemsAdd(album);
            }

            if (titledListBoxAlbums.ItemsCount == 0)
            {
                MessageBox.Show("No Albums to retrieve :(");
            }
        }

        private void titledListBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (titledListBoxAlbums.SelectedItem != null)
            {
                Album selectedAlbum = titledListBoxAlbums.SelectedItem as Album;
                titledListBoxAlbums.LabelText = selectedAlbum.CreatedTime.ToString();
                if (selectedAlbum.PictureAlbumURL != null)
                {
                    titledListBoxAlbums.LoadPicture(selectedAlbum.PictureAlbumURL);
                }
                else
                {
                    titledListBoxAlbums.Picture = pictureBoxProfile.ErrorImage;
                }
            }
        }

        private void titledListBoxGroups_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (FormMainLogic.IsLoggedInUser)
            {
                fetchGroups();
            }
            else
            {
                DisplayIfNotLoggedInUser();
            }
        }

        private void fetchGroups()
        {
            titledListBoxGroups.ItemsClear();
            titledListBoxGroups.DisplayMember = "Name";
            try
            {
                foreach (Group group in LoggedInUser.Groups)
                {
                    titledListBoxGroups.ItemsAdd(group);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (titledListBoxGroups.ItemsCount == 0)
            {
                MessageBox.Show("No groups to retrieve :(");
            }
        }

        private void titledListBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (titledListBoxGroups.SelectedItem != null)
            {
                Group selectedGroup = titledListBoxGroups.SelectedItem as Group;
                titledListBoxGroups.LabelText = selectedGroup.Privacy.ToString();
                if (selectedGroup.PictureSmallURL != null)
                {
                    titledListBoxGroups.LoadPicture(selectedGroup.PictureSmallURL);
                }
                else
                {
                    titledListBoxGroups.Picture = pictureBoxProfile.ErrorImage;
                }
            }
        }

        private void titledListBoxEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (FormMainLogic.IsLoggedInUser)
            {
                fetchEvents();
            }
            else
            {
                DisplayIfNotLoggedInUser();
            }
        }

        private void fetchEvents()
        {
            titledListBoxEvents.ItemsClear();
            titledListBoxEvents.DisplayMember = "Name";
            try
            {
                foreach (Event userEvent in LoggedInUser.Events)
                {
                    titledListBoxEvents.ItemsAdd(userEvent);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (titledListBoxEvents.ItemsCount == 0)
            {
                MessageBox.Show("No events to retrieve :(");
            }
        }

        private void titledListBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (titledListBoxEvents.SelectedItem != null)
            {
                Event selectedEvent = titledListBoxEvents.SelectedItem as Event;
                titledListBoxEvents.LabelText = selectedEvent.Location;
                if (selectedEvent.PictureSmallURL != null)
                {
                    titledListBoxEvents.LoadPicture(selectedEvent.PictureSmallURL);
                }
                else
                {
                    titledListBoxEvents.Picture = pictureBoxProfile.ErrorImage;
                }
            }
        }

        private void buttonFilterFriends_Click(object sender, EventArgs e)
        {
            if (m_FormFilterFriends == null)
            {
                m_FormFilterFriends = new FormFilterFriends();
            }

            m_FormFilterFriends.ShowDialog();
        }

        private void buttonSetStatus_Click(object sender, EventArgs e)
        {
            if (FormMainLogic.IsLoggedInUser)
            {
                if (m_FormMainLogic.PostStatusAndCheckIfSucceed(titleledTextBoxPost.UserText, LoggedInUser))
                {
                    MessageBox.Show("Status Posted!");
                }
                else
                {
                    //Today there is no permission to publish posts, the failure message will always be displayed
                    MessageBox.Show("Failed to upload post");
                }
            }
            else
            {
                DisplayIfNotLoggedInUser();
            }
        }

        private void linkLabelFetchPosts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (FormMainLogic.IsLoggedInUser)
            {
                fetchPosts();
            }
            else
            {
                DisplayIfNotLoggedInUser();
            }
        }

        private void fetchPosts()
        {
            listBoxPosts.Items.Clear();
            foreach (Post post in LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    listBoxPosts.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    listBoxPosts.Items.Add(post.Caption);
                }
                else
                {
                    listBoxPosts.Items.Add($"[{post.Type}]");
                }
            }

            if (listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void buttonShowStatistics_Click(object sender, EventArgs e)
        {
            if (FormMainLogic.IsLoggedInUser)
            {
                if (listBoxPosts.SelectedIndex > -1)
                {
                    m_FormMainLogic.PostStatistics.InitializePostStatistic();
                    updateStatisticDataLabels();
                    m_IsUserClickedShowStatistics = true;
                }
                else
                {
                    MessageBox.Show("No post was selected");
                }
            }
            else
            {
                DisplayIfNotLoggedInUser();
            }
        }

        private void updateStatisticDataLabels()
        {
            titledDataLabelComments.DataText = m_FormMainLogic.PostStatistics.CommentsNum.ToString();
            titledDataLabelLikes.DataText = m_FormMainLogic.PostStatistics.LikesNum.ToString();
            titledDataLabelFemaleLikes.DataText = m_FormMainLogic.PostStatistics.FemaleLikesNum.ToString();
            titledDataLabelMaleLikes.DataText = m_FormMainLogic.PostStatistics.MaleLikesNum.ToString();
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_FormMainLogic.PostStatistics.Post = LoggedInUser.Posts[listBoxPosts.SelectedIndex];
        }

        private void buttonSavePostStatistics_Click(object sender, EventArgs e)
        {
            if (FormMainLogic.IsLoggedInUser)
            {
                if (m_IsUserClickedShowStatistics)
                {
                    m_FormMainLogic.StatisticDataScreenshot.SetScreenSection(ScreenshotX, ScreenshotY, ScreenshotWidth, ScreenshotHeight);
                    if (m_FormMainLogic.StatisticDataScreenshot.TakeScreenshotAndCheckIfSucceed())
                    {
                        MessageBox.Show("Screenshot saved successfully");
                    }
                    else
                    {
                        MessageBox.Show("Screenshot faild");
                    }
                }
                else
                {
                    MessageBox.Show("No statistics to save");
                }
            }
            else 
            {
                DisplayIfNotLoggedInUser();
            }
        }

        public static void DisplayIfNotLoggedInUser()
        {
            MessageBox.Show("You have to login");
        }
    }
}