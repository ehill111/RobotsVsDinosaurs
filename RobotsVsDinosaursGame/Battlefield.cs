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

        //Method Skeleton
        /*Magnum uses axe
         * - swings axe
         * - attack
         * - retreat
         * - lose health
         * - lose power
         
         Valiant uses club
          - swings club
          - attack
          - retreat
          - lose health
          - lose power

        Formidable uses sword
         - swings sword
         - attack
         - retreat
         - lose health
         - lose power

        Glockosaurus uses tail to whip bullets
         - whips bullets
         - attack
         - retreat
         - lose health
         - lose power
         - lose energy

        Bitabuttsaurus uses mouth to bite
         - snaps mouth
         - attack
         - retreat
         - lose health
         - lose power
         - lose energy

        Salivasaurus spits poison
         - spits
         - attack
         - retreat
         - lose health
         - lose power
         - lose energy*/


    }



}















