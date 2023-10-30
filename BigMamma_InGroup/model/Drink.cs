namespace BigMamma_InGroup.model
{
    public class Drink : MenuItem
    {
        private bool _containsAlcohol;
        private bool _isVegan;
        private bool _containssugar;
        
        public Drink(string name, int price, bool containsAlcohol, bool isVegan, bool containsSugar) : base(name, price)
        {
             _containsAlcohol = containsAlcohol;
            _isVegan = isVegan;
            _containssugar = containsSugar;
        }

        public bool ContainsAlcohol { get { return _containsAlcohol; } set { _containsAlcohol = value; } }
        public bool IsVegan { get { return _isVegan;} set { _isVegan = value;} }
        public bool ContainsSugar { get { return _containssugar; } set { _containssugar = value; } }


    }
}
