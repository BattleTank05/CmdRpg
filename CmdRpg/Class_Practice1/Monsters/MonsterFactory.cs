using The_Dragon_Lair_SoloRPG.Equipment;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace The_Dragon_Lair_SoloRPG.Monsters
{
    class MonsterFactory
    {
        public Monster CreateRandomMonster() 
        {
            Monster monster;
            int pickMonster = GetRandom(1, 3);
            if (pickMonster == 1)
            {
                monster = CreateTroll();
                return monster;
            }
            else
            monster = CreateHuman();
            return monster;
        }
        public Monster CreateTroll() 
        {
            ItemFactory code = new ItemFactory();
            Troll troll = new Troll(0,0,"");
            int positionX = GetRandom(1, 6);
            int positionY = GetRandom(1, 6);
            int level = GetRandom(troll.MinLevel, troll.MaxLevel);
            int amplifier = GetRandom(0, level);
            int pickedMonsterName = GetRandom(1, 8);
            if (pickedMonsterName == 1 || pickedMonsterName == 2 || pickedMonsterName == 3)
            {
                Barg_The_Ugly_Brute Enemy = new Barg_The_Ugly_Brute(level, positionX, positionY, "B");
                troll = Enemy;
                int doesbarggetweapon = GetRandom(0, 5);
                if (doesbarggetweapon == 3)
                {
                    troll.EntityWeapon = code.CreateRandomWeapon(GetRandom(0, 5));
                }
                else if (troll.EntityWeapon == null) 
                {
                    Fists trollBaseWeapon = new Fists("Fists");
                    troll.EntityWeapon = trollBaseWeapon;
                }
                int doesbarggetarmor = GetRandom(0, 5);
                if (doesbarggetarmor == 3)
                {
                    troll.EntityArmor = code.CreateRandomArmor(GetRandom(0, 5));
                }
                else if (troll.EntityArmor == null) 
                {
                    Hides newTrollArmor = new Hides("");
                    troll.EntityArmor = newTrollArmor;
                }
                Enemy.DoBargAmplifiers(amplifier);
            }
            else if (pickedMonsterName == 4 || pickedMonsterName == 5 || pickedMonsterName == 6)
            {
                Klerg_The_Iceberg Enemy = new Klerg_The_Iceberg (level, positionX, positionY, "K");
                troll = Enemy;
                int doesklerggetweapon = GetRandom(0, 5);
                if (doesklerggetweapon == 3)
                {
                    troll.EntityWeapon = code.CreateRandomWeapon(GetRandom(0, 5));
                }
                else if (troll.EntityWeapon == null)
                {
                    Fists trollBaseWeapon = new Fists("Fists");
                    troll.EntityWeapon = trollBaseWeapon;
                }
                int doesklerggetarmor = GetRandom(0, 5);
                if (doesklerggetarmor == 3)
                {
                    troll.EntityArmor = code.CreateRandomArmor(GetRandom(0, 5));
                }
                else if (troll.EntityArmor == null)
                {
                    Hides newTrollArmor = new Hides("");
                    troll.EntityArmor = newTrollArmor;
                }
                Enemy.DoKlergAmplifiers(amplifier);
            }
            else if (pickedMonsterName == 7)
            {
                Grauldog Enemy = new Grauldog(level, positionX, positionY, "$");
                troll = Enemy;
                Grauldogs_Trusty_Club newWeaponForGrauldog = new Grauldogs_Trusty_Club("Grauldog's Trusty Club", GetRandom(1, 10));
                troll.EntityWeapon = newWeaponForGrauldog;
                if (troll.EntityWeapon == null)
                {
                    Fists trollBaseWeapon = new Fists("Fists");
                    troll.EntityWeapon = trollBaseWeapon;
                }
                int doesGrauldoggetarmor = GetRandom(2, 4);
                if (doesGrauldoggetarmor == 3)
                {
                    troll.EntityArmor = code.CreateRandomArmor(GetRandom(0, 10));
                }
                else if (troll.EntityArmor == null)
                {
                    Hides newTrollArmor = new Hides("");
                    troll.EntityArmor = newTrollArmor;
                }
                Enemy.DoGrauldogAmplifiers(amplifier);
            }
            return troll;
        }
        public Monster CreateHuman()
        {
            ItemFactory code = new ItemFactory();
            Human barbarian = new Human(0,0,"");
            int positionX = GetRandom(1, 6);
            int positionY = GetRandom(1, 6);
            int level = GetRandom(barbarian.MinLevel, barbarian.MaxLevel);
            int amplifier = GetRandom(0, level);
            int pickedMonsterName = GetRandom(1, 3);
            if (pickedMonsterName == 1)
            {
                Gulfard_The_Wolfherd Enemy = new Gulfard_The_Wolfherd(level, positionX, positionY, "G");
                barbarian = Enemy;
                int doesGulfardgetweapon = GetRandom(1, 4);
                if (doesGulfardgetweapon == 3)
                {
                    barbarian.EntityWeapon = code.CreateRandomWeapon(GetRandom(1, 5));
                }
                else if (barbarian.EntityWeapon == null)
                {
                    Fists barbarianBaseWeapon = new Fists("Fists");
                    barbarian.EntityWeapon = barbarianBaseWeapon;
                }
                int doesGulfardgetarmor = GetRandom(1, 4);
                if (doesGulfardgetarmor == 3)
                {
                    barbarian.EntityArmor = code.CreateRandomArmor(GetRandom(1, 5));
                }
                else if (barbarian.EntityArmor == null)
                {
                    Hides newBarbarianArmor = new Hides("");
                    barbarian.EntityArmor = newBarbarianArmor;
                }
                Enemy.DoGulfardAmplifiers(amplifier);
            }
            else if (pickedMonsterName == 2)
            {
                Berk_The_Jerk Enemy = new Berk_The_Jerk(level, positionX, positionY, "J");
                barbarian = Enemy;
                int doesBerkgetweapon = GetRandom(1, 4);
                if (doesBerkgetweapon == 3)
                {
                    barbarian.EntityWeapon = code.CreateRandomWeapon(GetRandom(1, 5));
                }
                else if (barbarian.EntityWeapon == null)
                {
                    Fists BerkBaseWeapon = new Fists("Fists");
                    barbarian.EntityWeapon = BerkBaseWeapon;
                }
                int doesberkgetarmor = GetRandom(0, 5);
                if (doesberkgetarmor == 3)
                {
                    barbarian.EntityArmor = code.CreateRandomArmor(GetRandom(1, 5));
                }
                else if (barbarian.EntityArmor == null)
                {
                    Hides newBerkArmor = new Hides("");
                    barbarian.EntityArmor = newBerkArmor;
                }
                Enemy.DoBerkAmplifiers(amplifier);
            }
            return barbarian;
        }
        static int GetRandom(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max);
        }
    }
}
