using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_AdventureInventory
{
    internal class Item
    {
        protected string _name;
        protected string _description;
        protected double _weight;
        protected double _value;
        public Item(string name, string description, double weight, double value)
        {
            _name = name;
            _description = description;
            _weight = weight;
            _value = value;
        }

        public string ToString()
        {
            return $"Item name: {_name}\nDescription: {_description}\nWeight: {_weight} pounds\nValue: {_value} gold pieces.";
        }

    }
}
