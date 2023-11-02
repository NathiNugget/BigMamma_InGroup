using BigMamma_InGroup.model;

namespace BigMamma_InGroup.services
{
    public class PizzaRepository
    {

        private List<Pizza> _pizzaList;


        public PizzaRepository(bool test) 
        {
            if (test)
            {
                _pizzaList = new List<Pizza>();
                PizzaList.Add(new Pizza("Magherita", 90, false, true, false, false));
                PizzaList.Add(new Pizza("Cheap Pizza", 50, false, true, false, false));

            }
        }

        public List<Pizza> PizzaList 
        { 
            get {  return _pizzaList; }
            
        }


    }
}
