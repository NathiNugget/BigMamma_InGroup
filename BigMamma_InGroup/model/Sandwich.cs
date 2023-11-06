namespace BigMamma_InGroup.model;

public class Sandwich : MenuItem
{
    public Sandwich(string name, int price, bool isVegan) : base(name, price)
    {
        IsVegan = isVegan;
    }

    public bool IsVegan { get; set; }
}