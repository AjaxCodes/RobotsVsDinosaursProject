using System;
using System.Collections.Generic;
using System.Text;

namespace DinosaursVsRobots
{
    public class Fleet
    {
        // member variable (has a)
        public int oilSprayDamage = 15;
        public int lazerBeamDamage = 30;
        public int trashtalkDamage = 45;

        public List<Robot> robots = new List<Robot>();

        
        // Constructor (spawner)




        // Member method (can do)
        public void PopulateFleet()
        {     //Robots pit into FLEET
            Robot robotOne = new Robot("Bender", 1000, 1, "trashTalkDamage", 45);
            Robot robotTwo = new Robot("Mechazilla", 2000, 1, "lazerbeamDamage", 30);
            Robot robotThree = new Robot("Iron Giant", 4000, 1, "oilSprayDamage", 15);
            
            robots.Add(robotOne);
            robots.Add(robotTwo);
            robots.Add(robotThree);

            // ATTACK METHOD

        }
    }
}
