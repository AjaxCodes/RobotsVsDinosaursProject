using System;
using System.Collections.Generic;
using System.Text;

namespace DinosaursVsRobots
{



    
    class Dinosaur
    {
        public String type;
        public int health;
        public int energy;
        public int attackPower;
        public Weapon weapon;
        public int tailSlapDamage = 15;
        public int biteDamage = 30;
        int pounceDamage = 45;


        public Dinosaur(string name, int health, int powerLevel, string weaponName, string weaponDamage) 
        
        {
            this.type = name;
            this.health = health;
            this.attackPower = powerLevel;
            this.weapon = new Weapon(weaponName, 0);







        }
        // Constructor (spawner)



        // Member method (can do)




    }
}
