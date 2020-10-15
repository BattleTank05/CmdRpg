using System;
using System.Collections.Generic;
using System.Text;

namespace The_Dragon_Lair_SoloRPG.Equipment
{
    public class Hides : Armor
    {
        public Hides(string itemName) : base (itemName)
        {
            name = "Hides";
            armorType = "Hides";
            armorDurability = 1000;
            armorProtectionAmount = 1;
            armorSpecialAttributeAmount = 0;
            gearLevel = 1;
        }
    }
}
