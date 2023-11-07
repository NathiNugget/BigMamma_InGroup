using BigMamma_InGroup.model;
using BigMamma_InGroup.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace BigMamma_InGroup.Pages.Menu
{
    public class EditSandwichModel : PageModel
    {
        private SandwichRepository _sr;

        public EditSandwichModel(SandwichRepository sr)
        {
            _sr = sr;
        }

        private Sandwich _sandwich;
        private static int id = 0;

        [BindProperty] public string NewName { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "You have to put in a price!!!")]
        [Range(10, 1000, ErrorMessage = "You have to put in a pricebetween 10 and 1000")]

        public int NewPrice { get; set; }



        public void OnGet(string name)
        {
            _sandwich = _sr.GetByName(name);
            id = _sr.GetIndex(name);
            NewName = _sandwich.Name;
            NewPrice = _sandwich.Price;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Sandwich ToBeAdded = _sr.SandwichList[id];
            ToBeAdded.Name = NewName;
            ToBeAdded.Price = NewPrice;
            return RedirectToPage("Drinks");
        }

    }
}


