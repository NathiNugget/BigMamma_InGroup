using BigMamma_InGroup.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BigMamma_InGroup.Pages.Menu
{
    public class SeeYouNextTimeModel : PageModel
    {
        public double Balance { get; set; }
        public SeeYouNextTimeModel(UserRepository ur) {
            Balance = UserRepository.Balance; 
        }
        public void OnGet()
        {

        }

        public override string ToString()
        {
            var d = Balance;
            var result1 = d.ToString("0.###%");

            var result2 = result1.Remove(result1.Length - 1);
            return result2; 
        }
    }
}
