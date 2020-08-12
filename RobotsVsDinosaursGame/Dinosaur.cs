using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace RobotsVsDinosaursGame
{
    class Dinosaur
    {
        string name;
        string health;
        int powerLevel;
        string weapon;
        int attackPower;
        int energy;
        string dinosaur1;
        string dinosaur2;
        string dinosaur3;

        public Dinosaur(string name, string health, int powerLevel, string weapon, int attackPower, int energy)
        {
            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;
            this.weapon = weapon;
            this.attackPower = attackPower;
            this.energy = energy;
        }

        //member methods 
        public void Attack(Robot robot)
        {
            robot.health = robot.health - attackPower;
        }

        
        


            
     }   
        
       
            

}





