using BigMamma_InGroup.model;
using BigMamma_InGroup.services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BigMamma_InGroup.Pages.Menu
{
    public class DrinksModel : PageModel
    {
        private DrinkRepository _repo;

        public DrinksModel(DrinkRepository repository)
        {
            _repo = repository;
        }

        public List<Drink> DrinkList { get; set; }

        public void OnGet()
        {
            DrinkList = _repo.DrinkList;
        }
    }
}
