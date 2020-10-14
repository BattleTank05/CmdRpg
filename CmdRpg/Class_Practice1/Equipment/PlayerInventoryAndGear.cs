using System;
using System.Collections.Generic;
using System.Text;

namespace The_Dragon_Lair_SoloRPG.Equipment
{
    class PlayerInventoryAndGear
    {
        public int inventorySlot = 0;
        public int maxInventorySlots = 5;
        public string[] playerInventory = { "", "", "", "", "" };

        public string TakingItem(string takingItem)
        {
            for (int i = inventorySlot; i < playerInventory.Length;) 
            {
                if (i < maxInventorySlots) 
                {
                    takingItem = playerInventory[i];
                }
            }
            return takingItem;
        }
        public void AddingItem(string addedItem, int inventorySlot)
        {
            for (int i = inventorySlot; i < playerInventory.Length;)
            {
                while (playerInventory[i] != "") 
                {
                    i++;
                    if (playerInventory[i] == "" && i < maxInventorySlots)
                    {
                        playerInventory[i] = addedItem;
                    }
                    if (i > maxInventorySlots) 
                    {
                        Console.WriteLine("Inventory Full!");
                        return;
                    }
                }
            }
        }
    }
}
