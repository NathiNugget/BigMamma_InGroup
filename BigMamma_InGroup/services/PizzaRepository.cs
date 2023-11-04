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
                PizzaList.Add(new Pizza("Magherita", 90, false, true, false));
                PizzaList.Add(new Pizza("Cheap Pizza", 50, false, true, false));
                PizzaList.Add(new Pizza("Pepperoni", 90, false, true, false));
                PizzaList.Add(new Pizza("Vegetarian", 80, true, true, false));
                PizzaList.Add(new Pizza("Hawaiian", 85, false, true, false));
                PizzaList.Add(new Pizza("Meat Lovers", 95, false, true, true));
                PizzaList.Add(new Pizza("Mushroom", 80, false, true, false));
                PizzaList.Add(new Pizza("BBQ Chicken", 90, false, true, true));
                PizzaList.Add(new Pizza("Supreme", 100, false, true, false));
            }
        }

        public Pizza GetByName(string name)
        {
            foreach (Pizza p in PizzaList)
            {
                if (p.Name == name)
                {
                    Console.WriteLine("hej");
                    return p;
                }
            }
            return new Pizza("", 0, false, false, false); 
        }

        public List<Pizza> PizzaList 
        { 
            get {  return _pizzaList; }
            set { _pizzaList = value; }
            
        }

        public int GetIndex(string name)
        {
            for (int i = 0; i < PizzaList.Count; i++)
            {
                if (PizzaList[i].Name == name )
                {
                    return i; 
                }
            }
            return -1;
        }




    }
}
