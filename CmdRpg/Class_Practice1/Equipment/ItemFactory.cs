using System;
using System.Collections.Generic;
using System.Text;
using The_Dragon_Lair_SoloRPG.Consumable;
using The_Dragon_Lair_SoloRPG.Consumable.Potion;

namespace The_Dragon_Lair_SoloRPG.Equipment
{
    class ItemFactory
    {
        public Item CreateRandomItem(int itemLevel) 
        {
            Item createdItem = null;
            int itemType = GetRandom(1, 4);
            switch (itemType) 
            {
                case 1:
                    createdItem = CreateRandomWeapon(itemLevel);
                    break;
                case 2:
                    createdItem = CreateRandomArmor(itemLevel);
                    break;
                case 3:
                    createdItem = CreateRandomConsumable(itemLevel);
                    break;
            }
            return createdItem;
        }
        public Weapon CreateRandomWeapon(int itemLevel) 
        {
            Weapon createdWeapon = new Weapon("");
            int whichWeapon = GetRandom(1, 5);
            switch (whichWeapon)
            {
                case 1:
                    Broadsword code = new Broadsword("", itemLevel);
                    createdWeapon = code;
                    break;
                case 2:
                    Mace code2 = new Mace("", itemLevel);
                    createdWeapon = code2;
                    break;
                case 3:
                    Daggers code3 = new Daggers("", itemLevel);
                    createdWeapon = code3;
                    break;
                case 4:
                    Axe code4 = new Axe("", itemLevel);
                    createdWeapon = code4;
                    break;
            }
            return createdWeapon;
        }
        public Armor CreateRandomArmor(int itemLevel)
        {
            Armor createdArmor = new Armor("");
            int whichArmor = GetRandom(1, 5);
            switch (whichArmor)
            {
                case 1:
                    Cloth code = new Cloth("", itemLevel);
                    createdArmor = code;
                    break;
                case 2:
                    Leather code2 = new Leather("", itemLevel);
                    createdArmor = code2;
                    break;
                case 3:
                    Chainmail code3 = new Chainmail("", itemLevel);
                    createdArmor = code3;
                    break;
                case 4:
                    Plate code4 = new Plate("", itemLevel);
                    createdArmor = code4;
                    break;
            }
            return createdArmor;
        }
        public Consumables CreateRandomConsumable(int itemLevel) 
        {
            Potion createdPotion = new Potion("", 1);
            int whichPotion = GetRandom(1, 3);
            switch (whichPotion) 
            {
                case 1:
                    Health_Potion newPotion = new Health_Potion("", itemLevel);
                    createdPotion = newPotion;
                    break;
                case 2:
                    Fire_Potion newPotion1 = new Fire_Potion("", itemLevel);
                    createdPotion = newPotion1;
                    break;
            }
            return createdPotion;
        }
        static int GetRandom(int min, int max) 
        {
            Random r = new Random();
            return r.Next(min, max);
        }
    }
}
