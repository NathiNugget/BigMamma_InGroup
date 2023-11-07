using BigMamma_InGroup.model;
using BigMamma_InGroup.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace BigMamma_InGroup.Pages.Menu;

public class EditDrinksModel : PageModel
{
    private DrinkRepository _dr;
    public EditDrinksModel(DrinkRepository dr)
    {
        _dr = dr;
    }

    private Drink _drink;
    private static int id = 0;

    [BindProperty]
    public string NewName { get; set; }
    [BindProperty]
    [Required(ErrorMessage = "You have to put in a price!!!")]
    [Range(10, 1000, ErrorMessage = "You have to put in a pricebetween 10 and 1000")]

    public int NewPrice { get; set; }



    public void OnGet(string name)
    {
        _drink = _dr.GetByName(name);
        id = _dr.GetIndex(name);
        NewName = _drink.Name;
        NewPrice = _drink.Price;
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }
        Drink ToBeAdded = _dr.DrinkList[id];
        ToBeAdded.Name = NewName;
        ToBeAdded.Price = NewPrice;
        return RedirectToPage("Drinks");
    }


}


