using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_AdventureInventory
{
    internal class Clue : Item
    {
        private string _personIncriminated;
        private bool _accuracy;

        public Clue(string name, string description, double weight, double value) : base(name, description, weight, value)
        {
            _personIncriminated = "name";
            _accuracy = false;
        }
    }
}
