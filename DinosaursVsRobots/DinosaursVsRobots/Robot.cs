using System;
using System.Collections.Generic;
using System.Text;

namespace DinosaursVsRobots
{
    public class Robot
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
            this.weapon = new Weapon(weaponName, weaponDamage);


        }

        


        // Member method (can do)

        public void Attack(Dinosaur dinosaur)
        {
            //dinosaur loses health based off of robot attack power
            dinosaur.health -= weapon.weaponDamage;
            
        }


    }
}




































