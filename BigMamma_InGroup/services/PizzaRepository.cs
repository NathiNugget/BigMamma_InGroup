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
                _pizzaList.Add(new Pizza("Magherita", 90, false, true, false, false));
            }
        }


    }
}
