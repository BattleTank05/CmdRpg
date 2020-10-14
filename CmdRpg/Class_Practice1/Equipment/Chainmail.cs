using System;
using System.Collections.Generic;
using System.Text;

namespace The_Dragon_Lair_SoloRPG.Equipment
{
    class Chainmail : Armor
    {
        public Chainmail(string itemName, int armorLevel) : base(itemName)
        {
            name = "Chainmail";
            armorType = "Chainmail";
            armorDurability = 45 + armorLevel * 10;
            armorProtectionAmount = 3 + armorLevel;
            armorSpecialAttributeAmount = 2 + armorLevel;
            gearLevel = armorLevel;
        }
    }
}
