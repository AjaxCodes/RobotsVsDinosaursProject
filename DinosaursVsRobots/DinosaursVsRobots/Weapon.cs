using System;
using System.Collections.Generic;
using System.Text;

namespace DinosaursVsRobots
{

    public class Weapon
    {
        // member variable (has a)
        public string weaponName;
        public int weaponDamage;
        //Dino Damage---------------------
        public int tailSlapDamage = 15;
        public int biteDamage = 30;
        public int pounceDamage = 45;
        
        //Robot Damage--------------------
        public int oilSprayDamage = 15;
        public int lazerBeamDamage = 30;
        public int trashtalkDamage = 45;

        // Constructor (spawner)
        public Weapon(string name, int damage)
        {
            weaponName = name;
            weaponDamage = damage;


         
        }


        // Member method (can do)

    }
}