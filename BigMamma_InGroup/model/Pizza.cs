namespace BigMamma_InGroup.model;

public class Pizza : MenuItem
{
    private bool _isVegan;
    private bool _isDeeppan;
    private bool _isClassic;
    private bool _isFamilySize;

    public Pizza(string name, int price, bool isVegan,bool isFamilySize, bool isDeeppan, bool isClassic) : base(name, price)
    {
        _isVegan = isVegan;
        _isDeeppan = isDeeppan;
        _isClassic = isClassic;
        _isFamilySize = isFamilySize;
    }

    public bool isVegan { get { return _isVegan; } set { _isVegan = value; } }
    public bool isDeeppan { get { return _isDeeppan; } set { _isDeeppan = value; } }
    public bool isClassic { get { return _isClassic; } set { _isClassic = value; } }
    public bool isFamilySize { get { return _isFamilySize; } set { _isFamilySize = value; } }
    
}