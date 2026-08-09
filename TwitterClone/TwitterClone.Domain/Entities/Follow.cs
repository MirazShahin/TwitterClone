
namespace TwitterClone.Domain.Entities
{
    public class Follow
    {
        private Guid _id;
        private Guid _followerId;
        private Guid _followingId;
        private User _followingUser;
        private DateTime _followingAt;
        
        public Follow(Guid followerId, Guid followingId)
        {
            _id = Guid.NewGuid();
            _followerId = followerId;
            _followingId = followingId;
        }
        public Guid Id
        {
            get { return _id; }
        }
        public Guid FollowerId
        {
            get { return _followerId; }
        }
        public Guid FollowingId
        {
            get { return _followingId; }
        }
        public User FollowingUser
        {
            get { return _followingUser; }
            set { _followingUser = value;}
        }
        public DateTime FollowingAt
        {
            get { return _followingAt; }
            set { _followingAt = value; }
        }

    }
}
