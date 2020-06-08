using System;

namespace DinosaursVsRobots
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int x = 6;
            Robot robotOne = new Robot("Bender", 100, 2000,"trashTalkDamage", 45);
            Robot robotTwo = new Robot("Mechazilla",50,4000,"lazerbeamDamage", 30 );
            Robot robotThree = new Robot("Iron Giant", 200, 1000,"oilSprayDamage", 15);
            Dinosaur dinosaurOne = new Dinosaur("T-Rex", 100, 2000, "", 30);
            Dinosaur dinosaurTwo = new Dinosaur("Brontosaurus", 50, 4000, "", 15);
            Dinosaur dinosaurThree = new Dinosaur("Raptor", 200, 1000, "", 45);




            robotOne.health -= 10;
        }
    }
}
