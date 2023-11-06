using BigMamma_InGroup.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace BigMamma_InGroup.Pages.Login
{
    public class LoginModel : PageModel
    {
        private UserRepository _userRepository;
        [BindProperty]
        [Required]
        public string Username { get; set; }
        [BindProperty]
        [Required]
        public string Password { get; set; }

        public LoginModel(UserRepository ur)
        {
            _userRepository = ur;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (Username != null)
            {

                if (_userRepository.dict.ContainsKey(Username) && Password == _userRepository.dict[Username])
                {
                    if (Username == "Admin") UserRepository.IsAdmin = true;
                    UserRepository.LoggedIn = true;
                    UserRepository.CurrentUser = Username;
                    UserRepository.Balance = 500.0; 
                    return RedirectToPage("../Menu/DisplayPizza");
                }
            }
            return RedirectToPage("../Index");

        }
    }
}
