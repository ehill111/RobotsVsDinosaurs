using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosaursGame
{
    class Fleet
    {
        public List<Robot> theRobots;


        public Fleet()
        {
            theRobots = new List<Robot>();
            CreateRobots();
        }
        public void CreateRobots()
        {
            
            Robot robot1 = new Robot("Magnum", "Outstanding", 100, "Axe", 100);
            Robot robot2 = new Robot("Valiant", "Outstanding", 100, "Club", 100);
            Robot robot3 = new Robot("Formidable", "Outstanding", 100, "Sword", 100);
            theRobots.Add(robot1);
            theRobots.Add(robot2);
            theRobots.Add(robot3);

        }
    }
}
