using System;
using System.Collections.Generic;
using System.Text;

namespace The_Dragon_Lair_SoloRPG.Equipment
{
    public class Leather : Armor
    {
        public Leather(string itemName, int armorLevel) : base(itemName)
        {
            name = "Leather";
            armorType = "Leather";
            armorDurability = 30 + armorLevel * 10;
            armorProtectionAmount = 2 + armorLevel;
            armorSpecialAttributeAmount = 3 + armorLevel;
            gearLevel = armorLevel;
        }
    }
}
