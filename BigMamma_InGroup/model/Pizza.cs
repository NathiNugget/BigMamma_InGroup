using BigMamma_InGroup.Pages.Menu;
using BigMamma_InGroup.services;

namespace BigMamma_InGroup.model;

public class Pizza : MenuItem

{

    private bool _isVegan;
    private bool _isDeepPan;
    private bool _isClassic;
    private bool _isFamilySize;

    public Pizza(string name, int price, bool isVegan,bool isFamilySize, bool isDeepPan, bool isClassic) : base(name, price)
    {
        _isVegan = isVegan;
        _isDeepPan = isDeepPan;
        _isClassic = isClassic;
        _isFamilySize = isFamilySize;
    }

    public bool isVegan { get { return _isVegan; } set { _isVegan = value; } }
    public bool isDeeppan { get { return _isDeepPan; } set { _isDeepPan = value; } }
    public bool isClassic { get { return _isClassic; } set { _isClassic = value; } }
    public bool isFamilySize { get { return _isFamilySize; } set { _isFamilySize = value; } }
    
    
}