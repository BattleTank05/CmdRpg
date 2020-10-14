using System;
using System.Collections.Generic;
using System.Text;

namespace The_Dragon_Lair_SoloRPG.Monsters
{
    class Gulfard_The_Wolfherd : Human
    {
        public Gulfard_The_Wolfherd(int level, int positionX, int positionY, string entityMapIcon) : base(positionX, positionY, entityMapIcon)
        {
            Name = "Gulfard The Wolfherd";
            base.level = level;
            MaxDodge = 1 + level;
            Health += 10 + level;
            maxHealth += 10 + level;
        }
        public void DoGulfardAmplifiers(int amplifier)
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
