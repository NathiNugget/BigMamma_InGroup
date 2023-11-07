using BigMamma_InGroup.model;
using BigMamma_InGroup.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BigMamma_InGroup.Pages.Menu
{
    public class BasketModel : PageModel
    {
        List<Pizza> _pizzaList;
        UserRepository _ur;
        private int _cost = 0; 
        public BasketModel(UserRepository ur, IPizzaRepository pr) {
            _ur = ur;
            _pizzaList = new List<Pizza>(); 
            foreach (Pizza p in UserRepository.Basket)
            {
                _pizzaList.Add(p);
            }
            foreach (Pizza p in _pizzaList)
            {
                
                _cost += p.Price; 
            }
        }

        
        public List<Pizza> PizzaList { get { return _pizzaList; }}
        [BindProperty(SupportsGet = true)]
        public int Cost { get { return _cost; } set { _cost = value; }}
        [TempData]
        public string StatusMessage { get; set; }


        public void OnGet()
        {
            
        }

        public IActionResult OnPostOrder()
        {
            if (Cost <= UserRepository.Balance)
            {
                UserRepository.Balance -= Cost;
                return RedirectToPage("SeeYouNextTime");
            }
            StatusMessage = $"You don't have enough monkey on your account. \nThe cost is: {Cost} and your balance after purchase would be {UserRepository.Balance - Cost}."; 
            return Page(); 
            
        }

        public IActionResult OnPostCancel() {
            UserRepository.Basket.Clear();
            Cost = 0;
            return RedirectToPage("/Index"); 
        }
    }
}
