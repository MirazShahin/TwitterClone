namespace TwitterClone.Domain.Entities
{
    public class Tweet
    {
        private Guid _id;
        private Guid _authorId; 
        private string _content;
        private DateTime _created;
        private DateTime _updated;
        
        public Tweet(Guid authorId)
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
        }
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
        public DateTime Created
        {
            get { return _created; }
            set { _created = value; }
        }
        public DateTime Updated
        {
            get { return _updated; }
            set { _updated = value; }
        }


    }
}
