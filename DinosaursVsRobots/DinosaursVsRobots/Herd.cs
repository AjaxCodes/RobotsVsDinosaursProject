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


        public List<Dinosaur> dinosaurs = new List <Dinosaur>();
        public Herd()
        {


            

        }
       

        



        // Constructor (spawner)
        // Member method (can do)
        public void PopulateHerd()
        {
            dinosaurOne = new Dinosaur("T-Rex", 2000, 1, "BiteDamage", 30);
            dinosaurTwo = new Dinosaur("Brontosaurus", 4000, 1, "tailWhipDamage", 15);
            dinosaurThree = new Dinosaur("Raptor", 1000, 1, "pounceDamage", 45);

            dinosaurs.Add(dinosaurOne);
            dinosaurs.Add(dinosaurTwo);
            dinosaurs.Add(dinosaurThree);
        }
    }
}
