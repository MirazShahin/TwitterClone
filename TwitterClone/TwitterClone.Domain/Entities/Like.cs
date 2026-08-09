
namespace TwitterClone.Domain.Entities
{
    public class Like
    {
        private Guid _id;
        private Guid _authorId;
        private DateTime _likeAt;

        public Like(Guid authorId)
        {
            _id = Guid.NewGuid();
            _authorId = authorId;
        }
        public Guid Id
        {
            get { return _id; }
        }

        public Guid AuthorId
        {
            get { return _authorId; }
            set { _authorId = value; }
        }

        public DateTime LikeAt
        {
            get { return _likeAt; }
            set { _likeAt = value; }
        } 
    }
}
