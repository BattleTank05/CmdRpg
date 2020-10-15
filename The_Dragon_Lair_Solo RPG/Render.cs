using System;
using System.Collections.Generic;
using System.Text;

namespace The_Dragon_Lair_SoloRPG
{
    class Render
    {
        public void GainOrLoseStatsRenderer(Entity entity, Entity entity2, string operater, int amount, string stat) 
        {
            if (operater == "attack") 
            {
            Console.WriteLine(entity.Name + " deals " + amount + " " + stat + " to " + entity2.Name);
            }
            if (operater == "GainStat")
            {
                Console.WriteLine(entity.Name + " gains " + amount + " " + stat);
            }
            if (operater == "SelfDamage") 
            {
                Console.WriteLine(entity.Name + " takes " + amount + stat + "\n" + entity.Name + " Health: " + entity.Health);
            }
        }
        public void RenderPlayerStats(Player player1)
        {
            string[] playerStats = { player1.Name + "'s stats: ", "Your Health: " + player1.Health, "Your Armor: " + player1.Block, "Your Parry: " + player1.EntityWeapon.weaponParry, "Gear Armor: " + player1.EntityArmor.armorProtectionAmount, "Your Strength: " + player1.Strength, "Your Dodge: " + player1.Dodge, "Your Intellect: " + player1.Intellect, "Amount of times you can attack: " + player1.EntityWeapon.weaponAttackAmount, "Weapon damage: " + player1.EntityWeapon.weaponDamage, "Your XP: " + player1.XP + "/" + player1.XPToLevel, "Your Level: " + player1.level + "\n" };
            for (int i = 0; i < playerStats.Length; i++)
            {
                Console.WriteLine(playerStats[i]);
            }
        }
        public void RenderPlayerFightStats(Player player1)
        {
            string[] playerFightStats = { "\nYour Health: " + player1.Health, "Your Class: " + player1.classType, "Your Block: " + player1.Block, "Your Dodge: " + player1.Dodge, "Your Strength: " + player1.Strength, "Your Gear Armor: " + player1.EntityArmor.armorProtectionAmount, "Your Critical Strike: " + player1.EntityWeapon.weaponCriticalStrike, "Your Parry :" + player1.EntityWeapon.weaponParry, "Your current bleed: " + player1.entityBleeding, "What would you like to do?\n", "1) Attack = " + player1.EntityWeapon.weaponDamage + " Damage x" + player1.EntityWeapon.weaponAttackAmount + " + Strength (" + player1.Strength + ")", "2) Defend = " + player1.EntityArmor.armorProtectionAmount + " Block x1", "3) Parry = " + player1.EntityWeapon.weaponParry + " Parry x1", "4) Heal = 1-10 Heal x1", "5) Dodge = " + player1.MinDodge + "-" + player1.MaxDodge + " Dodge x1", "'Stats'" };
            for (int i = 0; i < playerFightStats.Length; i++)
            {
                Console.WriteLine(playerFightStats[i]);
            }
        }
        public void RenderMonsterStats(Monster monster)
        {
            string[] monsterStats = { "your foe, " + monster.Name + "!", monster.Name + "'s level: " + monster.level, "Opposer's race: " + monster.race, monster.Name + " Health: " + monster.Health, monster.Name + " Armor: " + monster.EntityArmor.armorProtectionAmount, monster.Name + " Parry: " + monster.EntityWeapon.weaponParry, monster.Name + " Strength: " + monster.Strength, monster.Name + " Dodge: " + monster.Dodge, monster.Name + " Intellect: " + monster.Intellect, "Amount of times " + monster.Name + " can attack: " + monster.EntityWeapon.weaponAttackAmount, monster.Name + " Damage: " + monster.EntityWeapon.weaponDamage, monster.Name + " weapon: " + monster.EntityWeapon.name, monster.Name + " weapon level: " + monster.EntityWeapon.weaponlevel, monster.Name + " Gear: " + monster.EntityArmor.name, monster.Name + " Gear level: " + monster.EntityArmor.gearLevel + "\n" };
            for (int i = 0; i < monsterStats.Length; i++)
            {
                 Console.WriteLine(value: monsterStats[i]);
            }
        }
        public void RenderPlayerActionsShorthand(Player player1) 
        {
            string[] playerShorthandActions = { "Your Health: " + player1.Health, "What would you like to do?\n", "1) Attack = " + player1.EntityWeapon.weaponDamage + " Damage x" + player1.EntityWeapon.weaponAttackAmount + " + Strength (" + player1.Strength + ")", "2) Defend = " + player1.EntityArmor.armorProtectionAmount + " Block x1", "3) Parry = " + player1.EntityWeapon.weaponParry + " Parry x1", "4) Heal = 1-10 Heal x1", "5) Dodge = " + player1.MinDodge + "-" + player1.MaxDodge + " Dodge x1", "6) Move = 1 space", "'Stats'" };
            for (int i = 0; i < playerShorthandActions.Length; i++)
            {
                Console.WriteLine(value: playerShorthandActions[i]);
            }
        }
        public void RenderPlayerChoosing(int whichChoosing) 
        {
            string[] playerChooseClass = { "Choose a Class: ", "1) Warrior", "2) Mage", "3) Rogue" };
            string[] playerChooseWeapons = { "Choose a Weapon: ", "1) Broadsword", "2) Mace", "3) Twin Daggers", "4) War Axe", "5) Random" };
            string[] playerChooseArmors = { "Choose your Armor: ", "1) Chainmail", "2) Thick leather", "3) Sleek Silken Thinking Cloth", "4) Plate Armor", "5) Random" };
            string[] playerChoosingPotions = { "Choose a Potion: ", "1) Health Potion", "2) Fire Potion" };
            switch (whichChoosing) 
            {
                case 1:
                    for (int i = 0; i < playerChooseClass.Length; i++)
                    {
                        Console.WriteLine(value: playerChooseClass[i]);
                    }
                    break;
                case 2:
                    for (int i = 0; i < playerChooseWeapons.Length; i++)
                    {
                        Program.ColorWriter(ConsoleColor.Yellow, playerChooseWeapons[i]);
                    }
                    break;
                case 3:
                    for (int i = 0; i < playerChooseArmors.Length; i++)
                    {
                        Program.ColorWriter(ConsoleColor.Yellow, playerChooseArmors[i]);
                    }
                    break;
                case 4:
                    for (int i = 0; i < playerChoosingPotions.Length; i++)
                    {
                        Program.ColorWriter(ConsoleColor.Yellow, playerChoosingPotions[i]);
                    }
                    break;
            }
        }
        public void RenderPlayerGearStats(Player player1) 
        {
            string[] GearStats = { "Weapon Type: " + player1.EntityWeapon.weaponType, "Weapon Damage: " + player1.EntityWeapon.weaponDamage, "Weapon Durability: " + player1.EntityWeapon.weaponDurability, "Weapon Parry: " + player1.EntityWeapon.weaponParry, "Weapon Piercing: " + player1.EntityWeapon.weaponAttributePiercing, "Weapon Critical Chance: " + player1.EntityWeapon.weaponCriticalStrike, "Weapon AttackAmount: " + player1.EntityWeapon.weaponAttackAmount, "Weapon Level: " + player1.EntityWeapon.weaponlevel, "Gear Type: " + player1.EntityArmor.armorType, "Gear Defense: " + player1.EntityArmor.armorProtectionAmount, "Gear Durability: " + player1.EntityArmor.armorDurability, "Gear Level: " + player1.EntityArmor.gearLevel };
            for (int i = 0; i < GearStats.Length; i++)
            {
                Program.ColorWriter(ConsoleColor.Yellow, GearStats[i]);
            }
        }
        //public void RenderPlayerInventory(string[] playerInventory) 
        //{
        //    for (int i = 0; i < playerInventory.Length; i++) 
        //    {
        //        Console.WriteLine(playerInventory[i]);
        //    }
        //}
    }
}
