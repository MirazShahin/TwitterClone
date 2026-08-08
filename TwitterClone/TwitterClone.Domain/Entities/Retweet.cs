
namespace TwitterClone.Domain.Entities
{
    public class Retweet
    {
        private Guid _id;
        private Guid _userId;
        private User _user;

        private Guid _orginalTweetId;
        private Tweet _orginalTweet;
        private DateTime _retweetAt;

        public Guid Id
        {
            get { return _id; }
        }

        public Guid UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        public User User
        {
            get { return (User) _user; }
            set { _user = value; }
        }
        public Guid OrginalTweetId
        {
            get { return _orginalTweetId; }
        }
        public Tweet OrginalTweet
        {
            get { return (Tweet) _orginalTweet;}
            set { _orginalTweet = value; }
        }
        public DateTime RetweetAt
        {
            get { return RetweetAt; }
            set { RetweetAt = value; }
        }
    }
}
