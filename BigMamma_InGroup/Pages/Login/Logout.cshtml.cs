using BigMamma_InGroup.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BigMamma_InGroup.Pages.Login
{
    public class LogoutModel : PageModel
    {
        public IActionResult OnGet()
        {
            UserRepository.IsAdmin = false; 
            UserRepository.LoggedIn = false;
            return RedirectToPage("/Index"); 
        }
    }
}
