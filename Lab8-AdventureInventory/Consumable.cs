using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_AdventureInventory
{
    internal class Consumable : Item
    {
        private int _healthEffect;
        private int _dosesRemaining;
        public Consumable(string name, string description, double weight, double value) : base(name, description, weight, value)
        {
            _healthEffect = 0;
            _dosesRemaining = 0;
        }
    }
}
