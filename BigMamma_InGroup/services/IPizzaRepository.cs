using BigMamma_InGroup.model;

namespace BigMamma_InGroup.services
{
    public interface IPizzaRepository
    {
        List<Pizza> PizzaList { get; set; }

        Pizza GetByName(string name);
        int GetIndex(string name);

        void AddPizza(Pizza pizza);
        void DeletePizza(Pizza pizza);
    }
}