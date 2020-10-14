using System;
using System.Collections.Generic;
using System.Text;

namespace The_Dragon_Lair_SoloRPG.Consumable.Potion
{
    class Health_Potion : Potion
    {
        public Health_Potion(string itemName, int itemLevel) : base(itemName, itemLevel)
        {
            damage = itemLevel * 5;
            maxFireApplication = 0;
            potionLevel = itemLevel;
        }
    }
}
