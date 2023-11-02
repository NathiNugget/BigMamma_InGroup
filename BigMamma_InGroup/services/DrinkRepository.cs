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
            _drinkList.Add(new Drink("Cola", 30, false, true, true));
            _drinkList.Add(new Drink("Fanta", 30, false, true, true));
            _drinkList.Add(new Drink("Pepsi Max", 30, false, true, false));
            _drinkList.Add(new Drink("Birra Moretti", 45, true, true, true));
        }
    }

    public List<Drink> DrinkList
    {
        get { return _drinkList; }
    }
}