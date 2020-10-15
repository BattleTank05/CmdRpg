using The_Dragon_Lair_SoloRPG.Equipment;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using The_Dragon_Lair_SoloRPG.Consumable.Potion;

namespace The_Dragon_Lair_SoloRPG.Players
{
    class Warrior : Player
    {
        public Warrior(string playerName, int positionX, int positionY, string entityMapIcon) : base(playerName, positionX, positionY, entityMapIcon)
        {
        }
        public void WarriorActions(Player player1, List<Monster> monsters)
        {
            Thread.Sleep(1000);
            Program code = new Program();
            Render array = new Render();
            array.RenderPlayerActionsShorthand(player1);
            if (player1.level == 1)
            {
                Console.WriteLine("7) Colossal Smash = 10 - 20 Damage + strength");
            }
            //if (player1.entityPotions != null) 
            //{
            //    int number = 3;
            //    while (number > 0)
            //    {
            //        Potion potion = player1.GetPotion(entityPotions, number);
            //    }
            //}
            string playerInput;
            int playerAnswer = 0;
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    if (monsters.Count > 1)
                    for (int i = 0; i < monsters.Count; i++) 
                    {
                        if (monsters[i].posX == player1.posX || monsters[i].posX == player1.posX + 1 || monsters[i].posX == player1.posX - 1 && monsters[i].posY == player1.posY || monsters[i].posY == player1.posY + 1 || monsters[i].posY == player1.posY - 1)
                        {
                                if (monsters.Count == 1) 
                                {
                                    Console.WriteLine("You Win");
                                    code.LootPhase(player1, monsters, GetRandom(1, 10));
                                }
                            Console.WriteLine("Which Weapon do you want to use?\n");
                            Console.WriteLine("1) Slot 1: " + player1.EntityWeapon.name + " weapon level: " + player1.EntityWeapon.weaponlevel + " weapon damage: " + player1.EntityWeapon.weaponDamage);
                            Console.WriteLine("2) Slot 2: " + player1.PlayerWeapon2.name + " weapon level: " + player1.PlayerWeapon2.weaponlevel + " weapon damage: " + player1.PlayerWeapon2.weaponDamage);
                            playerInput = Console.ReadLine();
                            try
                            {
                                playerAnswer = Int32.Parse(playerInput);
                            }
                            catch
                            {
                                WarriorActions(player1, monsters);
                            }
                            if (playerAnswer == 1)
                            {
                                int monsterList = 1;
                                Console.WriteLine("Which Foe?\n");
                                for (int i1 = 0; i1 < monsters.Count; i1++)
                                {
                                    if (monsters[i1] == null)
                                    {
                                        Console.WriteLine("(Defeated Monster)");
                                    }
                                    else if (monsters[i1].Health > 0 && monsters[i1].posX == player1.posX || monsters[i1].posX == player1.posX + 1 || monsters[i1].posX == player1.posX - 1 && monsters[i1].posY == player1.posY || monsters[i1].posY == player1.posY + 1 || monsters[i1].posY == player1.posY - 1)
                                    {
                                        Console.WriteLine(monsterList + ") " + monsters[i1].Name);
                                        monsterList += 1;
                                    }
                                }
                                int playerAnswer2 = 0;
                                string playerInput2 = Console.ReadLine();
                                try
                                {
                                    playerAnswer2 = Int32.Parse(playerInput2);
                                }
                                catch
                                {
                                    WarriorActions(player1, monsters);
                                }
                                switch (playerAnswer2)
                                {
                                    case 1:
                                        if (monsters[0] != null)
                                        {
                                            monsters[0].Health = player1.PlayerAttack(monsters[0], player1, player1.EntityWeapon);
                                            return;
                                        }
                                        break;
                                    case 2:
                                        if (monsters[1] != null)
                                        {
                                            monsters[1].Health = player1.PlayerAttack(monsters[1], player1, player1.EntityWeapon);
                                            return;
                                        }
                                        break;
                                    case 3:
                                        if (monsters[2] != null)
                                        {
                                            monsters[2].Health = player1.PlayerAttack(monsters[2], player1, player1.EntityWeapon);
                                            return;
                                        }
                                        break;
                                    case 4:
                                        if (monsters[3] != null)
                                        {
                                            monsters[3].Health = player1.PlayerAttack(monsters[3], player1, player1.EntityWeapon);
                                            return;
                                        }
                                        break;
                                    case 5:
                                        if (monsters[4] != null)
                                        {
                                            monsters[4].Health = player1.PlayerAttack(monsters[4], player1, player1.EntityWeapon);
                                            return;
                                        }
                                        break;
                                }
                            }
                            else if (playerAnswer == 2)
                            {
                                int monsterList = 1;
                                Console.WriteLine("Which Foe?\n");
                                for (int i2 = 0; i2 < monsters.Count; i2++)
                                {
                                    if (monsters[i2] != null)
                                    {
                                        if (monsters[i2].Health > 0)
                                        {
                                            Console.WriteLine(monsterList + ") " + monsters[i2].Name);
                                            monsterList += 1;
                                        }
                                    }
                                }
                                int playerAnswer2 = 0;
                                string playerInput2 = Console.ReadLine();
                                try
                                {
                                    playerAnswer2 = Int32.Parse(playerInput2);
                                }
                                catch
                                {
                                    WarriorActions(player1, monsters);
                                }
                                switch (playerAnswer2)
                                {
                                    case 1:
                                        if (monsters[0] != null)
                                        {
                                            monsters[0].Health = player1.PlayerAttack(monsters[0], player1, player1.PlayerWeapon2);
                                            return;
                                        }
                                        break;
                                    case 2:
                                        if (monsters[1] != null)
                                        {
                                            monsters[1].Health = player1.PlayerAttack(monsters[1], player1, player1.PlayerWeapon2);
                                            return;
                                        }
                                        break;
                                    case 3:
                                        if (monsters[2] != null)
                                        {
                                            monsters[2].Health = player1.PlayerAttack(monsters[2], player1, player1.PlayerWeapon2);
                                            return;
                                        }
                                        break;
                                    case 4:
                                        if (monsters[3] != null)
                                        {
                                            monsters[3].Health = player1.PlayerAttack(monsters[3], player1, player1.PlayerWeapon2);
                                            return;
                                        }
                                        break;
                                    case 5:
                                        if (monsters[4] != null)
                                        {
                                            monsters[4].Health = player1.PlayerAttack(monsters[4], player1, player1.PlayerWeapon2);
                                            return;
                                        }
                                        break;
                                }
                            }
                            else
                            {
                                WarriorActions(player1, monsters);
                                Thread.Sleep(500);
                            }
                        }
                        else 
                        {
                            Console.WriteLine("No nearby enemies!");
                            WarriorActions(player1, monsters);
                        }
                    }
                    break;
                case "2":
                    player1.Block = player1.Player_Defend(player1);
                    Thread.Sleep(500);
                    break;
                case "3":
                    Console.WriteLine("Which Weapon do you want to use to Parry?\n");
                    Console.WriteLine("1) Slot 1: " + player1.EntityWeapon.name + " weapon level: " + player1.EntityWeapon.weaponlevel + " weapon damage: " + player1.EntityWeapon.weaponDamage);
                    Console.WriteLine("2) Slot 2: " + player1.PlayerWeapon2.name + " weapon level: " + player1.PlayerWeapon2.weaponlevel + " weapon parry: " + player1.PlayerWeapon2.weaponParry);
                    playerInput = Console.ReadLine();
                    try
                    {
                        playerAnswer = Int32.Parse(playerInput);
                    }
                    catch
                    {
                        WarriorActions(player1, monsters);
                    }
                    if (playerAnswer == 1)
                    {
                        player1.Parry = player1.Player_Parry(player1, player1.EntityWeapon);
                        return;
                    }
                    if (playerAnswer == 2)
                    {
                        player1.Parry = Player_Parry(player1, player1.PlayerWeapon2);
                        return;
                    }
                    else
                        WarriorActions(player1, monsters);
                    Thread.Sleep(500);
                    break;
                case "4":
                    if (player1.Health < player1.maxHealth)
                    {
                        player1.Health = player1.Player_Heal(player1);
                        Console.WriteLine(player1.Name + " has reduced their bleeding status by one!");
                        player1.entityBleeding -= 1;
                        Console.WriteLine(player1.Name + "'s bleed: " + player1.entityBleeding);
                        Thread.Sleep(500);
                    }
                    else
                        Console.WriteLine("You are at maximum health!");
                    break;
                case "5":
                    player1.Dodge = player1.Player_Dodge(player1);
                    Thread.Sleep(500);
                    break;
                case "Stats":
                    Console.WriteLine("1) see your stats");
                    Console.WriteLine("2) see monster's stats");
                    Console.WriteLine("3) see your Gear stats");
                    string statsType = Console.ReadLine();
                    if (statsType == "1")
                    {
                        array.RenderPlayerStats(player1);
                    }
                    if (statsType == "2")
                    {
                        for (int i = 0; i < monsters.Capacity; i++)
                        {
                            if (monsters[i] != null)
                            {
                                array.RenderMonsterStats(monsters[i]);
                            }
                            else
                                Console.WriteLine("(defeated monster)");
                        }
                    }
                    if (statsType == "3")
                    {
                        array.RenderPlayerGearStats(player1);
                    }
                    WarriorActions(player1, monsters);
                    break;
                case "6":
                    if (player1.level >= 1)
                    {
                        int monsterList = 1;
                        Console.WriteLine("Which Foe?\n");
                        for (int i = 0; i < monsters.Capacity; i++)
                        {
                            if (monsters[i] != null)
                            {
                                if (monsters[i].Health > 0)
                                {
                                    Console.WriteLine(monsterList + ") " + monsters[i].Name);
                                    monsterList += 1;
                                }
                            }
                        }
                        int playerAnswer2 = 0;
                        string playerInput2 = Console.ReadLine();
                        try
                        {
                            playerAnswer2 = Int32.Parse(playerInput2);
                        }
                        catch
                        {
                            WarriorActions(player1, monsters);
                        }
                        switch (playerAnswer2)
                        {
                            case 1:
                                if (monsters[0] != null)
                                {
                                    monsters[0].Health = Colossal_Smash(player1, monsters[0], player1.EntityWeapon);
                                    return;
                                }
                                break;
                            case 2:
                                if (monsters[1] != null)
                                {
                                    monsters[1].Health = Colossal_Smash(player1, monsters[1], player1.EntityWeapon);
                                    return;
                                }
                                break;
                            case 3:
                                if (monsters[2] != null)
                                {
                                    monsters[2].Health = Colossal_Smash(player1, monsters[2], player1.EntityWeapon);
                                    return;
                                }
                                break;
                            case 4:
                                if (monsters[3] != null)
                                {
                                    monsters[3].Health = Colossal_Smash(player1, monsters[3], player1.EntityWeapon);
                                    return;
                                }
                                break;
                            case 5:
                                if (monsters[4] != null)
                                {
                                    monsters[4].Health = Colossal_Smash(player1, monsters[4], player1.EntityWeapon);
                                    return;
                                }
                                break;
                        }
                    }
                    else
                        WarriorActions(player1, monsters);
                    break;
                case "see inventory":
                    break;
                case "move":
                    Map map = new Map("Base_Map");
                    Move(player1, map, monsters, player1, monsters[0]);
                    break;
                default:
                    WarriorActions(player1, monsters);
                    break;
            }
            for (int i = 0; i < monsters.Count; i++)
            {
                if (monsters[i] != null) 
                {
                    if (monsters[i].Health <= 0)
                    {
                        Console.WriteLine("You have defeated " + monsters[i].Name + "!");

                        Console.WriteLine("You gain experience");
                        player1.XP += 10;
                        if (player1.XP == player1.XPToLevel)
                        {
                            player1.XP -= player1.XPToLevel;
                            player1.XPToLevel += 50;
                            player1.level += 1;
                            Console.WriteLine("you have gained a level!");
                        }
                    }
                }
            }
            return;
        }
        public int Colossal_Smash(Player player1, Monster monster, Weapon PlayerWeapon)
        {
            int playerDamage1 = GetRandom(PlayerWeapon.weaponDamage + 5, PlayerWeapon.weaponDamage + 10);
            Console.WriteLine("Your Damage: " + playerDamage1);
            Console.WriteLine(monster.Name + " Block: " + monster.Block);
            if (monster.Block > 0)
            {
                if (playerDamage1 > monster.Block)
                {
                    monster.Block = 0;
                }
                else
                    playerDamage1 -= monster.Block;
                monster.Block = 0;
            }
            if (monster.EntityArmor.armorProtectionAmount > 0 && playerDamage1 > 0)
            {
                if (playerDamage1 > monster.EntityArmor.armorProtectionAmount)
                {
                    monster.EntityArmor.armorProtectionAmount = 0;
                }
                else playerDamage1 -= monster.EntityArmor.armorProtectionAmount;
            }
            while (playerDamage1 <= 0)
            {
                playerDamage1 += 1;
            }
            monster.Dodge -= 1;
            if (monster.Dodge > 0 && playerDamage1 > 0 && playerDamage1 / 3 <= monster.Dodge)
            {
                playerDamage1 = 0;
                monster.Dodge -= 2;
                if (monster.Dodge < 0)
                {
                    monster.Dodge = 0;
                }
            }
            int playerStrength = player1.Strength * 2;
            monster.Health = monster.Health - playerDamage1 + playerStrength;
            Console.WriteLine("your Strength(doubled for this attack): " + playerStrength);
            Console.WriteLine("your Damage: " + playerDamage1);
            Console.WriteLine(monster.Name + " Health: " + monster.Health);
            return monster.Health;
        }
        static int GetRandom(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max);
        }
    }
}
