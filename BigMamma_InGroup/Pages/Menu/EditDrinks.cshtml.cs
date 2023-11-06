using System.ComponentModel.DataAnnotations;
using BigMamma_InGroup.model;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BigMamma_InGroup.services;
using Microsoft.AspNetCore.Mvc;

namespace BigMamma_InGroup.Pages.Menu;

public class EditDrinksModel : PageModel
{
    private DrinkRepository _dr;
    public EditDrinksModel(DrinkRepository dr) {
        _dr = dr;
    }
     
    private Drink _piz;
    private static int id = 0; 

    [BindProperty]
    public string NewName { get; set; }
    [BindProperty]
    [Required(ErrorMessage = "You have to put in a price!!!")]
    [Range(10, 1000, ErrorMessage = "You have to put in a pricebetween 10 and 1000")]
        
    public int NewPrice { get; set; }
        
        
        
    public void OnGet(string name)
    {
        _piz = _dr.GetByName(name);
        id = _dr.GetIndex(name); 
        NewName = _piz.Name;
        NewPrice = _piz.Price;
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

