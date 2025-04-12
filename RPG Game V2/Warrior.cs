using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game_V2
{
    internal class Warrior
    {
        private string name;
        private int health = 100;
        private int strenth;
        private int intellect;
        private int rage = 0;

        public Warrior(string name,int strenth, int intellect)
        {   
            this.name = name;
            this.strenth = strenth;
            this.intellect = intellect;
        }


        public void narmalAttack(Warrior target)
        {
            this.rage += 10;
            target.health -= this.strenth;
            Console.WriteLine($"{this.name} attacked {target.name}" +
                $"\n{this.name} inlfiged {this.strenth} demage" +
                $"\n{target.name} has {target.health} left");
        }


        public override string ToString() 
        { 
            return $"Name: {name}" +
                $"\nHealth: {health}" +
                $"\nStrength: {strenth}" +
                $"\nIntellect: {intellect}" +
                $"\nRage: {rage}";
        }

    }
}
