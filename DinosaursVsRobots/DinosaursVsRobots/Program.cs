using System;

namespace DinosaursVsRobots
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int x = 6;
            Robot robotOne = new Robot("Bender", 100, 2000,);
            Robot robotTwo = new Robot("Mechazilla",50,4000,);
            Robot robotThree = new Robot("", 200, 1000,);

            robotOne.health -= 10;
        }
    }
}
