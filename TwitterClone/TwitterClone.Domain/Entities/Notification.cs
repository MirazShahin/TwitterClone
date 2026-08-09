
namespace TwitterClone.Domain.Entities
{
    public class Notification
    {
        private Guid _id;
        private User _user;
        private User _actor_user;
        private Guid _actorId;
        private DateTime _notificationTime;

        public Notification(Guid actorId)
        {
            _id = Guid.NewGuid();
            _actorId = actorId;
        }
        public Guid Id
        {
            get { return _id; }
        }
        public User User
        {
            get { return _user; }
            set { _user = value; }
        }
        public User ActorUser
        {
            get { return _actor_user; }
            set { _actor_user = value; }
        }
        public Guid ActorId
        {
            get { return _actorId; }
        }
        public DateTime NotificationTime
        {
            get { return _notificationTime; }
            set { _notificationTime = value; }
        }
    }
}
