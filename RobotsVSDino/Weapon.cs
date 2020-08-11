using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Dino_Vs_Robots
{
    class Weapon
    {
        //Variable (has a)        
        public List<string> weaponTypes = new List<string>();
        public double attackPower;
        public string type;
        //Constuctor
        public Weapon()
        {
            Random rng = new Random();
            this.weaponTypes = new List<string>() {"Laser Cannon", "Laser Sword", "Heat-Seeking Missles"};

            int randomIndex = rng.Next(0, this.weaponTypes.Count);

            this.type = weaponTypes[randomIndex];
            this.attackPower = rng.Next(minValue: 1, maxValue: 50);

        }
        //Method (can do)

    }
}
