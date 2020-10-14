using System;
using System.Collections.Generic;
using System.Text;

namespace The_Dragon_Lair_SoloRPG.Equipment
{
    public class Cloth : Armor
    {
        public Cloth(string itemName, int armorLevel) : base (itemName)
        {
            name = "Cloth";
            armorType = "Cloth";
            armorDurability = 20 + armorLevel * 10;
            armorProtectionAmount = 2 + armorLevel;
            armorSpecialAttributeAmount = 4 + armorLevel;
            gearLevel = armorLevel;
        }
    }
}
