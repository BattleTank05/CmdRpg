using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace The_Dragon_Lair_SoloRPG.Monsters
{
    public class Troll : Monster
    {
        public int MaxLevel = 5;
        public int MinLevel = 1;
        public Troll(int positionX, int positionY, string entityMapIcon) : base(positionX, positionY, entityMapIcon)
        {
            race = "Troll";
        }
    }
}
