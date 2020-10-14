using The_Dragon_Lair_SoloRPG.Equipment;
using System;
using System.Collections.Generic;
using System.Text;

namespace The_Dragon_Lair_SoloRPG.Monsters
{
    public class Grauldog : Troll
    {
        public Grauldog(int level, int positionX, int positionY, string entityMapIcon) : base(positionX, positionY, entityMapIcon)
        {
            Name = "Grauldog, champion of the Trolls";
            base.level = level * 2;
        }
        public void DoGrauldogAmplifiers(int amplifier)
        {
            Health += 30 + level * 5;
            maxHealth += 30 + level * 5;
            EntityWeapon.weaponParry += amplifier;
            EntityArmor.gearLevel += amplifier;
            EntityWeapon.weaponlevel += amplifier;
            Strength = 0 + amplifier * 2;
            Intellect = 0 + amplifier * 2;
            EntityWeapon.weaponAttackAmount = 1 + amplifier / 2;
        }
    }
}
