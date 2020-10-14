using System;
using System.Collections.Generic;
using System.Text;

namespace The_Dragon_Lair_SoloRPG.Equipment
{
    public class Item
    {
        public int itemCount = 0;
        public string itemDescription = "";
        public string name;
        public string itemType = "";

        public Item(string itemName)
        {
        name = itemName; 
        }
        //Orange for Weapon
        //Yellow for Armor
        //Purple for Potion
    }
}
