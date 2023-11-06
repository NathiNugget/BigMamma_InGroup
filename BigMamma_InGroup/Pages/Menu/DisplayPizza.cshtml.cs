using BigMamma_InGroup.model;
using BigMamma_InGroup.services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BigMamma_InGroup.Pages.Menu
{
    public class DisplayPizzaModel : PageModel
    {

        // Instance of PizzaRepository
        IPizzaRepository _pr;

        //DI
        public DisplayPizzaModel(IPizzaRepository pr)
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
