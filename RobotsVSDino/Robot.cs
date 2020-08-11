using System;
using System.Collections.Generic;
using System.Text;

namespace Dino_Vs_Robots
{
    class Robot
    {
        //Variable (has a)
        public string name;
        public double robotHealth;
        public double powerLevel;
        public Weapon weapon;
        //Constuctor
        public Robot()
        {
            Random rng = new Random();
            this.name = AskForRobotName();
            this.robotHealth = 1;
            this.powerLevel = 100;
            this.weapon = new Weapon();
        }
        //Method (can do)

        public string AskForRobotName()
        {
            Console.WriteLine("What is your Robot's name?");
            string result = Console.ReadLine();
            return result;
        }
        public void PowerLevelCheck()
        {
            powerLevel -= 10;
        }
        public void Attack(Dinosaur dinosaur)
        {
            PowerLevelCheck();
            dinosaur.dinoHealth -= weapon.attackPower;
        }
    }
}
