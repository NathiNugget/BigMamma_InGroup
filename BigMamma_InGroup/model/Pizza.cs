namespace BigMamma_InGroup.model;

public class Pizza : MenuItem
{
    private bool _isVegan;
    private bool _isDeeppan;
    private bool _isClassic;

    public Pizza(string name, int price, bool isVegan, bool isDeeppan, bool isClassic) : base(name, price)
    {
        _isVegan = isVegan;
        _isDeeppan = isDeeppan;
        _isClassic = isClassic;
    }

    public bool isVegan { get { return _isVegan; } set { _isVegan = value; } }
    public bool isDeeppan { get { return _isDeeppan; } set { _isDeeppan = value; } }
    public bool isClassic { get { return _isClassic; } set { _isClassic = value; } }
}