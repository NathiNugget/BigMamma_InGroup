using BigMamma_InGroup.model;
using BigMamma_InGroup.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace BigMamma_InGroup.Pages.Menu
{
    public class AddNewPizzaModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "Name needed!")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Pizza name has to be between 4 and 20 letters")]
        
        public string NewName { get; set; }
        [BindProperty]
        [Required(ErrorMessage = "You have to put in a price!!!")]
        [Range(10, 1000, ErrorMessage = "You have to put in a price between 10 and 1000")]

        public int NewPrice { get; set; }

        private IPizzaRepository _pr;


        public AddNewPizzaModel(IPizzaRepository pr)
        {
            _pr = pr;
        }

        public void OnGet()
        {
            NewName = "";
            NewPrice = 0;
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Pizza p = new Pizza(NewName, NewPrice, false, false, false);
                _pr.AddPizza(p);
                return RedirectToPage("DisplayPizza");
            }
            return Page(); 
            

        }
    }
}
