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
        int attackPower;
        string robot1 = "Magnum";
        string robot2 = "Valiant";
        string robot3 = "Formidable";
        
        //Constructor

        public Robot(string name, string health, int powerLevel, string weapon, int attackPower)
        {
            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;
            this.weapon = weapon;
            this.attackPower = attackPower;
            
        }
               
        public void Attack(Dinosaur dino)
        {
            dino.health -= weapon.attackPower;
            //using dot notation to drill down to get what I want..
        }
    }
}
