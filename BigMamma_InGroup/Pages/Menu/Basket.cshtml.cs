using BigMamma_InGroup.model;
using BigMamma_InGroup.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography.X509Certificates;

namespace BigMamma_InGroup.Pages.Menu
{
    public class BasketModel : PageModel
    {
        private List<Pizza> _basketList;
        private double _cost;
                UserRepository _userRepository;

        public BasketModel(IPizzaRepository pr, UserRepository ur) {
            _userRepository = ur;

        }
        [BindProperty]
        public List<Pizza> BasketList { get; set; }
        [BindProperty]
        public List<Pizza> PizzaList { get; set; }
        [BindProperty]
        public UserRepository UserRepository { get { return _userRepository;} }
        public void OnGet()
        {
            _basketList = new List<Pizza>();
            _basketList.Add(new Pizza("hej", 54, false, false, false));
            _basketList.Add(new Pizza("noob", 66, false, false, false));
            _basketList.Add(new Pizza("nope", 88, false, false, false));
            _cost = 0;
            foreach (Pizza p in _basketList)
            {
                if (UserRepository.LoggedIn)
                {
                    _cost += p.Price * 0.95;
                }
                else
                {
                    _cost += p.Price;
                }
            }
        }

        public IActionResult OnPostOrder() {
            if (UserRepository.Balance >= _cost) {
                UserRepository.Balance -= _cost;
                return RedirectToPage("SeeYouNextTime");
            }
            
            else return RedirectToPage("/"); 
        }

        public IActionResult OnPostCancel()
        {
            BasketList.Clear();

            return RedirectToPage("/");
            
        }

    }
}
