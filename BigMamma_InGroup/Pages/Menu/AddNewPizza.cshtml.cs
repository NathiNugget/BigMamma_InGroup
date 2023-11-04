using BigMamma_InGroup.model;
using BigMamma_InGroup.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BigMamma_InGroup.Pages.Menu
{
    public class AddNewPizzaModel : PageModel
    {
        [BindProperty]
        public string NewName { get; set; }
        [BindProperty]
        public int NewPrice { get; set; }

        private PizzaRepository _pr; 

        public AddNewPizzaModel(PizzaRepository pr)
        {
            _pr = pr;
        }

        public void OnGet()
        {
     
        }

        public IActionResult OnPost()
        {
            Pizza p = new Pizza(NewName, NewPrice, false, false, false);
            _pr.PizzaList.Add(p);
            return RedirectToPage("DisplayPizza");

        }
    }
}
