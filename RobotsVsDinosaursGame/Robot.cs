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
               
    }

    //Constructor

    public Robot(string name, string health, string powerLevel, string weapon)
    {
        this.name = name;
        this.health = health;
        this.powerLevel = powerLevel;
        this.weapon = weapon;
        this.attackPower = attackPower;
    }
}
