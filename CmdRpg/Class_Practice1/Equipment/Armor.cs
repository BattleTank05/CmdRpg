using System;
using System.Collections.Generic;
using System.Text;

namespace The_Dragon_Lair_SoloRPG.Equipment
{
    public class Armor : Item
    {
        public int armorDurability = 0;
        public int armorProtectionAmount = 0;
        public int armorSpecialAttributeAmount = 0;
        public int gearLevel = 0;
        public string armorType = "";

        public Armor(string itemName) : base (itemName)
        {
            itemType = "Armor";
        }
    }
}
