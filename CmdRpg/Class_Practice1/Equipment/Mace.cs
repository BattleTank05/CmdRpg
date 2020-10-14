using System;
using System.Collections.Generic;
using System.Text;

namespace The_Dragon_Lair_SoloRPG.Equipment
{
    public class Mace : Weapon
    {
        public Mace(string itemName, int weaponLevel) : base (itemName)
        {
            name = "Mace";
            weaponType = "Mace";
            weaponDamage = 6 + weaponLevel;
            maxWeaponDamage = 6 + weaponLevel;
            weaponDurability = 55 + weaponLevel * 10;
            weaponAttributePiercing = 1 + weaponLevel;
            weaponAttackAmount = 1 + weaponLevel / 3;
            weaponCriticalStrike = 10 + weaponLevel * 5;
            weaponParry = 3 + weaponLevel;
            weaponlevel = weaponLevel;
        }
    }
}
