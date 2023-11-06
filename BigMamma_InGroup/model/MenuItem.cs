namespace BigMamma_InGroup.model
{
    public abstract class MenuItem
    {
        private string _name;
        private int _price;
        public MenuItem(string name, int price)
        {
            _name = name;
            _price = price;
        }

        public string Name { get { return _name; } set { _name = value; } }
        public int Price { get { return _price; } set { _price = value; } }

    }
}
