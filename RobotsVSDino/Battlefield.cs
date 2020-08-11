using Dino_Vs_Robots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVSDino
{
    class Battlefield
    {
        //Variable (has a)
        public Fleet fleet = new Fleet();
        public Herd herd = new Herd();

        public Battlefield()
        {

        }

        public void Battle()
        {
            while (fleet.robots[0].robotHealth > 0)
            {

                fleet.robots[0].Attack(herd.dinosaurs[0]);
                if (herd.dinosaurs[0].dinoHealth <= 0)
                {
                    herd.dinosaurs.RemoveAt(0);
                }

                if (fleet.robots.Count > 0)
                    herd.dinosaurs[0].Attack(fleet.robots[0]);

            }
        }
    }
}
