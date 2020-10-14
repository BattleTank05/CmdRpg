using System;
using System.Collections.Generic;
using System.Text;

namespace The_Dragon_Lair_SoloRPG.Monsters
{
    public class Klerg_The_Iceberg : Troll
    {
        public Klerg_The_Iceberg(int level, int positionX, int positionY, string entityMapIcon) : base(positionX, positionY, entityMapIcon)
        {
            Name = "Klerg The Iceberg";
            base.level = level;
            Health += 20 + level;
            maxHealth += 20 + level;
        }
        public void DoKlergAmplifiers(int amplifier)
        {
            EntityWeapon.weaponParry += amplifier;
            MaxDodge = 1 + amplifier;
            EntityWeapon.weaponDamage += amplifier;
            Strength = 0 + amplifier;
            Intellect = 0 + amplifier;
            EntityWeapon.weaponAttackAmount += amplifier / 3;
            EntityArmor.armorProtectionAmount += amplifier;
        }
    }
}
