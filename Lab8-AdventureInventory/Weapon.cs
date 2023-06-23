using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_AdventureInventory
{
    internal class Weapon : Clue
    {
        private int _damage;
        private DamageType _damageType;
        public Weapon(string name, string description, double weight, double value) : base(name, description, weight, value)
        {
            _damage = 0;
            _damageType = DamageType.Piercing;
        }
    }
}
