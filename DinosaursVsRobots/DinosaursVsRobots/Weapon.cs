using System;
using System.Collections.Generic;
using System.Text;

namespace DinosaursVsRobots
{

    class Weapon
    {
        // member variable (has a)
        public string weaponName;
        public int weaponDamage;

        //public int tailSlapDamage = 5;
        //public int biteDamage = 9;
        //public int pounceDamage = 15;


        // Constructor (spawner)
        public Weapon(string name, int damage)
        {
            weaponName = name;
            weaponDamage = damage;
        }


        // Member method (can do)

    }
}