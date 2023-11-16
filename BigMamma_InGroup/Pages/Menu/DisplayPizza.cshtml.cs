using BigMamma_InGroup.model;
using BigMamma_InGroup.services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BigMamma_InGroup.Pages.Menu
{
    public class DisplayPizzaModel : PageModel
    {

        // Instance of PizzaRepository
        IPizzaRepository _pr;
        [BindProperty]
        public string Search { get; set; }
        public static bool Sorted { get; set; } = false; 

        //DI
        public DisplayPizzaModel(IPizzaRepository pr)
        {
            _pr = pr;
            
        }

        public bool IsSorted() { return Sorted; }

        public List<Pizza> PizzaList { get; set; }
        public List<Pizza> SortedList { get; set; }
        public List<Pizza> OrigList { get; set; }


        public void OnGet(bool Sorted = false)
        {
            if (!Sorted)
            {
                PizzaList = _pr.PizzaList;
                OrigList = _pr.PizzaList;
            }
            else {
                OrigList = _pr.PizzaList; 
                PizzaList = _pr.PizzaList.OrderBy(x => x.Price).ToList();
                
            }
        }

        public IActionResult OnPostSearch(string search)
        {
            OrigList = _pr.PizzaList;
            PizzaList = new List<Pizza>(); 
            foreach (Pizza p in OrigList)
            {
                if (search == null)
                {
                    PizzaList.Add(p);
                }
                else
                {
                    if (p.Name.ToUpper().Contains(search.ToUpper() ?? ""))
                    {
                        PizzaList.Add(p);
                    }
                    else 
                    {
                        if (int.TryParse(search, out int num))
                        {
                            if (p.Price ==  num) {
                                PizzaList.Add(p);
                            }
                            
                        }
                    }
                }
            }
            return Page(); 

        }


        public IActionResult OnPost()
        {
            Sorted = !Sorted;
            UserRepository.IsSorted = Sorted;
            return RedirectToPage("DisplayPizza" , new {Sorted}); 
        }
    }
}
