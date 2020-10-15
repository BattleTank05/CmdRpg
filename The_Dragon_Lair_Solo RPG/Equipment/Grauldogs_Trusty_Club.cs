using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace The_Dragon_Lair_SoloRPG.Equipment
{
    public class Grauldogs_Trusty_Club : Weapon
    {
        public Grauldogs_Trusty_Club(string itemName, int ItemLevel) : base (itemName)
        {
            name = "Grauldog's Trusty Club";
            weaponType = "Club";
            weaponDamage = 8 + ItemLevel;
            maxWeaponDamage = 12 + ItemLevel;
            weaponDurability = 150 + ItemLevel * 10;
            weaponAttributePiercing = 0 + ItemLevel / 2;
            weaponAttackAmount = 2 + ItemLevel / 5;
            weaponCriticalStrike = 15 + ItemLevel / 2;
            weaponParry = 6 + ItemLevel * 2;
            weaponlevel = ItemLevel;
        }
    }
}
