using BigMamma_InGroup.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BigMamma_InGroup.Pages.Menu
{
    public class PizzaModel : PageModel
    {
        public void OnGet()
        {

            PizzaRepository pizzaRepo = new PizzaRepository(true);
            

        }
    }
}
