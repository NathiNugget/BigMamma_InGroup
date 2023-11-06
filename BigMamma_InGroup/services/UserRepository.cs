using BigMamma_InGroup.model;

namespace BigMamma_InGroup.services
{
    public class UserRepository
    {
        public static List<Pizza> Basket {  get; set; }
        public static double Balance { get; set; }
        public Dictionary<string, string> dict = new Dictionary<string, string>();
        public static string? CurrentUser { get; set; }

        public static bool LoggedIn { get; set; }
        public static bool IsAdmin { get; set; } 

        public bool Admin { get; set; }
        public UserRepository()

        {
            dict.Add("Admin", "Super");
            dict.Add("Anders", "Anders123");
            dict.Add("Lone", "girlpower99");
            Basket = new List<Pizza>();
        }

        


    }
}
