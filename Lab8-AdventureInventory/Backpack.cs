using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_AdventureInventory
{
    internal class Backpack
    {
        private List<Item> _contents;

        public Backpack()
        {
            _contents = new List<Item>();
        }

        public Backpack(List<Item> contents)
        {
            _contents = contents;
        }

        public void Add(Item item)
        {
            _contents.Add(item);
        }

        public string ListWeapons()
        {
            string weapons = "Weapons----------------------------------------------\n";
            foreach (Item item in _contents) 
            {
                if (item is Weapon)
                {
                    weapons = weapons + item.ToString() + "\n----------------------------------------------\n";
                }
            }
            return weapons;
        }

        public string ListClues()
        {
            string clues = "Clues----------------------------------------------\n";
            foreach (Item item in _contents)
            {
                if (item is Clue)
                {
                    clues = clues + item.ToString() + "\n----------------------------------------------\n";
                }
            }
            return clues;
        }

        public string ListConsumables()
        {
            string consumeables = "Consumeables----------------------------------------------\n";
            foreach (Item item in _contents)
            {
                if (item is Consumable)
                {
                    consumeables = consumeables + item.ToString() + "\n----------------------------------------------\n";
                }
            }
            return consumeables;
        }

    }
}
