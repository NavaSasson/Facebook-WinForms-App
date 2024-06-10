using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System;

namespace BasicFacebookFeatures
{
    public class FormMainLogic
    {
        public PostStatisticData PostStatistics { get; set; } = new PostStatisticData();
        public Screenshot StatisticDataScreenshot { get; set; } = new Screenshot();
        public static bool IsLoggedInUser { get; set; } = false;

        public LoginResult Login(string i_AppID)
        {
            LoginResult loginResult = FacebookService.Login(
                i_AppID,
                /// requested permissions:
                "email",
                "public_profile",
                //"pages_read_user_content",
                "user_likes",
                "user_posts",
                "user_photos",
                "user_events",
                "user_videos",
                "user_friends",
                "user_location",
                "user_birthday",
                "user_hometown",
                "user_likes",
                "user_gender"//,
                //"groups_access_member_info"
                );

            IsLoggedInUser = CheckIfLogInSucceed(loginResult.ErrorMessage);

            return loginResult;
        }

        public bool CheckIfLogInSucceed(string i_ErrorMessage)
        {
            return string.IsNullOrEmpty(i_ErrorMessage);
        }

        public bool CheckLoggedInUser(string i_AccessToken)
        {
            return !string.IsNullOrEmpty(i_AccessToken);
        }

        public bool PostStatusAndCheckIfSucceed(string i_PostText, User i_LoggedInUser)
        {
            bool isPostSucceed = false;

            try
            {
                Status statusToPost = i_LoggedInUser.PostStatus(i_PostText);

            }
            catch (Exception)
            {
                isPostSucceed = false;
            }

            return isPostSucceed;
        }
    }
}