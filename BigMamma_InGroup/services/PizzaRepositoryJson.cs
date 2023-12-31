﻿using BigMamma_InGroup.model;
using System.Text.Json;

namespace BigMamma_InGroup.services
{
    public class PizzaRepositoryJson : IPizzaRepository
    {
        private List<Pizza> _pizzaList;

        public List<Pizza> PizzaList { get { return _pizzaList; } set { _pizzaList = value; } }
        public static bool Sorted = false;

        #region Constructor
        public PizzaRepositoryJson()
        {
            _pizzaList = ReadFromJson();
            _pizzaList.Add(new Pizza("Meat Lovers", 95, false, true, true));
        }

        private const string FILENAME = "PizzaRepository.json";
        private List<Pizza>? ReadFromJson()
        {
            if (File.Exists(FILENAME))
            {

                using (StreamReader Reader = File.OpenText(FILENAME))
                {
                    return JsonSerializer.Deserialize<List<Pizza>>(Reader.ReadToEnd());
                   
                }
                


            }
            return new List<Pizza>();

        }


        public void WriteToJson()
        {

            using (FileStream fs = new FileStream(FILENAME, FileMode.Create))
            {
                Utf8JsonWriter writer = new Utf8JsonWriter(fs);
                JsonSerializer.Serialize(writer, _pizzaList);
                fs.Close();
            }

        }
        #endregion

        #region Methods
        public Pizza GetByName(string name)
        {
            WriteToJson();
            foreach (Pizza p in _pizzaList)
            {
                if (p.Name == name) return p;
            }
            return null;
        }

        public int GetIndex(string name)
        {
            WriteToJson();
            for (int i = 0; i < _pizzaList.Count; i++)
            {
                if (_pizzaList[i].Name == name) { return i; }
            }
            return -1;
        }

        public void AddPizza(Pizza pizza)
        {
            _pizzaList.Add(pizza);
            Console.WriteLine(_pizzaList.Count);
            WriteToJson();
        }

        public void DeletePizza(Pizza pizza)
        {
            _pizzaList.Remove(pizza);
            WriteToJson();
        }
        #endregion
    }
}
