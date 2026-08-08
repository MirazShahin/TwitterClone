

namespace TwitterClone.Domain.Entities
{
    public class Bookmark
    {
        private Guid _id;
        private Guid _userId;
        private User _userIdentity;

        private Guid _tweetId;
        private Tweet _tweet;

        public Guid Id
        {
            get {  return _id; }
        }
        public Guid UserId
        {
            get { return _userId; }
        }
        public User UserIdentity
        {
            get { return _userIdentity; }
            set { _userIdentity = value; }
        }
        public Guid TweetId
        {
            get { return _tweetId; }
        }
        public Tweet Tweet
        {
            get { return _tweet; }
            set { _tweet = value; }
        }

    }
}
