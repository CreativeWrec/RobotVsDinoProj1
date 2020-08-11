using System;
using System.Collections.Generic;
using System.Text;

namespace Dino_Vs_Robots
{
    class Dinosaur
    {
        //Variable (has a)
        public string type;
        public double dinoHealth;
        public double energy;
        public double attackPower;
        //Constuctor
        public Dinosaur()
        {
            Random rng = new Random();
            type = AskForDinoType();
            dinoHealth = 1;
            energy = 100;
            attackPower = rng.Next(minValue: 1, maxValue: 25);

        }
        //Method (can do)

        public string AskForDinoType()
        {
            Console.WriteLine("What type of Dinosaur is it?");
            string result = Console.ReadLine();
            return result;
        }
        public void EnergyUsage()
        {
            energy -= 10;
        }
        public void Attack(Robot robot)
        {
            EnergyUsage();
            robot.robotHealth -= attackPower;
        }
    }
}
