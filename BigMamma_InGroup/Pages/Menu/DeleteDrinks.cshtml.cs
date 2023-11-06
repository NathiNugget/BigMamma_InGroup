using BigMamma_InGroup.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BigMamma_InGroup.Pages.Menu;

public class DeleteDrinks : PageModel
{
    [BindProperty]
    public string ToDeleteName { get; set; }
    [BindProperty] 
    public int ToDeletePrice { get; set; }

    private DrinkRepository _dr;

    public DeleteDrinks(DrinkRepository dr)
    {
        _dr = dr;
    }
    public static int index; 
    public void OnGet(string Name)
    {
        ToDeleteName = Name;
        ToDeletePrice = _dr.GetByName(ToDeleteName).Price; 
        index = _dr.GetIndex(ToDeleteName);
               
    }

    public IActionResult OnPostDelete()
    {
        _dr.DrinkList.Remove(_dr.DrinkList[index]);
        return RedirectToPage("Drinks");
    }

    public IActionResult OnPostCancel(){
        return RedirectToPage("Drinks");
    }
        

}

