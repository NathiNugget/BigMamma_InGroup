using BigMamma_InGroup.model;
using BigMamma_InGroup.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BigMamma_InGroup.Pages.Menu
{
    public class PutInBasketModel : PageModel
    {
        private IPizzaRepository _pr;
        public PutInBasketModel(IPizzaRepository pr) {
            _pr = pr; 
        }
        public IActionResult OnGet(string name)
        {
            UserRepository.Basket.Add(_pr.GetByName(name));
            return RedirectToPage("/Index");  
        }
    }
}
