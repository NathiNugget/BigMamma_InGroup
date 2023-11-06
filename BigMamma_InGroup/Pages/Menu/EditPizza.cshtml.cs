using BigMamma_InGroup.model;
using BigMamma_InGroup.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace BigMamma_InGroup.Pages.Menu
{
    public class EditPizzaModel : PageModel
    {
        private IPizzaRepository _pr;
        public EditPizzaModel(IPizzaRepository pr) {
            _pr = pr;
        }
     
        private Pizza _piz;
        private static int id = 0; 

        [BindProperty]
        public string NewName { get; set; }
        [BindProperty]
        [Required(ErrorMessage = "You have to put in a price!!!")]
        [Range(10, 1000, ErrorMessage = "You have to put in a pricebetween 10 and 1000")]
        
        public int NewPrice { get; set; }
        
        
        
        public void OnGet(string name)
        {
            _piz = _pr.GetByName(name);
            id = _pr.GetIndex(name); 
            NewName = _piz.Name;
            NewPrice = _piz.Price;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page(); 
            }
            Pizza ToBeAdded = _pr.PizzaList[id]; 
            ToBeAdded.Name = NewName;
            ToBeAdded.Price = NewPrice;
            return RedirectToPage("DisplayPizza"); 
        }
        
        
    }
}
