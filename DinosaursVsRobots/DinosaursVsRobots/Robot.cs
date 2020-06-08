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
        public int oilSprayDamage = 15;
        public int lazerBeamDamage = 30;
        public int trashtalkDamage = 45;


        // Constructor (spawner)
        public Robot(string name, int health, int powerLevel, string weaponName, int weaponDamage)
        {

            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;
            this.weapon = new Weapon(weaponName, 0);





        }



        //Robot Damage--------------------




        // Member method (can do)




    }
}




































