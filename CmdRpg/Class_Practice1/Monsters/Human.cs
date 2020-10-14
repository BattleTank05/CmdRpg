using System;
using System.Collections.Generic;
using System.Text;

namespace The_Dragon_Lair_SoloRPG.Monsters
{
    public class Human : Monster
    {
        public int MaxLevel = 10;
        public int MinLevel = 1;
        public Human(int positionX, int positionY, string entityMapIcon) : base(positionX, positionY, entityMapIcon)
        {
            race = "Human";
        }
    }
}
