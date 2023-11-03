namespace BigMamma_InGroup.model
{
    public class Drink : MenuItem
    {
        private bool _isAlcoholic;
        private bool _isVegan;
        private bool _isSugar;
        
        public Drink(string name, int price, bool isAlcoholic, bool isVegan, bool isSugar) : base(name, price)
        {
             _isAlcoholic = isAlcoholic;
            _isVegan = isVegan;
            _isSugar = isSugar;
        }

        public bool ContainsAlcohol { get { return _isAlcoholic; } set { _isAlcoholic = value; } }
        public bool IsVegan { get { return _isVegan;} set { _isVegan = value;} }
        public bool ContainsSugar { get { return _isSugar; } set { _isSugar = value; } }





    }
}
