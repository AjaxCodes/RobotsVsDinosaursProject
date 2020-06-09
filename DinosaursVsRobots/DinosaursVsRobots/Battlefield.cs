using System;
using System.Collections.Generic;
using System.Text;

namespace DinosaursVsRobots
{
    class Battlefield
    {
        //Member Variable (Has A




        //Teams ready to do battle
        Herd herd = new Herd();
        Fleet fleet = new Fleet();


        public Battlefield()
        {






        }
        public void RunBattle()
        {
            //if statements to check the health of each robot and dinosaur
            //can't attack if health <= 0
            //keep track of each dino or robot that gets defeated
            for (int index = 0; index < fleet.robots.Count; index++) //robot robot robot //dino dino dino
            {
                fleet.robots[index].Attack(herd.dinosaurs[index]);
                herd.dinosaurs[index].Attack(fleet.robots[index]);

                if (herd.dinosaurs[index].health <= 0)
                {
                    "Dino DOWN!!!!"
                }
                else if (herd.dinosaurs[index].health <= 0)
                {
                    "Dino DOWN!!!!"
                }
                else if (herd.dinosaurs[index].health <= 0)
                {
                    "Dino DOWN!!!!, ROBOTS WIN"
                }
                else if (fleet.robots[index].health <= 0)
                {
                    "Robot DOWN!!!!"
                }
                else if (fleet.robots[index].health <= 0)
                {
                    "Robot DOWN!!!!"
                }
                else if (fleet.robots[index].health <= 0) 
                {
                    "Robot DOWN!!!!, DINOSAURS WIN"
                }


            }
             


            






        }

    }            
                
                
}





   


