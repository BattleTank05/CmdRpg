using System;
using System.Collections.Generic;
using System.Text;

namespace The_Dragon_s_Lair_Solo_RPG_
{
    class Entity
    {
        public string Name;
        public string race;
        public int level = 0;
        public int XPToLevel = 100;
        public int XP = 0;
        public int health = 10;
        public int maxHealth = 10;
        public int parry = 0;
        public int strength = 0;
        public int dodge = 0;
        public int minDodge = 1;
        public int maxDodge = 3;
        public int intellect = 0;
        public int block = 0;
        public int entityInflictBleedingMin = -1;
        public int entityInflictBleedingMax = 3;
        public int entityBleeding = 0;
        public int entityOnFire = 0;
        public Weapon entityWeapon;
        public Armor entityArmor;

        public int EntityStatClamp(Entity entity, string whichStat, int change)
        {
            switch (whichStat)
            {
                case "Health":
                    if (entity.health + change <= 0)
                    {
                        Console.WriteLine(entity.Name + " has been defeated");
                        return 0;
                    }
                    if (entity.health + change > entity.maxHealth)
                    {
                        Console.WriteLine(entity.Name + "'s max health is: " + entity.maxHealth + ". " + entity.Name + " cannot heal past that!");
                        int userInfoElement = entity.maxHealth - entity.health;
                        Program.ColorWriter(ConsoleColor.Green, entity.Name + " heals " + userInfoElement + " health!");
                        return entity.maxHealth;
                    }
                    break;
                case "Block":
                    if (entity.block + change <= 0)
                    {
                        Program.ColorWriter(ConsoleColor.Cyan, entity.Name + " block has been destroyed!");
                        return 0;
                    }
                    else
                    {
                        Program.ColorWriter(ConsoleColor.Blue, entity.Name + " gains " + change + " Block! " + entity.Name + "'s Block: " + entity.block + change);
                        return entity.block + change;
                    }
                case "Dodge":
                    if (entity.dodge + change <= 0)
                    {
                        Program.ColorWriter(ConsoleColor.DarkGreen, entity.Name + " has run out of Dodge!");
                        return 0;
                    }
                    else
                    {
                        Program.ColorWriter(ConsoleColor.DarkGreen, entity.Name + " gains " + change + " Dodge! " + entity.Name + "'s Dodge: " + entity.dodge + change);
                        return entity.dodge + change;
                    }
                case "Parry":
                    if (entity.parry + change <= 0)
                    {
                        Program.ColorWriter(ConsoleColor.Cyan, entity.Name + " Parry has been broken!");
                        return 0;
                    }
                    else
                    {
                        Program.ColorWriter(ConsoleColor.Cyan, entity.Name + " gains " + change + " Parry! " + entity.Name + "'s Parry: " + entity.parry + change);
                        return entity.parry + change;
                    }
            }
            return 0;
        }
        public int ExperienceClamp(Entity entity, int change)
        {
            if (entity.XP + change >= entity.XPToLevel)
            {
                entity.XP -= entity.XPToLevel;
                entity.XPToLevel += 50;
                entity.level += 1;
                Program.ColorWriter(ConsoleColor.Green, entity.Name + " gains a level! " + entity.Name + " level: " + entity.level);
            }
            else if (entity.XP + change <= 0)
            {
                entity.XP = 0;
            }
            Program.ColorWriter(ConsoleColor.Green, entity.Name + " gains " + change + " experience! " + entity.Name + " experience: " + entity.XP + change + "/" + entity.XPToLevel);
            return entity.XP + change;
        }

    }
}
