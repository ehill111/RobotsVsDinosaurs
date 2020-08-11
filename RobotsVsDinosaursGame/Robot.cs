using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosaursGame
{
    class Robot
    {
        string name;
        string health;
        int powerLevel;
        string weapon;
        string attackPower;
        string robot1;
        string robot2;
        string robot3;



        //Constructor

        public Robot(string name, string health, string powerLevel, string weapon)
        {
            this.name = name;
            this.health = health;
            this.powerLevel = int.Parse(powerLevel);
            this.weapon = weapon;
            this.attackPower = attackPower;
        }
        public void Attack()
        {

        }
    }
}
