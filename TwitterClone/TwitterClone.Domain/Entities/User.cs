namespace TwitterClone.Domain.Entities
{
    public class User
    {
        private Guid _id { get; set; }
        private string _name { get; set; }
        private string _email { get; set; }
        private string _password { get; set; }
        private string Gender { get; set; }
        private string CreatedDate {  get; set; }
            
    }
}
