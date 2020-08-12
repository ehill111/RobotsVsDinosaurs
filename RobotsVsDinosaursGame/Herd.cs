using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace RobotsVsDinosaursGame
{
    class Herd
    {
        public List<Dinosaur> theDinosaurs;
        
        public Herd()
        {
            theDinosaurs = new List<Dinosaur>();
            Dinosaur dinosaur1 = new Dinosaur("Glockosaurus", "Outstanding", 100, "Tailgun", 100, 100);
            Dinosaur dinosaur2 = new Dinosaur("Bitabuttsaurus", "Outstanding", 100, "Bites", 100, 100);
            Dinosaur dinosaur3 = new Dinosaur("Salivasaurus", "Outstanding", 100, "Spits", 100, 100);
            theDinosaurs.Add(dinosaur1);
            theDinosaurs.Add(dinosaur2);
            theDinosaurs.Add(dinosaur3);
        }








    }
}
