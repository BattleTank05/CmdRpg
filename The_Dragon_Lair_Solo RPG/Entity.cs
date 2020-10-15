using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using The_Dragon_Lair_SoloRPG.Equipment;
using The_Dragon_Lair_SoloRPG.Consumable.Potion;
using The_Dragon_Lair_SoloRPG.Maps;
using System.Linq;
using System.Dynamic;

namespace The_Dragon_Lair_SoloRPG
{
    public class Entity
    {
        public string Name;
        public string race;
        public int level = 0;
        public int XPToLevel = 100;
        public int XP = 0;
        public int Health = 10;
        public int maxHealth = 10;
        public int Parry = 0;
        public int Strength = 0;
        public int Dodge = 0;
        public int MinDodge = 1;
        public int MaxDodge = 3;
        public int Intellect = 0;
        public int Block = 0;
        public int entityInflictBleedingMin = -1;
        public int entityInflictBleedingMax = 3;
        public int entityBleeding = 0;
        public int entityOnFire = 0;
        public int posX;
        public int posY;
        public string mapIcon;
        public Weapon EntityWeapon;
        public Armor EntityArmor;
        public List<Potion> entityPotions = new List<Potion>();

        public Entity(int positionX, int positionY, string entityMapIcon)
        {
            posX = positionX;
            posY = positionY;
            mapIcon = entityMapIcon;
        }

        public int EntityStatClamp(Entity entity, string whichStat, int change)
        {
            switch (whichStat) 
            {
                case "Health":
                    if (entity.Health + change <= 0) 
                    {
                        Console.WriteLine(entity.Name + " has been defeated");
                        return 0;
                    }
                    if (entity.Health + change > entity.maxHealth) 
                    {
                        Console.WriteLine(entity.Name + "'s max health is: " + entity.maxHealth + ". " + entity.Name + " cannot heal past that!");
                        int userInfoElement = entity.maxHealth - entity.Health;
                        Program.ColorWriter(ConsoleColor.Green, entity.Name + " heals " + userInfoElement + " health!");
                        return entity.maxHealth;
                    }
                    break;
                case "Block":
                    if (entity.Block + change <= 0)
                    {
                        Program.ColorWriter(ConsoleColor.Cyan, entity.Name + " block has been destroyed!");
                        return 0;
                    }
                    else 
                    {
                        Program.ColorWriter(ConsoleColor.Blue, entity.Name + " gains " + change + " Block! " + entity.Name + "'s Block: " + entity.Block + change);
                        return entity.Block + change;
                    }
                case "Dodge":
                    if (entity.Dodge + change <= 0)
                    {
                        Program.ColorWriter(ConsoleColor.DarkGreen, entity.Name + " has run out of Dodge!");
                        return 0;
                    }
                    else
                    {
                        Program.ColorWriter(ConsoleColor.DarkGreen, entity.Name + " gains " + change + " Dodge! " + entity.Name + "'s Dodge: " + entity.Dodge + change);
                        return entity.Dodge + change;
                    }
                case "Parry":
                    if (entity.Parry + change <= 0)
                    {
                        Program.ColorWriter(ConsoleColor.Cyan, entity.Name + " Parry has been broken!");
                        return 0;
                    }
                    else
                    {
                        Program.ColorWriter(ConsoleColor.Cyan, entity.Name + " gains " + change + " Parry! " + entity.Name + "'s Parry: " + entity.Parry + change);
                        return entity.Parry + change;
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
        //public Potion GetPotion(List<Potion> potion, int number) 
        //{
        //    if (potion != null) 
        //    {
        //        return potion.Where(c => c.potionNumber == number)
        //        .Single();
        //    }
        //    Potion code = new Potion("", 0);
        //    return code;
        //}
        public void Move(Entity entity, Map map, List<Monster> monsters, Player player1, Monster monster) 
        {
            if (entity == player1)
            {
                Console.Write("Enter PosX: ");
                int actualInput = 0;
                int actualInput1 = 0;
                string input = Console.ReadLine();
                try
                {
                    actualInput = Int32.Parse(input);
                }
                catch
                {
                    Move(entity, map, monsters, player1, monster);
                }
                Console.Write("Enter PosY: ");
                string input1 = Console.ReadLine();
                try
                {
                    actualInput1 = Int32.Parse(input1);
                }
                catch
                {
                    Move(entity, map, monsters, player1, monster);
                }
                if (actualInput1 == entity.posY + 1 || actualInput1 == entity.posY - 1 || actualInput1 == entity.posY && actualInput == entity.posX + 1 || actualInput == entity.posX - 1 || actualInput == entity.posX)
                {
                    for (int i = 0; i < monsters.Count; i++) 
                    {
                        if (monsters[i] != null) 
                        {
                            if (entity.posX == monsters[i].posX && entity.posY == monsters[i].posY)
                            {
                                Console.Write("Are you sure you want to attack " + monsters[i].Name + "?");
                                string input2 = Console.ReadLine();
                                if (input2 == "y" || input2 == "yes")
                                {
                                    Console.WriteLine("Which Weapon do you want to use?\n");
                                    Console.WriteLine("1) Slot 1: " + player1.EntityWeapon.name + " weapon level: " + player1.EntityWeapon.weaponlevel + " weapon damage: " + player1.EntityWeapon.weaponDamage);
                                    Console.WriteLine("2) Slot 2: " + player1.PlayerWeapon2.name + " weapon level: " + player1.PlayerWeapon2.weaponlevel + " weapon damage: " + player1.PlayerWeapon2.weaponDamage);
                                    int playerAnswer = 0;
                                    string playerInput = Console.ReadLine();
                                    try
                                    {
                                        playerAnswer = Int32.Parse(playerInput);
                                    }
                                    catch
                                    {
                                        Move(entity, map, monsters, player1, monster);
                                    }
                                    if (playerAnswer == 1)
                                    {
                                        monsters[i].Health = player1.PlayerAttack(monsters[i], player1, player1.EntityWeapon);
                                        return;
                                    }
                                    else if (playerAnswer == 2)
                                    {
                                        monsters[i].Health = player1.PlayerAttack(monsters[i], player1, player1.PlayerWeapon2);
                                        return;
                                    }
                                }
                                else
                                {
                                    Move(entity, map, monsters, player1, monster);
                                }
                            }
                        }
                    }                    
                    entity.posY = actualInput1;
                    entity.posX = actualInput;
                }
                else
                {
                    Console.WriteLine("Invalid Coordiantes!");
                    Move(entity, map, monsters, player1, monster);
                }
            }
            else 
            {
                int actualInput = GetRandom(entity.posX - 1, entity.posX + 2);
                int actualInput1 = GetRandom(entity.posY - 1, entity.posY + 2);
                if (player1 != null) 
                {
                    if (actualInput == player1.posX && actualInput1 == player1.posY)
                    {
                        player1.Health = monster.MonsterAttack(player1, monster, monsters);
                    }
                }
                else
                {
                    for (int i = 0; i < monsters.Count; i++)
                    {
                        if (entity.posX == monsters[i].posX && entity.posY == monsters[i].posY)
                        {
                            entity.Health = monster.MonsterAttack(entity, monster, monsters);
                            return;
                        }
                    }
                }
                entity.posX = actualInput;
                entity.posY = actualInput1;
            }
            if (map.mapName == "Base_Map") 
            {
                int tries = 3;
                while (entity.posX <= 0 || entity.posY <= 0 || entity.posX > Basic_Map.lengthX || entity.posY > Basic_Map.lengthY && tries > 0)
                {
                    Move(entity, map, monsters, player1, monster);
                    tries -= 1;
                    if (tries == 0) 
                    {
                        return;
                    }
                }
                Basic_Map.Build(monsters, player1, "~");
            }
        }
        static int GetRandom(int min, int max) 
        {
            Random r = new Random();
            return r.Next(min, max);
        }
    }
}
