using System;
using System.Collections.Generic;
using System.Text;

namespace The_Dragon_Lair_SoloRPG.Monsters
{
    public class Barg_The_Ugly_Brute : Troll
    {
        public Barg_The_Ugly_Brute(int level, int positionX, int positionY, string entityMapIcon) : base(positionX, positionY, entityMapIcon)
        {
            Name = "Barg The Ugly Brute";
            base.level = level;
            Health += 20 + level;
            maxHealth += 20 + level;
        }
        public void DoBargAmplifiers(int amplifier) 
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
