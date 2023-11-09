using BigMamma_InGroup.model;

namespace BigMamma_InGroup.services
{
    public class SandwichRepository
    {
        private List<Sandwich> _sandwichList;

        public SandwichRepository(bool test)
        {
            if (test)
            {
                _sandwichList = new List<Sandwich>();
                SandwichList.Add(new Sandwich("Pollo & Panchetta", 69, false));
                SandwichList.Add(new Sandwich("Skinke", 69, false));
                SandwichList.Add(new Sandwich("Mortadella", 69, false));
                SandwichList.Add(new Sandwich("Parma", 69, false));
            }
        }

        public List<Sandwich> SandwichList
        {
            get { return _sandwichList; }
            set { _sandwichList = value; }
        }

        public Sandwich GetByName(string name)
        {
            foreach (Sandwich s in SandwichList)
            {
                if (s.Name == name)
                {
                    Console.WriteLine("hej");
                    return s;
                }
            }

            return new Sandwich("", 0, false);
        }

        public int GetIndex(string name)
        {
            for (int i = 0; i < SandwichList.Count; i++)
            {
                if (SandwichList[i].Name == name)
                {
                    return i;
                }
            }

            return -1;
            
         
        }public void AddSandwich(Sandwich Sandwich)
        {
            _sandwichList.Add(Sandwich);
        }

        public void DeleteSandwich(Sandwich Sandwich)
        {
            _sandwichList.Remove(Sandwich);
        }
    }
    
}
        
