using System;
using System.Collections.Generic;
using System.Text;

namespace The_Dragon_Lair_SoloRPG.Equipment
{
    public class Daggers : Weapon
    {
        public Daggers(string itemName, int weaponLevel) : base (itemName)
        {
            name = "Daggers";
            weaponType = "Daggers";
            weaponDamage = 3 + weaponLevel;
            maxWeaponDamage = 3 + weaponLevel;
            weaponDurability = 30 + weaponLevel * 10;
            weaponAttributePiercing = 2 + weaponLevel;
            weaponAttackAmount = 2 + weaponLevel / 3;
            weaponCriticalStrike = 15 + weaponLevel * 5;
            weaponParry = 3 + weaponLevel;
            weaponlevel = weaponLevel;
        }
    }
}
