using The_Dragon_Lair_SoloRPG.Equipment;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;

namespace The_Dragon_Lair_SoloRPG
{
    public class Monster : Entity
    {
        public int monsterInflictBleedingMin = -1;
        public int monsterInflictBleedingMax = 2;
        public int monsterBleeding = 0;
        public int monsterOnFire = 0;

        public Monster(int positionX, int positionY, string entityMapIcon) : base(positionX, positionY, entityMapIcon)
        {
        }

        public void MonsterActions(Monster monster, Player player1, List<Monster> monsters, Boolean isDebuggerFight)
        {
            #region monsterAttackAndClassVariables
            Render code = new Render();
            Monster start = new Monster(0,0, "");
            Map map = new Map("Base_Map");
            int monsterAction = GetRandom(1, 12);
            int whichTarget = GetRandom(0, monsters.Count);
            int isTargetPlayer = 0;
            #endregion
            switch (monsterAction)
            {
                case 1:
                    monster.Block = start.Monster_Defend(monster);
                    break;
                case 2:
                    if (isDebuggerFight == false) 
                    {
                        isTargetPlayer = GetRandom(1, 3);
                        if (isTargetPlayer == 2 && player1.posX == this.posX + 1 || player1.posX == this.posX - 1 || player1.posX == this.posX && player1.posY == this.posY + 1 || player1.posY == this.posY - 1 || player1.posY == this.posY)
                        {
                            player1.Health = start.MonsterAttack(player1, monster);
                        }
                        else 
                        {
                            Move(monster, map, monsters, player1, monster);
                        }
                    }
                    if (monsters[whichTarget] != this && monsters[whichTarget] != null)
                    {
                        if (monsters[whichTarget].posX == this.posX + 1 || monsters[whichTarget].posX == this.posX - 1 || monsters[whichTarget].posX == this.posX && monsters[whichTarget].posY == this.posY + 1 || monsters[whichTarget].posY == this.posY - 1 || monsters[whichTarget].posY == this.posY) 
                        {
                            monsters[whichTarget].Health = start.MonsterAttack(monsters[whichTarget], monster);
                        }
                    }
                    break;
                case 3:
                    if (isDebuggerFight == false)
                    {
                        isTargetPlayer = GetRandom(1, 3);
                        if (isTargetPlayer == 2 && player1.posX == this.posX + 1 || player1.posX == this.posX - 1 || player1.posX == this.posX && player1.posY == this.posY + 1 || player1.posY == this.posY - 1 || player1.posY == this.posY)
                        {
                            player1.Health = start.MonsterAttack(player1, monster);
                        }
                        else
                        {
                            Move(monster, map, monsters, player1, monster);
                        }
                    }
                    if (monsters[whichTarget] != this && monsters[whichTarget] != null)
                    {
                        if (monsters[whichTarget].posX == this.posX + 1 || monsters[whichTarget].posX == this.posX - 1 || monsters[whichTarget].posX == this.posX && monsters[whichTarget].posY == this.posY + 1 || monsters[whichTarget].posY == this.posY - 1 || monsters[whichTarget].posY == this.posY)
                        {
                            monsters[whichTarget].Health = start.MonsterAttack(monsters[whichTarget], monster);
                        }
                    }
                    break;
                case 4:
                    monster.Health = start.Monster_Heal(monster);
                    monster.monsterBleeding -= 1;
                    break;
                case 5:
                    monster.Dodge = start.Monster_Dodge(monster);
                    break;
                case 6:
                    if (isDebuggerFight == false)
                    {
                        isTargetPlayer = GetRandom(1, 3);
                        if (isTargetPlayer == 2 && player1.posX == this.posX + 1 || player1.posX == this.posX - 1 || player1.posX == this.posX && player1.posY == this.posY + 1 || player1.posY == this.posY - 1 || player1.posY == this.posY)
                        {
                            player1.Health = start.MonsterAttack(player1, monster);
                        }
                        else
                        {
                            Move(monster, map, monsters, player1, monster);
                        }
                    }
                    if (monsters[whichTarget] != this && monsters[whichTarget] != null)
                    {
                        if (monsters[whichTarget].posX == this.posX + 1 || monsters[whichTarget].posX == this.posX - 1 || monsters[whichTarget].posX == this.posX && monsters[whichTarget].posY == this.posY + 1 || monsters[whichTarget].posY == this.posY - 1 || monsters[whichTarget].posY == this.posY)
                        {
                            monsters[whichTarget].Health = start.MonsterAttack(monsters[whichTarget], monster);
                        }
                    }
                    break;
                case 7:
                    if (isDebuggerFight == false)
                    {
                        isTargetPlayer = GetRandom(1, 3);
                        if (isTargetPlayer == 2 && player1.posX == this.posX + 1 || player1.posX == this.posX - 1 || player1.posX == this.posX && player1.posY == this.posY + 1 || player1.posY == this.posY - 1 || player1.posY == this.posY)
                        {
                            player1.Health = start.MonsterAttack(player1, monster);
                        }
                        else
                        {
                            Move(monster, map, monsters, player1, monster);
                        }
                    }
                    if (monsters[whichTarget] != this && monsters[whichTarget] != null)
                    {
                        if (monsters[whichTarget].posX == this.posX + 1 || monsters[whichTarget].posX == this.posX - 1 || monsters[whichTarget].posX == this.posX && monsters[whichTarget].posY == this.posY + 1 || monsters[whichTarget].posY == this.posY - 1 || monsters[whichTarget].posY == this.posY)
                        {
                            monsters[whichTarget].Health = start.MonsterAttack(monsters[whichTarget], monster);
                        }
                    }
                    break;
                case 8:
                    if (isDebuggerFight == false)
                    {
                        isTargetPlayer = GetRandom(1, 3);
                        if (isTargetPlayer == 2 && player1.posX == this.posX + 1 || player1.posX == this.posX - 1 || player1.posX == this.posX && player1.posY == this.posY + 1 || player1.posY == this.posY - 1 || player1.posY == this.posY)
                        {
                            player1.Health = start.MonsterAttack(player1, monster);
                        }
                        else
                        {
                            Move(monster, map, monsters, player1, monster);
                        }
                    }
                    if (monsters[whichTarget] != this && monsters[whichTarget] != null)
                    {
                        if (monsters[whichTarget].posX == this.posX + 1 || monsters[whichTarget].posX == this.posX - 1 || monsters[whichTarget].posX == this.posX && monsters[whichTarget].posY == this.posY + 1 || monsters[whichTarget].posY == this.posY - 1 || monsters[whichTarget].posY == this.posY)
                        {
                            monsters[whichTarget].Health = start.MonsterAttack(monsters[whichTarget], monster);
                        }
                    }
                    break;
                case 9:
                    if (isDebuggerFight == false)
                    {
                        isTargetPlayer = GetRandom(1, 3);
                        if (isTargetPlayer == 2 && player1.posX == this.posX + 1 || player1.posX == this.posX - 1 || player1.posX == this.posX && player1.posY == this.posY + 1 || player1.posY == this.posY - 1 || player1.posY == this.posY)
                        {
                            player1.Health = start.MonsterAttack(player1, monster);
                        }
                        else
                        {
                            Move(monster, map, monsters, player1, monster);
                        }
                    }
                    if (monsters[whichTarget] != this && monsters[whichTarget] != null)
                    {
                        if (monsters[whichTarget].posX == this.posX + 1 || monsters[whichTarget].posX == this.posX - 1 || monsters[whichTarget].posX == this.posX && monsters[whichTarget].posY == this.posY + 1 || monsters[whichTarget].posY == this.posY - 1 || monsters[whichTarget].posY == this.posY)
                        {
                            monsters[whichTarget].Health = start.MonsterAttack(monsters[whichTarget], monster);
                        }
                    }
                    break;
                case 10:
                    monster.Parry = start.Monster_Parry(monster);
                    break;
                case 11:
                    Move(monster, map, monsters, player1, monster);
                    break;
            }
            //Thread.Sleep(5000);
        }
        public int MonsterAttack(Entity entity, Monster monster)
        {
            #region monsterAttackAndClassVariables
            Render array = new Render();
            int monsterAttack2 = 0;
            int monsterAttack1 = 0;
            int monsterAttackAmount = 0;
            #endregion

            while (monster.EntityWeapon.weaponAttackAmount > 0)
            {
                monsterAttack1 = GetRandom(monster.EntityWeapon.weaponDamage - 2, monster.EntityWeapon.weaponDamage);
                //array.GainOrLoseStatsRenderer(monster, entity, "deals", monsterAttack1, "damage");
                Program.ColorWriter(ConsoleColor.Red, monster.Name + " Deals " + monsterAttack1 + " Damage to " + entity.Name);
                //if (entity.Dodge > 0)
                //{
                //    if (monsterAttack1 / entity.Dodge <= entity.Dodge)
                //    {
                //        Program.ColorWriter(ConsoleColor.DarkGreen, entity.Name + " successfully Dodges " + monster.Name + "'s attack");
                //        entity.Dodge -= 1;
                //        monster.EntityWeapon.weaponDurability -= 1;
                //        monsterAttack1 = 0;
                //    }
                //}
                if (monsterAttack1 <= entity.Parry && entity.Parry >= 0 && monsterAttack1 > 0)
                {
                    Program.ColorWriter(ConsoleColor.Cyan, entity.Name + " successfully Parries " + monster.Name + "'s attack");
                    entity.Parry -= GetRandom(0, monsterAttack1);
                    monsterAttack1 = 0;
                    monster.EntityWeapon.weaponDurability -= 5;
                    
                }
                if (entity.Block <= 0 && monsterAttack1 > 0)
                {
                    int CriticalChance = GetRandom(0, 100);
                    if (CriticalChance <= monster.EntityWeapon.weaponCriticalStrike)
                    {
                        monsterAttack1 += monster.EntityWeapon.weaponCriticalStrike / 10;
                        monster.monsterInflictBleedingMin += 1;
                        monster.monsterInflictBleedingMax += 1;
                        Program.ColorWriter(ConsoleColor.DarkMagenta, monster.Name + " Struck a Critical Strike on " + entity.Name + "!");
                        Program.ColorWriter(ConsoleColor.DarkMagenta, monster.Name + "Gains +" + monster.EntityWeapon.weaponCriticalStrike / 10 + " Damage!");
                    }
                }
                monsterAttack2 += monsterAttack1;
                monster.EntityWeapon.weaponAttackAmount -= 1;
                monsterAttackAmount += 1;
            }
            monster.EntityWeapon.weaponAttackAmount = monsterAttackAmount;
            monsterAttackAmount = 0;
            int monsterDamage1 = monsterAttack2 + Strength;
            entity.Block -= monster.EntityWeapon.weaponAttributePiercing;

            if (monsterDamage1 <= entity.Block) 
            {
                monster.EntityWeapon.weaponDurability -= 5;
                entity.Block -= monsterDamage1;
            }

            int monsterDamage = monsterDamage1 - entity.EntityArmor.armorProtectionAmount;
            Console.WriteLine(entity.Name + "'s Gear can block " + entity.EntityArmor.armorProtectionAmount + " damage");

            if (monsterDamage <= entity.EntityArmor.armorProtectionAmount) 
            {
                monster.EntityWeapon.weaponDurability -= 5;
                entity.EntityArmor.armorDurability -= monsterDamage;
                Console.WriteLine(entity.Name + " Sustains " + monsterDamage1 + " Gear Damage");
                monsterDamage = 0;
            }

            if (entity.Block == 0 && monsterAttack2 > 0)
            {
                entity.entityBleeding += GetRandom(monster.monsterInflictBleedingMin, monster.monsterInflictBleedingMax);
            }

            while (monsterDamage < 0)
            {
                monsterDamage += 1;
            }

            if (entity.EntityArmor.armorDurability <= 0)
            {
                Console.WriteLine(entity.Name + "'s gear has broken!");
                entity.EntityArmor.armorProtectionAmount = 0;
            }

            entity.Health -= monsterDamage;
            Console.WriteLine( entity.Name + "'s Health: " + entity.Health + "\n");

            if (entity.Health < 1)
            {
                Console.WriteLine( entity.Name + " Has been defeated...\n");
            }

            monster.EntityWeapon.weaponDurability -= 1;
            Thread.Sleep(3000);
            return entity.Health;
        }
        public int Monster_Defend(Monster monster)
        {
            int monsterBlock = GetRandom(monster.EntityArmor.armorProtectionAmount - 4, monster.EntityArmor.armorProtectionAmount);
            return monster.EntityStatClamp(monster, "Block", monsterBlock);
        }
        public int Monster_Parry(Monster monster)
        {
            int monsterParry = GetRandom(monster.EntityWeapon.weaponParry - 4, monster.EntityWeapon.weaponParry);
            return monster.EntityStatClamp(monster, "Health", monsterParry);
        }
        public int Monster_Heal(Monster monster)
        {
            int heal = GetRandom(1, 10);
            return monster.EntityStatClamp(monster, "Health", heal);
        }
        public int Monster_Dodge(Monster monster)
        {
            int monsterDodge = GetRandom(MinDodge, MaxDodge);
            return monster.EntityStatClamp(monster, "Health", monsterDodge);
        }
        static int GetRandom(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max);
        }
    }
}
