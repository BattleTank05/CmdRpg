using System;
using System.Collections.Generic;
using System.Text;

namespace The_Dragon_Lair_SoloRPG.Equipment
{
    public class Axe : Weapon
    {
        public Axe(string itemName, int weaponLevel) : base (itemName)
        {
            name = "Axe";
            weaponType = "Axe";
            weaponDamage = 7 + weaponLevel;
            maxWeaponDamage = 7 + weaponLevel;
            weaponDurability = 60 + weaponLevel * 10;
            weaponAttributePiercing = 1 + weaponLevel;
            weaponAttackAmount = 1 + weaponLevel / 5;
            weaponCriticalStrike = 5 + weaponLevel * 5;
            weaponParry = 5 + weaponLevel;
            weaponlevel = weaponLevel;
        }
    }
}
