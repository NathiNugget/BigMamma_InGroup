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
                PizzaList.Add(new Pizza("Pepperoni", 90, false, true, false, false));
                PizzaList.Add(new Pizza("Vegetarian", 80, true, true, false, false));
                PizzaList.Add(new Pizza("Hawaiian", 85, false, true, false, false));
                PizzaList.Add(new Pizza("Meat Lovers", 95, false, true, true, false));
                PizzaList.Add(new Pizza("Mushroom", 80, false, true, false, false));
                PizzaList.Add(new Pizza("BBQ Chicken", 90, false, true, true, false));
                PizzaList.Add(new Pizza("Supreme", 100, false, true, false, false));
            }
        }

        public Pizza GetByName(string name)
        {
            foreach (var p in PizzaList)
            {
                if (p.Name == name) return p;
            }
            return new Pizza("", 0, false, false, false, false); 
        }

        public List<Pizza> PizzaList 
        { 
            get {  return _pizzaList; }
            
        }




    }
}
