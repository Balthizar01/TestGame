using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGame
{
    public class Player
    {
        public string Name;
        public string PClass;
        public int Level, Strength, Health, Mana, Experience;

        public Player()
        {
            Name = "Balthizar";
            PClass = "Paladin";
            Level = 1;
            Strength = 7;
            Health = 100;
            Mana = 50;
            Experience = 0;
        }

        public Player(string name, string pClass, int level, int strength, int health, int mana, int experience)
        {
            Name = name;
            PClass = pClass;
            Level = level;
            Strength = strength;
            Health = health;
            Mana = mana;
            Experience = experience;
        }

    }
}
