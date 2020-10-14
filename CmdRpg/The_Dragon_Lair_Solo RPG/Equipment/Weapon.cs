using System;
using System.Collections.Generic;
using System.Text;

namespace The_Dragon_Lair_SoloRPG.Equipment
{
    public class Weapon : Item
    {
        public int weaponDamage = 0;
        public int maxWeaponDamage = 0;
        public int weaponDurability = 0;
        public int weaponAttributePiercing = 0;
        public int weaponAttackAmount = 0;
        public int weaponCriticalStrike = 0;
        public int weaponParry = 0;
        public int weaponlevel = 0;
        public string weaponType = "";

        public Weapon(string itemName) : base(itemName)
        {
            itemType = "Weapon";
        }
    }
}
