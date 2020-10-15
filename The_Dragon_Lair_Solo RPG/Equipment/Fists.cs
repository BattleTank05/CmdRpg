using System;
using System.Collections.Generic;
using System.Text;

namespace The_Dragon_Lair_SoloRPG.Equipment
{
    public class Fists : Weapon
    {
        public Fists(string itemName) : base (itemName)
        {
            name = "Fists";
            weaponType = "Fists";
            weaponDamage = 100;
            maxWeaponDamage = 3;
            weaponDurability = 1000;
            weaponAttributePiercing = 0;
            weaponAttackAmount = 3;
            weaponCriticalStrike = 15;
            weaponParry = 2;
            weaponlevel = 1;
        }
    }
}
