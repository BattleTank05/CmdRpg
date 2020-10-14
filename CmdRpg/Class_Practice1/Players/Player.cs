using The_Dragon_Lair_SoloRPG.Equipment;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.Transactions;

namespace The_Dragon_Lair_SoloRPG
{
    public class Player : Entity
    {
        public string classType;
        public Weapon PlayerWeapon2;
        
        public Player(string playerName, int positionX, int positionY, string entityMapIcon) : base(positionX, positionY, entityMapIcon)
        {
            Name = playerName;
            Fists newPlayerWeapon = new Fists("Fists");
            EntityWeapon = newPlayerWeapon;
            PlayerWeapon2 = newPlayerWeapon;
        }
        public int PlayerAttack(Monster monster, Player player1, Weapon playerWeapon)
        {
            Render code = new Render();
            Program code3 = new Program();
            int AttackAmount1 = 0;
            int PlayerDamage2 = 0;
            int PlayerDamage1;
            int PlayerDamage = 0;
            int attackNumber = 1;
            while (playerWeapon.weaponAttackAmount > 0)
            {
                PlayerDamage1 = GetRandom(playerWeapon.weaponDamage - 4, playerWeapon.weaponDamage);
                if (monster.Dodge > 0)
                {
                    if (PlayerDamage1 / monster.Dodge <= monster.Dodge)
                    {
                        Program.ColorWriter(ConsoleColor.Magenta, monster.Name + " successfully Dodges your desperate attack\n" + monster.Name + " loses 1 dodge! " + monster.Name + " Dodge: " + monster.Dodge);
                        monster.Dodge -= 1;
                        playerWeapon.weaponDurability -= 1;
                        Program.ColorWriter(ConsoleColor.Red, player1.Name + " does 0 damage and loses 1 weapon durability point! " + player1.Name + " Weapon durability: " + playerWeapon.weaponDurability);
                        PlayerDamage1 = 0;
                    }
                }
                if (PlayerDamage1 <= monster.Parry && monster.Parry > 0 && PlayerDamage1 > 0)
                {
                    Program.ColorWriter(ConsoleColor.DarkCyan, monster.Name + " successfully Parries your futile blow! You deal 0 damage!");
                    int monsterParryReduction = GetRandom(0, PlayerDamage1);
                    Program.ColorWriter(ConsoleColor.Red, monster.Name + " loses " + monsterParryReduction + "\n" + player1.Name + " loses 5 weapon durability points! " + player1.Name + " weapon durability: " + playerWeapon.weaponDurability);
                    monster.Parry -= monsterParryReduction;
                    PlayerDamage1 = 0;
                    playerWeapon.weaponDurability -= 5;
                }
                monster.Parry = 0;
                Program.ColorWriter(ConsoleColor.Cyan, "Your brutal blow has broken " + monster.Name + "'s parry! It is now 0!");
                if (monster.EntityWeapon != null)
                {
                    monster.EntityWeapon.weaponDurability -= 5;
                    Program.ColorWriter(ConsoleColor.Red, monster.Name + " loses 5 weapon durability! " + monster.Name + "weapon durability: " + monster.EntityWeapon.weaponDurability);
                }
                Console.WriteLine(player1.Name + " attack damage " + attackNumber + ": " + PlayerDamage1);
                if (monster.Block <= 0 && PlayerDamage1 > 0)
                {
                    int CriticalChance = GetRandom(0, 100);
                    if (CriticalChance <= playerWeapon.weaponCriticalStrike)
                    {
                        PlayerDamage1 += playerWeapon.weaponCriticalStrike / 10;
                        Program.ColorWriter(ConsoleColor.DarkMagenta, "You got a Critical Strike!");
                        Program.ColorWriter(ConsoleColor.DarkMagenta, "+" + playerWeapon.weaponCriticalStrike / 10 + " Damage!\n");
                        player1.entityInflictBleedingMin += 1;
                        player1.entityInflictBleedingMax += 1;
                    }
                }
                PlayerDamage2 += PlayerDamage1;
                playerWeapon.weaponAttackAmount -= 1;
                AttackAmount1 += 1;
                attackNumber += 1;
            }
            attackNumber = 0;
            Console.WriteLine(monster.Name + " Block: " + monster.Block);
            if (PlayerDamage2 > 0) 
            {
                PlayerDamage = PlayerDamage2 + player1.Strength;
                Console.WriteLine(player1.Name + " total damage: " + PlayerDamage);
                if (monster.Block > 0) 
                {
                    monster.Block -= player1.EntityWeapon.weaponAttributePiercing;
                    Program.ColorWriter(ConsoleColor.DarkYellow, player1.Name + " pierces through " + player1.EntityWeapon.weaponAttributePiercing + " of " + monster.Name + " Block! " + monster.Name + " Block: " + monster.Block);
                    if (monster.Block < 0) 
                    {
                        monster.Block = 0;
                    }
                    PlayerDamage -= monster.Block;
                    Program.ColorWriter(ConsoleColor.Red, player1.Name + " loses " + monster.Block + " damage! " + player1.Name + " damage: " + PlayerDamage);
                    monster.Block = 0;
                }
                if (PlayerDamage <= monster.Block)
                {
                    playerWeapon.weaponDurability -= 3;
                    Program.ColorWriter(ConsoleColor.Red, player1.Name + " loses 3 weapon durability!\n" + player1.Name + " weapon durability: " + playerWeapon.weaponDurability);
                    monster.Block -= PlayerDamage;
                    Program.ColorWriter(ConsoleColor.Red, player1.Name + " deals 0 damage! " + monster.Name + " loses " + PlayerDamage + " Block! " + monster.Name + " Block: " + monster.Block);
                }
                if (PlayerDamage <= monster.EntityArmor.armorProtectionAmount)
                {
                    monster.EntityArmor.armorDurability -= PlayerDamage;
                    Console.WriteLine(monster.Name + "'s gear can block " + monster.EntityArmor.armorProtectionAmount + "! " + player1.Name + " deals 0 damage! " + monster.Name + " loses " + PlayerDamage + " armor durability points! " + monster.Name + " Armor durability: " + monster.EntityArmor.armorDurability);
                    PlayerDamage = 0;
                }
                monster.EntityArmor.armorDurability -= PlayerDamage;
                Program.ColorWriter(ConsoleColor.Red, monster.Name + " loses " + PlayerDamage + " armor durability points! " + monster.Name + "'s armor durability: " + monster.EntityArmor.armorDurability);
                PlayerDamage -= monster.EntityArmor.armorProtectionAmount;
                Program.ColorWriter(ConsoleColor.Red, player1.Name + " loses " + monster.EntityArmor.armorProtectionAmount + " damage! " + player1.Name + " total damage: " + PlayerDamage);
                monster.EntityArmor.armorProtectionAmount -= 1;
                Program.ColorWriter(ConsoleColor.Red, monster.Name + " loses 1 armor protection point!");
            }
            if (monster.Block == 0 && PlayerDamage2 > 0)
            {
                int monsterBleedingAddition = GetRandom(player1.entityInflictBleedingMin, player1.entityInflictBleedingMax);
                Program.ColorWriter(ConsoleColor.Red, player1.Name + " inflicts " + monsterBleedingAddition + " bleeding to " + monster.Name);
            }
            Program.ColorWriter(ConsoleColor.Red, player1.Name + " deals " + PlayerDamage + " damage to " + monster.Name + "!");
            monster.Health -= PlayerDamage;
            if (monster.EntityArmor.armorDurability <= 0)
            {
                Program.ColorWriter(ConsoleColor.Yellow, monster.Name + " armor has broken!");
                monster.EntityArmor.armorProtectionAmount = 0;
            }
            Console.WriteLine(monster.Name + " Health: " + monster.Health);
            playerWeapon.weaponAttackAmount = AttackAmount1;
            player1.entityInflictBleedingMin = -1;
            player1.entityInflictBleedingMax = 3;
            playerWeapon.weaponDurability -= 1;
            Program.ColorWriter(ConsoleColor.Red, "From the vigorousness of the attack, " + player1.Name + " loses 1 weapon durability point! " + player1.Name + " weapon durability: " + player1.EntityWeapon.weaponDurability);
            if (monster.Health <= 0) 
            {
                Program.ColorWriter(ConsoleColor.Green, player1.Name + " has defeated " + monster.Name + "!");
                ExperienceClamp(player1, 50 + monster.level * 10);
                monster = null;
                return 0;
            }
            return monster.Health;
        }
        public int Player_Defend(Player player1)
        {
            int playerBlock = GetRandom(player1.EntityArmor.armorProtectionAmount - 4, player1.EntityArmor.armorProtectionAmount);
            return player1.EntityStatClamp(player1, "Block", playerBlock);
        }
        public int Player_Parry(Player player1, Weapon playerWeapon)
        {
            int playerParry = GetRandom(playerWeapon.weaponParry - 4, playerWeapon.weaponParry);
            return player1.EntityStatClamp(player1, "Parry", playerParry);
        }
        public int Player_Heal(Player player1)
        {
            int heal = GetRandom(1, 10);
            return player1.EntityStatClamp(player1, "Health", heal);
        }
        public int Player_Dodge(Player player1)
        {
            int playerDodge = GetRandom(player1.MinDodge, player1.MaxDodge);
            return player1.EntityStatClamp(player1, "Dodge", playerDodge);
        }
        static int GetRandom(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max);
        }
    }
}
