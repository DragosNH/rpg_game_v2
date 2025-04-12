using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game_V2
{
    internal class Character
    {
        private string name;
        private int strenth;
        private int intellect;

        public Character(string name, int strenth, int intellect)
        {   
            this.name = name;
            this.strenth = strenth;
            this.intellect = intellect;
        }


        public override string ToString() 
        { 
            return $"Name: {name}" +
                $"\nStrength: {strenth}" +
                $"\nIntellect: {intellect}";
        }

    }
}
