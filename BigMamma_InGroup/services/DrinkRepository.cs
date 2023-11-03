using BigMamma_InGroup.model;

namespace BigMamma_InGroup.services;

public class DrinkRepository
{

    private List<Drink> _drinkList;

    public DrinkRepository(bool test)
    {
        if (test)
        {
            _drinkList = new List<Drink>();
            DrinkList.Add(new Drink("Cola", 30, false, true, true));
            DrinkList.Add(new Drink("Fanta", 30, false, true, true));
            DrinkList.Add(new Drink("Pepsi Max", 30, false, true, false));
            DrinkList.Add(new Drink("Birra Moretti", 45, true, true, true));
        }
    }

    public List<Drink> DrinkList
    {
        get { return _drinkList; }
    }
}