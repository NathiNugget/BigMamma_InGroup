using BigMamma_InGroup.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BigMamma_InGroup.Pages.Menu
{
public class DeleteSandwich : PageModel
{
    [BindProperty]
    public string ToDeleteName { get; set; }
    [BindProperty]
    public int ToDeletePrice { get; set; }

    private SandwichRepository _sr;

    public DeleteSandwich(SandwichRepository sr)
    {
        _sr= sr;
    }
    public static int index;
    public void OnGet(string Name)
    {
        ToDeleteName = Name;
        ToDeletePrice = _sr.GetByName(ToDeleteName).Price;
        index = _sr.GetIndex(ToDeleteName);

    }

    public IActionResult OnPostDelete()
    {
        _sr.DeleteSandwich(_sr.SandwichList[index]);
        return RedirectToPage("Sandwich");
    }

    public IActionResult OnPostCancel()
    {
        return RedirectToPage("Sandwich");
    }


}
}