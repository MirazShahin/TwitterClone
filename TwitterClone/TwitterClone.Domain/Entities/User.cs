namespace TwitterClone.Domain.Entities
{
    public class User
    {
        private Guid _id;
        private string _name;
        private string _email;
        private string _password;
        private string _gender;

        public User()
        {
            _id = Guid.NewGuid();
        }
        public Guid Id
        {
            get { return _id; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

    }
}