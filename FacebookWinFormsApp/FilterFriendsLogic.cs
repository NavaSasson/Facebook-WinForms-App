using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    public class FilterFriendsLogic
    {
        public List<User> FilteredFriendsList { get; set; } = new List<User>();
        public List<string> FilteredFriendsEmailsList { get; set; } = new List<string> { "galhalili999@gmail.com" };
        //Today it is not possible to fetch the email addresses of friends from Facebook, so we used our email address as an example
        public string[] FilterFeatures { get; } = new string[]
        {
            "Birthday",
            "Gender",
            "Hometown",
            "Location"
        };

        public void FetchEmailsFromFriendsListAferFilter()
        {
            foreach (User fbFriend in FilteredFriendsList)
            {
                if (fbFriend.Email != null)
                {
                    FilteredFriendsEmailsList.Add(fbFriend.Email);
                }
            }
        }

        public void FetchFriendsByUserFilterFeaturesSelection(ICollection<string> i_CheckedFilterFeatures)
        {
            foreach (User fbFriend in FormMain.LoggedInUser.Friends)
            {
                if (i_CheckedFilterFeatures.Contains("Birthday"))
                {
                    if (fbFriend.Birthday != FormMain.LoggedInUser.Birthday)
                    {
                        break;
                    }
                }

                if (i_CheckedFilterFeatures.Contains("Gender"))
                {
                    if (fbFriend.Gender != FormMain.LoggedInUser.Gender)
                    {
                        break;
                    }
                }

                if (i_CheckedFilterFeatures.Contains("Hometown"))
                {
                    if (fbFriend.Hometown != FormMain.LoggedInUser.Hometown)
                    {
                        break;
                    }
                }

                if (i_CheckedFilterFeatures.Contains("Location"))
                {
                    if (fbFriend.Location != FormMain.LoggedInUser.Location)
                    {
                        break;
                    }
                }

                FilteredFriendsList.Add(fbFriend);
            }
        }

        public bool CheckIfEmptyFilteredFriendsList()
        {
            return FilteredFriendsList.Count == 0;
        }
    }
}