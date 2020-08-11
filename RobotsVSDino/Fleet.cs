using System;
using System.Collections.Generic;
using System.Text;

namespace Dino_Vs_Robots
{
    class Fleet
    {
        //Variable (has a)

        public List<Robot> robots = new List<Robot>();

        //Constuctor
        public Fleet()
        {
            Robot robot1 = new Robot();
            Robot robot2 = new Robot();
            Robot robot3 = new Robot();
            // fill up the list of robots
            robots.Add(robot1);
            robots.Add(robot2);
            robots.Add(robot3);

            foreach (Robot robot in robots)
            {
                Console.WriteLine(robot.name + " has booted up");
            }
        }
        //Method (can do)

    }
}
