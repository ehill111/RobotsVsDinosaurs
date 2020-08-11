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
            
            Robot robot1 = new Robot("Bob", "100", "25", "Blaster");
            Robot robot2 = new Robot("Frank", "100", "25", "Axe");
            Robot robot3 = new Robot("Steve", "100", "25", "Sword");
            theRobots.Add(robot1);
            theRobots.Add(robot2);
            theRobots.Add(robot3);

        }
    }
}
