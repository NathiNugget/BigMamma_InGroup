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

    public Drink GetByName(string name)
    {
        foreach (Drink d in DrinkList)
        {
            if (d.Name == name)
            {
                Console.WriteLine("hej");
                return d;
            }
        }

        return new Drink("", 0, false, false, false);
    }

    public List<Drink> DrinkList
    {
        get { return _drinkList; }
        set { _drinkList = value; }
    }

    public int GetIndex(string name)
    {
        for (int i = 0; i < DrinkList.Count; i++)
        {
            if (DrinkList[i].Name == name)
            {
                return i;
            }
        }

        return -1;
    }
}
    