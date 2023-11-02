using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BigMamma_InGroup.model;
using BigMamma_InGroup.services;

namespace BigMamma_InGroup.Pages.Menu
{
    public class DisplayPizzaModel : PageModel
    {

        // Instance of PizzaRepository
        PizzaRepository _pr; 

        //DI
        public DisplayPizzaModel(PizzaRepository pr)
        {
            _pr = pr;
        }

        public List<Pizza> PizzaList { get; set; }
        public void OnGet()
        {
            PizzaList = _pr.PizzaList; 
        }
    }
}
