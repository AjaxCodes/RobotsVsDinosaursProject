using System;
using System.Collections.Generic;
using System.Text;

namespace DinosaursVsRobots
{
    class Battlefield
    {
        //Member Variable (Has A

        


        //Teams ready to do battle
        Herd herd = new Herd ();
        Fleet fleet = new Fleet();


        public Battlefield()
        {






        }
        public void RunBattle()
        {

            for (int index = 0; index < fleet.robots.Count; index++)
            {
                fleet.robots[0].Attack();
                herd.dinosaurs[0].attackPower();
            }

            


            //Robot robot = new Robot();
            //Dinosaur dinosaur = new Dinosaur();
            //robot.Attack(dinosaur);
        
        }













        //Constructor (Spawner)



        // Member method (Can Do)












    }




}


