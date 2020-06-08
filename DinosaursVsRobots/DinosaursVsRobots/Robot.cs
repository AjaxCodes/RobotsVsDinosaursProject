using System;
using System.Collections.Generic;
using System.Text;

namespace DinosaursVsRobots
{
    class Robot
    {

        // member variable (has a)
        public String name;
        public int health;
        public int powerLevel;
        public Weapon weapon;
        public int Damage = 15;
        public int biteDamage = 30;
        int pounceDamage = 45;


        // Constructor (spawner)
        public Robot(string name, int health, int powerLevel, string weaponName, string weaponDamage)
        {
            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;
            this.weapon = new Weapon(weaponName, 0);



            // ("MechDroid", 100, 2000);
        }



        // Member method (can do)
    }
}
