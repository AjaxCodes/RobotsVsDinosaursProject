using System;

namespace DinosaursVsRobots
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



            Dinosaur dinosaurOne = new Dinosaur("T-Rex", 2000, 1, "BiteDamage", 30);
            Dinosaur dinosaurTwo = new Dinosaur("Brontosaurus", 4000, 1, "tailWhipDamage", 15);
            Dinosaur dinosaurThree = new Dinosaur("Raptor", 1000, 1, "pounceDamage", 45);

            Robot robotOne = new Robot("Bender", 1000, 1, "trashTalkDamage", 45);
            Robot robotTwo = new Robot("Mechazilla", 2000, 1, "lazerbeamDamage", 30);
            Robot robotThree = new Robot("Iron Giant", 4000, 1, "oilSprayDamage", 15);


            robotOne.health -= 10;
        }
    }
}
