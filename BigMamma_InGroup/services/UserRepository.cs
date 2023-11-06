namespace BigMamma_InGroup.services
{
    public class UserRepository
    {
        public Dictionary<string, string> dict = new Dictionary<string, string>();
        static public bool LoggedIn { get; set; }
        static public bool IsAdmin { get; set; }

        public bool Admin { get; set; }
        public UserRepository() {
            dict.Add("Admin", "Super");
            dict.Add("Anders", "Anders123");
            dict.Add("Lone", "girlpower99"); 
        }


    }
}
