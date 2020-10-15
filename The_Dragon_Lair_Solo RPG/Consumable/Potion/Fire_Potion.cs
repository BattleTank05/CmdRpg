using System;
using System.Collections.Generic;
using System.Text;

namespace The_Dragon_Lair_SoloRPG.Consumable.Potion
{
    class Fire_Potion : Potion
    {
        public Fire_Potion(string itemName, int itemLevel) : base(itemName, itemLevel)
        {
            maxFireApplication = itemLevel * 2;
            damage = itemLevel * -3;
            potionLevel = itemLevel;
        }
    }
}
