using RPG_Game_V2.Classes;
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
        private CharClass CharClass;
        private int strenth;
        private int intellect;

        public Character(string name,CharClass charClass ,int strenth, int intellect)
        {   
            this.name = name;
            this.CharClass = charClass;
            this.strenth = strenth;
            this.intellect = intellect;
        }


        public override string ToString() 
        { 
            return $"Name: {name}" +
                $"\nClass: {CharClass}" +
                $"\nStrength: {strenth}" +
                $"\nIntellect: {intellect}";
        }

    }
}
