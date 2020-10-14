using System;
using System.Collections.Generic;
using System.Text;

namespace The_Dragon_Lair_SoloRPG.Monsters
{
    class Berk_The_Jerk : Human
    {
        public Berk_The_Jerk(int level, int positionX, int positionY, string entityMapIcon) : base(positionX, positionY, entityMapIcon)
        {
            Name = "Berk The Jerk";
            base.level = level;
            MaxDodge = 1 + level;
            Health += 10 + level;
            maxHealth += 10 + level;
        }
        public void DoBerkAmplifiers(int amplifier) 
        {
            EntityWeapon.weaponParry += amplifier;
            EntityArmor.armorProtectionAmount += amplifier;
            EntityWeapon.weaponDamage += amplifier;
            Strength = 0 + amplifier;
            Intellect = 0 + amplifier;
            EntityWeapon.weaponAttackAmount += amplifier / 3;
        }
    }
}
