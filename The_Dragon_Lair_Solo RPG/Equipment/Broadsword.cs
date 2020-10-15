using System;
using System.Collections.Generic;
using System.Text;

namespace The_Dragon_Lair_SoloRPG.Equipment
{
    public class Broadsword : Weapon
    {
        public Broadsword(string itemName, int weaponLevel) : base(itemName)
        {
            name = "Broadsword";
            weaponType = "Broadsword";
            weaponDamage = 5 + weaponLevel;
            maxWeaponDamage = 5 + weaponLevel;
            weaponDurability = 50 + weaponLevel * 10;
            weaponAttributePiercing = 1 + weaponLevel;
            weaponAttackAmount = 1 + weaponLevel / 3;
            weaponCriticalStrike = 10 + weaponLevel * 5;
            weaponParry = 4 + weaponLevel;
            weaponlevel = weaponLevel;
        }
    }
}
