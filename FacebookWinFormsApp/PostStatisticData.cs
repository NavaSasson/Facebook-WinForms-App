using FacebookWrapper.ObjectModel;
using System;

namespace BasicFacebookFeatures
{
    public class PostStatisticData
    {
        private Random m_Random = new Random();

        public Post Post { get; set; } = new Post();
        public int CommentsNum { get; set; } = 0;
        public int LikesNum { get; set; } = 0;
        public int FemaleLikesNum { get; set; } = 0;
        public int MaleLikesNum { get; set; } = 0;

        public void InitializePostStatistic()
        {
            fetchCommentsNum();
            fetchLikesNum();
            fetchFemaleAndMaleLikesNum();
        }

        //Today there is no permission to receive comments and who liked so we will
        //present random values ​​in the number of comments and likes
        private void fetchCommentsNum()
        {
            CommentsNum = Post.Comments.Count;
            //There is access to comments, but in practice we will always get an empty list of comments,
            //so we will always see 0 comments.
            //A random number is given so that something is actually displayed to the user
            CommentsNum = m_Random.Next(0, 11);
        }

        private void fetchLikesNum()
        {
            try
            {
                LikesNum = Post.LikedBy.Count;
            }
            catch (Exception)
            {
                LikesNum = m_Random.Next(0, 11);
            }
        }

        private void fetchFemaleAndMaleLikesNum()
        {
            try
            {
                foreach (User userLiked in Post.LikedBy)
                {
                    if (userLiked.Gender == User.eGender.female)
                    {
                        FemaleLikesNum += 1;
                    }
                    else
                    {
                        MaleLikesNum += 1;
                    }
                }
            }
            catch (Exception)
            {
                FemaleLikesNum = m_Random.Next(0, LikesNum + 1);
                MaleLikesNum = LikesNum - FemaleLikesNum;
            }
        }
    }
}