using BigMamma_InGroup.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BigMamma_InGroup.Pages.Menu
{
    public class DeletePizzaModel : PageModel
    {
        [BindProperty]
        public string ToDeleteName { get; set; }
        [BindProperty]
        public int ToDeletePrice { get; set; }

        private IPizzaRepository _pr;

        public DeletePizzaModel(IPizzaRepository pr)
        {
            _pr = pr;
        }
        public static int index;
        public void OnGet(string Name)
        {
            ToDeleteName = Name;
            ToDeletePrice = _pr.GetByName(ToDeleteName).Price;
            index = _pr.GetIndex(ToDeleteName);

        }

        public IActionResult OnPostDelete()
        {
            _pr.DeletePizza(_pr.PizzaList[index]);
            return RedirectToPage("DisplayPizza");
        }

        public IActionResult OnPostCancel()
        {
            return RedirectToPage("DisplayPizza");
        }


    }
}
