using BigMamma_InGroup.model;

namespace BigMamma_InGroup.services
{
    public class SandwichRepository
    {
        private List<Sandwich> _sandwichList;

        public SandwichRepository(bool test)
        {
            if(test)
            {
                _sandwichList = new List<Sandwich>();
                _sandwichList.Add(new Sandwich("Pollo & Panchetta", 69, false));
                _sandwichList.Add(new Sandwich("Skinke", 69, false));
                _sandwichList.Add(new Sandwich("Mortadella", 69, false));
                _sandwichList.Add(new Sandwich("Parma", 69, false));
            }
        }
        public List<Sandwich> SandwichList
        {
            get { return _sandwichList; }
        }
    }
}
