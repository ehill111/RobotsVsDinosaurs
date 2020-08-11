using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace RobotsVsDinosaursGame
{


    public class Battlefield
    {
        //Member variables
        string name;
        string health;
        int powerLevel;
        string weapon;
        string attackPower;
        string type;
        string energy;
        string robot;
        string dinosaur;

        //Constructor
        public Battlefield(string name, string health, int powerLevel, string weapon, string attackPower, string energy)
        {
            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;
            this.weapon = weapon;
            this.attackPower = attackPower;
            this.energy = energy;
            Battlefield robot = new Battlefield(name, health, powerLevel, weapon, attackPower);
            Battlefield dinosaur = new Battlefield(name, health, powerLevel, weapon, attackPower);
        }

        


    }



}















