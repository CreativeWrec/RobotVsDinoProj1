using System;
using System.Collections.Generic;
using System.Text;

namespace Dino_Vs_Robots
{
    class Herd
    {
        //Variable (has a)
        public List<Dinosaur> dinosaurs = new List<Dinosaur>();

        //Constuctor
        public Herd()
        {
            Dinosaur dinosaur1 = new Dinosaur();
            Dinosaur dinosaur2 = new Dinosaur();
            Dinosaur dinosaur3 = new Dinosaur();

            dinosaurs.Add(dinosaur1);
            dinosaurs.Add(dinosaur2);
            dinosaurs.Add(dinosaur3);

            foreach (Dinosaur dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur.type + " has been unleashed");
            }
        }
        //Method (can do)

    }
}
