using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace The_Dragon_Lair_SoloRPG.Players
{
    public class Rogue : Player
    {
        public Rogue(string playerName, int positionX, int positionY, string entityMapIcon) : base(playerName, positionX, positionY, entityMapIcon)
        {
        }
        public void RogueActions(Player player1, Monster[] monsters)
        {
            Thread.Sleep(1000);
            Program code = new Program();
            Render array = new Render();
            array.RenderPlayerActionsShorthand(player1);
            if (player1.level == 1)
            {
                Console.WriteLine("6) Double Strike: attack twice");
            }
            string playerInput;
            int playerAnswer = 0;
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
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
                        RogueActions(player1, monsters);
                    }
                    if (playerAnswer == 1)
                    {
                        int monsterList = 1;
                        Console.WriteLine("Which Foe?\n");
                        for (int i = 0; i < monsters.Length; i++)
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
                            playerAnswer2 = Int32.Parse(playerInput);
                        }
                        catch
                        {
                            RogueActions(player1, monsters);
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
                    if (playerAnswer == 2)
                    {
                        int monsterList = 1;
                        Console.WriteLine("Which Foe?\n");
                        for (int i = 0; i < monsters.Length; i++)
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
                            RogueActions(player1, monsters);
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
                    else
                        RogueActions(player1, monsters);
                    Thread.Sleep(500);
                    break;
                case "2":
                    player1.Block = player1.Player_Defend(player1);
                    Thread.Sleep(500);
                    break;
                case "3":
                    Console.WriteLine("Which Weapon do you want to use to Parry?\n");
                    Console.WriteLine("1) Slot 1: " + player1.EntityWeapon.name + " weapon level: " + player1.EntityWeapon.weaponlevel + " weapon parry: " + player1.EntityWeapon.weaponParry);
                    Console.WriteLine("2) Slot 2: " + player1.PlayerWeapon2.name + " weapon level: " + player1.PlayerWeapon2.weaponlevel + " weapon parry: " + player1.PlayerWeapon2.weaponParry);
                    playerInput = Console.ReadLine();
                    try
                    {
                        playerAnswer = Int32.Parse(playerInput);
                    }
                    catch
                    {
                        RogueActions(player1, monsters);
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
                        RogueActions(player1, monsters);
                    Thread.Sleep(500);
                    break;
                case "4":
                    player1.Health = player1.Player_Heal(player1);
                    Thread.Sleep(500);
                    player1.entityBleeding -= 1;
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
                        for (int i = 0; i < monsters.Length; i++)
                        {
                            array.RenderMonsterStats(monsters[i]);
                        }
                    }
                    if (statsType == "3")
                    {
                        array.RenderPlayerGearStats(player1);
                    }
                    RogueActions(player1, monsters);
                    break;
                case "6":
                    if (player1.level >= 1)
                    {
                        int monsterList = 1;
                        Console.WriteLine("Which Foe?\n");
                        for (int i = 0; i < monsters.Length; i++)
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
                            RogueActions(player1, monsters);
                        }
                        switch (playerAnswer2)
                        {
                            case 1:
                                if (monsters[0] != null)
                                {
                                    Double_Strike(player1, monsters[0]);
                                    return;
                                }
                                break;
                            case 2:
                                if (monsters[1] != null)
                                {
                                    Double_Strike(player1, monsters[1]);
                                    return;
                                }
                                break;
                            case 3:
                                if (monsters[2] != null)
                                {
                                    Double_Strike(player1, monsters[2]);
                                    return;
                                }
                                break;
                            case 4:
                                if (monsters[3] != null)
                                {
                                    Double_Strike(player1, monsters[3]);
                                    return;
                                }
                                break;
                            case 5:
                                if (monsters[4] != null)
                                {
                                    Double_Strike(player1, monsters[4]);
                                    return;
                                }
                                break;
                        }
                    }
                    else
                        RogueActions(player1, monsters);
                    break;
                case "see inventory":
                    break;
                default:
                    RogueActions(player1, monsters);
                    break;
            }
            for (int i = 0; i < monsters.Length; i++)
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
            return;
        }
        public void Double_Strike(Player player1, Monster monster)
        {
            string playerInput;
            int playerAnswer = 0;
            player1.EntityWeapon.weaponDamage += 1;
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
                Double_Strike(player1, monster);
            }
            if (playerAnswer == 1)
            {
                monster.Health = PlayerAttack(monster, player1, player1.EntityWeapon);
            }
            if (playerAnswer == 2)
            {
                monster.Health = PlayerAttack(monster, player1, player1.PlayerWeapon2);
            }
            if (playerAnswer != 1 && playerAnswer != 2)
            {
                Double_Strike(player1, monster);
            }
            Console.WriteLine("(attack 2)Which Weapon do you want to use?\n");
            Console.WriteLine("1) Slot 1: " + player1.EntityWeapon.name + " weapon level: " + player1.EntityWeapon.weaponlevel + " weapon damage: " + player1.EntityWeapon.weaponDamage);
            Console.WriteLine("2) Slot 2: " + player1.PlayerWeapon2.name + " weapon level: " + player1.PlayerWeapon2.weaponlevel + " weapon damage: " + player1.PlayerWeapon2.weaponDamage);
            playerInput = Console.ReadLine();
            try
            {
                playerAnswer = Int32.Parse(playerInput);
            }
            catch
            {
                Double_Strike(player1, monster);
            }
            if (playerAnswer == 1)
            {
                monster.Health = PlayerAttack(monster, player1, player1.EntityWeapon);
                return;
            }
            if (playerAnswer == 2)
            {
                monster.Health = PlayerAttack(monster, player1, player1.PlayerWeapon2);
                return;
            }
            else
                Double_Strike(player1, monster);
            Thread.Sleep(500);
        }
    }
}
