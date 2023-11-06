namespace BigMamma_InGroup.model;

public class Pizza : MenuItem

{
    #region Instance Fields
    private bool _isVegan;
    private bool _isDeepPan;
    private bool _isClassic;
    private bool _isFamilySize;

    #endregion

    #region Methods
    public Pizza(string name, int price, bool isVegan, bool isFamilySize, bool isDeepPan) : base(name, price)
    {
        _isVegan = isVegan;
        _isDeepPan = isDeepPan;
        _isClassic = !isVegan && !isFamilySize && !isDeepPan;
        _isFamilySize = isFamilySize;

    }
    public char GetChar(bool issomeproperty)
    {
        return issomeproperty ? '✅' : '❌';
    }



    #endregion

    #region Properties
    public bool isVegan { get { return _isVegan; } set { _isVegan = value; } }
    public bool isFamilySize { get { return _isFamilySize; } set { _isFamilySize = value; } }
    public bool isDeeppan { get { return _isDeepPan; } set { _isDeepPan = value; } }
    public bool isClassic { get { return _isClassic; } set { _isClassic = value; } }


    #endregion



}