using BigMamma_InGroup.model;
using BigMamma_InGroup.services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BigMamma_InGroup.Pages.Menu;

public class SandwichModel : PageModel
{
   
        private SandwichRepository _repo;
        private List<Sandwich> _sandList; 

        public SandwichModel(SandwichRepository repository)
        {
            _repo = repository;
        }

        public List<Sandwich> SandwichList
        {
            get { return _sandList;}
            set { _sandList = value; }
        }

        public void OnGet()
        {
            _sandList = _repo.SandwichList;
        }
    }

