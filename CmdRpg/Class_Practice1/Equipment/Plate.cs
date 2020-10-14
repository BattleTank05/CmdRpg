
using System;
using System.Collections.Generic;
using System.Text;

namespace The_Dragon_Lair_SoloRPG.Equipment
{
    public class Plate : Armor
    {
        public Plate(string itemName, int armorLevel) : base (itemName)
        {
            name = "Plate";
            armorType = "Plate";
            armorDurability = 60 + armorLevel * 10;
            armorProtectionAmount = 5 + armorLevel;
            armorSpecialAttributeAmount = 1 + armorLevel;
            gearLevel = armorLevel;
        }
    }
}
