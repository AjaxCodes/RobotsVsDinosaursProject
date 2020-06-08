using System;
using System.Collections.Generic;
using System.Text;

namespace DinosaursVsRobots
{
    class Herd
    {
        // member variable (has a)
        Dinosaur dinosaurOne;
        Dinosaur dinosaurTwo;
        Dinosaur dinosaurThree;
        //Dino Damage---------------------
        public int tailSlapDamage = 15;
        public int biteDamage = 30;
        public int pounceDamage = 45;

        public Herd()
        {


            dinosaurOne = new Dinosaur("T-Rex", 100, 2000, "", 30);
            dinosaurTwo = new Dinosaur("Brontosaurus", 50, 4000, "", 15);
            dinosaurThree = new Dinosaur("Raptor", 200, 1000, "", 45);

        }
       

        



        // Constructor (spawner)
        // Member method (can do)
    }
}
