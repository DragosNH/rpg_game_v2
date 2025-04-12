using System.Security.Cryptography.X509Certificates;

namespace RPG_Game_V2.Classes
{
    internal class CharClass
    {
        private int rage = 0;
        private int mana = 100;
        private int energy = 50;
        private ClassType ClassType;

        public CharClass(int rage, int mana)
        {
            switch(ClassType)
            {
                case ClassType.Warrior:
                    this.rage = rage;
                    break;
                case ClassType.Mage:
                    this.mana = mana;
                    break;
                case ClassType.Thief:
                    this.energy = energy; 
                    break;
            }
        }

        public override string ToString() 
        {
            return $"{ClassType}";
        }

    }
}
