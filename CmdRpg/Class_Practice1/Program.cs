using The_Dragon_Lair_SoloRPG.Players;
using The_Dragon_Lair_SoloRPG.Equipment;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.ComponentModel;
using The_Dragon_Lair_SoloRPG.Monsters;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using The_Dragon_Lair_SoloRPG.Maps;

namespace The_Dragon_Lair_SoloRPG
{
    class Program
    {
        public static Player player1;
        public bool isFightBossFight;
        public bool isDebuggerFight;
        static void Main(string[] args)
        {
            Program code = new Program();
            int playerAnswer = 0;
            Console.WriteLine("which mode?\n1) gameplay\n2) debugger");
            string playerInput = Console.ReadLine();
            try
            {
                playerAnswer = Int32.Parse(playerInput);
            }
            catch
            {
            }
            if (playerAnswer == 1)
            {
                Console.WriteLine("type a name for your Character");
                string PlayerName = Console.ReadLine();
                #region DeclarePlayerVariables
                player1 = new Player(PlayerName, 5, 5, "Y");
                player1.Health += 10000;
                player1.maxHealth += 20;
                player1.Strength += 2;
                player1.Dodge += 1;
                player1.Intellect += 1;
                player1.level = 0;
                #endregion
                PlayerChooseLoadout();
            }
            if (playerAnswer == 2)
            {
                #region DeclareDebuggerVariables
                int howManyMonsters = GetRandom(2, 5);
                MonsterFactory code1 = new MonsterFactory();
                Monster[] monsters = new Monster[howManyMonsters];
                int playerHowFast = 0;
                #endregion

                while (howManyMonsters > 0)
                {
                    for (int i = 0; i < monsters.Length; i++)
                    {
                        Monster monster = code1.CreateRandomMonster();
                        if (i > 0)
                        {
                            monsters[i] = monster;
                            howManyMonsters -= 1;
                        }
                        else
                            monsters[i] = monster;
                    }
                }

                Console.WriteLine("How fast?");
                string playerInput2 = Console.ReadLine();
                try
                {
                    playerHowFast = Int32.Parse(playerInput2);
                }
                catch { }
                Thread.Sleep(playerHowFast);
                code.isDebuggerFight = true;
                code.DebuggerFight(monsters, playerHowFast);
            }
        }
        static void PlayerChooseLoadout()
        {
            Render code = new Render();
            Program code1 = new Program();
            code.RenderPlayerChoosing(1);
            string info2 = Console.ReadLine();
            int playerInput;

            try
            {
                playerInput = Int32.Parse(info2);
            }
            catch
            {
                Console.WriteLine("Creation Error... Shutting...Down....");
                PlayerChooseLoadout();
                return;
            }
            switch (playerInput)
            {
                case 1:
                    player1.classType = "Warrior";
                    Console.WriteLine("Warrior it is...");
                    break;
                case 2:
                    player1.classType = "Mage";
                    Console.WriteLine("Mage it is...");
                    break;
                case 3:
                    player1.classType = "Rogue";
                    Console.WriteLine("Rogue it is...");
                    break;
                default:
                    Console.WriteLine("Creation Error... Shutting...Down....");
                    PlayerChooseLoadout();
                    return;
            }

            code.RenderPlayerChoosing(2);
            string info = Console.ReadLine();

            try
            {
                playerInput = Int32.Parse(info);
            }
            catch
            {
                Console.WriteLine("Creation Error... Shutting...Down....");
                PlayerChooseLoadout();
                return;
            }

            int weaponLevel = GetRandom(1, 5);
            ItemFactory code3 = new ItemFactory();

            switch (playerInput)
            {
                case 1:
                    Broadsword PlayerWeapon = new Broadsword("", weaponLevel);
                    player1.EntityWeapon = PlayerWeapon;
                    Console.WriteLine("Broadsword it is...");
                    break;
                case 2:
                    Mace PlayerWeapon2 = new Mace("", weaponLevel);
                    player1.EntityWeapon = PlayerWeapon2;
                    Console.WriteLine("Mace it is...");
                    break;
                case 3:
                    Daggers PlayerWeapon3 = new Daggers("", weaponLevel);
                    player1.EntityWeapon = PlayerWeapon3;
                    Console.WriteLine("Twin Daggers it is...");
                    break;
                case 4:
                    Axe PlayerWeapon4 = new Axe("", weaponLevel);
                    player1.EntityWeapon = PlayerWeapon4;
                    Console.WriteLine("War Axe it is...");
                    break;
                case 5:
                    Weapon PlayerWeapon5 = code3.CreateRandomWeapon(weaponLevel);
                    player1.EntityWeapon = PlayerWeapon5;
                    Console.WriteLine(player1.EntityWeapon.name + " it is...");
                    break;
                default:
                    Console.WriteLine("Creation Error... Shutting...Down....");
                    PlayerChooseLoadout();
                    return;
            }

            code.RenderPlayerChoosing(3);
            string info1 = Console.ReadLine();
            try
            {
                playerInput = Int32.Parse(info1);
            }
            catch
            {
                Console.WriteLine("Creation Error... Restarting...");
                PlayerChooseLoadout();
                return;
            }
            int armorLevel = GetRandom(1, 5);
            switch (playerInput)
            {
                case 1:
                    Chainmail PlayerArmor = new Chainmail("", armorLevel);
                    player1.EntityArmor = PlayerArmor;
                    Console.WriteLine("Chainmail it is...");
                    break;
                case 2:
                    Leather PlayerArmor2 = new Leather("", armorLevel);
                    player1.EntityArmor = PlayerArmor2;
                    Console.WriteLine("Thick Leather it is...");
                    break;
                case 3:
                    Cloth PlayerArmor3 = new Cloth("", armorLevel);
                    player1.EntityArmor = PlayerArmor3;
                    Console.WriteLine("Sleek Silken Thinking Cloth... is that even armor?");
                    break;
                case 4:
                    Plate PlayerArmor4 = new Plate("", armorLevel);
                    player1.EntityArmor = PlayerArmor4;
                    Console.WriteLine("Plate it is...");
                    break;
                case 5:
                    Armor PlayerArmor5 = code3.CreateRandomArmor(armorLevel);
                    player1.EntityArmor = PlayerArmor5;
                    Console.WriteLine(player1.EntityArmor.name + " it is...");
                    break;
                default:
                    Console.WriteLine("Creation Error... Restarting...");
                    PlayerChooseLoadout();
                    return;
            }
            ColorWriter(ConsoleColor.Gray, "ready yourself, Gladiator...\n");
            Thread.Sleep(1000);
            int howManyMonsters = GetRandom(1, 5);
            MonsterIntro(player1, howManyMonsters);
        }
        static void MonsterIntro(Player player1, int howManyMonsters)
        {
            #region DeclareClassVariables
            Render array = new Render();
            Program code = new Program();
            MonsterFactory code1 = new MonsterFactory();
            Monster[] monsters = new Monster[howManyMonsters];
            #endregion
            while (howManyMonsters > 0)
            {
                for (int i = 0; i < monsters.Length; i++)
                {
                    Monster monster = code1.CreateRandomMonster();
                    if (monster.Name == "Grauldog, champion of the Trolls")
                    {
                        code.isFightBossFight = true;
                    }
                    monsters[i] = monster;
                    howManyMonsters -= 1;
                }
            }
            for (int i = 0; i < monsters.Length; i++)
            {
                array.RenderMonsterStats(monsters[i]);
            }
            Thread.Sleep(1000);
            code.Fight(monsters, player1);
        }
        public void Fight(Monster[] monsters, Player player1)
        {
            #region DeclareClassVariables
            Warrior classActions = new Warrior("", 0,0, "");
            Mage classActions2 = new Mage("", 0,0,"");
            Rogue classActions3 = new Rogue("", 0,0,"");
            Fight_Rounds code = new Fight_Rounds();
            #endregion
            while (player1.Health > 0 && monsters != null)
            {
                Basic_Map.Build(monsters, player1, "~");
                if (player1.Health > 0)
                {
                    code.RoundStart(monsters, player1);
                    if (player1.classType == "Warrior")
                    {
                        classActions.WarriorActions(player1, monsters);
                    }
                    if (player1.classType == "Mage")
                    {
                        classActions2.MageActions(player1, monsters);
                    }
                    if (player1.classType == "Rogue")
                    {
                        classActions3.RogueActions(player1, monsters);
                    }
                    int defeatedMonsters = 0;
                    for (int i = 0; i < monsters.Length; i++)
                    {
                        if (monsters[i] == null)
                        {
                            defeatedMonsters += 1;
                        }
                    }
                    if (defeatedMonsters == monsters.Length)
                    {
                        Console.WriteLine("All monsters defeated!");
                        LootPhase(player1, monsters, GetRandom(1, 5) + monsters.Length + player1.level);
                    }
                    else
                        defeatedMonsters = 0;
                }
                for (int i = 0; i < monsters.Length; i++)
                {
                    if (monsters[i] != null)
                    {
                        if (monsters[i].Health > 0)
                        {
                            monsters[i].MonsterActions(monsters[i], player1, monsters, false);
                        }
                        if (monsters[i].Health <= 0)
                        {
                            Console.WriteLine(monsters[i].Name + " has been defeated...");
                            monsters[i] = null;
                        }
                    }
                }
                code.RoundEnd(monsters, player1, isDebuggerFight);
            }
            if (player1.Health <= 0)
            {
                Console.WriteLine("you lose");
                return;
            }
            else if (player1.Health > 0)
            {
                LootPhase(player1, monsters, GetRandom(1, 5));
            }
        }
        public void LootPhase(Player player1, Monster[] monsters, int itemLevel)
        {
            #region DeclareLootPhaseVariables
            ItemFactory code = new ItemFactory();
            Item newItem = code.CreateRandomItem(itemLevel);
            MonsterFactory code1 = new MonsterFactory();
            Monster monster1;
            Program code2 = new Program();
            int howManyMoreMonsters = GetRandom(1, 5);
            int playerAnswer = 0;
            #endregion
            int howMuchLoot = GetRandom(0, 3 + player1.level);

            while (howMuchLoot > 0)
            {
                for (int i = 0; i < monsters.Length; i++)
                {
                    if (code2.isFightBossFight == true)
                    {
                        Console.WriteLine("Both Weapon Slots Full!");
                        Grauldogs_Trusty_Club newWeaponForPlayer = new Grauldogs_Trusty_Club("Grauldog's Trusty Club", itemLevel);
                        Console.WriteLine("Do you want to replace a weapon with: " + newWeaponForPlayer + " level " + itemLevel + "?\n");
                        Console.WriteLine("Your weapon(Slot 1): " + player1.EntityWeapon.name + " level " + player1.EntityWeapon.weaponlevel);
                        if (player1.PlayerWeapon2 != null)
                        {
                            Console.WriteLine("Your weapon(Slot 2): " + player1.PlayerWeapon2.name + " level " + player1.PlayerWeapon2.weaponlevel);
                        }
                        Console.WriteLine("1) Yes");
                        Console.WriteLine("2) No");
                        string playerInput = Console.ReadLine();
                        try
                        {
                            playerAnswer = Int32.Parse(playerInput);
                        }
                        catch
                        {
                            LootPhase(player1, monsters, itemLevel);
                        }
                        if (playerAnswer == 1)
                        {
                            Console.WriteLine("Which Slot?");
                            Console.WriteLine("1) Slot 1");
                            Console.WriteLine("2) Slot 2");
                            string playerInput1 = Console.ReadLine();
                            try
                            {
                                playerAnswer = Int32.Parse(playerInput1);
                            }
                            catch
                            {
                                LootPhase(player1, monsters, itemLevel);
                            }
                            if (playerAnswer == 1)
                            {
                                player1.EntityWeapon = newWeaponForPlayer;
                            }
                        }
                        player1.XP += 50;
                    }
                }

                if (newItem.itemType == "Weapon")
                {
                    int weaponLevel = GetRandom(1, 5);
                    Weapon newWeapon = code.CreateRandomWeapon(weaponLevel);
                    if (player1.EntityWeapon == null)
                    {
                        player1.EntityWeapon = newWeapon;
                    }
                    else if (player1.PlayerWeapon2 == null)
                    {
                        player1.PlayerWeapon2 = newWeapon;
                    }
                    else
                        Console.WriteLine("Both Weapon Slots Full!");
                    Console.WriteLine("Do you want to replace a weapon with: " + newWeapon.name + " level " + newWeapon.weaponlevel + "?\n");
                    Console.WriteLine("Your weapon(Slot 1): " + player1.EntityWeapon.name + " level " + player1.EntityWeapon.weaponlevel);
                    if (player1.PlayerWeapon2 != null)
                    {
                        Console.WriteLine("Your weapon(Slot 2): " + player1.PlayerWeapon2.name + " level " + player1.PlayerWeapon2.weaponlevel);
                    }
                    Console.WriteLine("1) Yes");
                    Console.WriteLine("2) No");
                    string playerInput = Console.ReadLine();
                    try
                    {
                        playerAnswer = Int32.Parse(playerInput);
                    }
                    catch
                    {
                        monster1 = code1.CreateRandomMonster();
                        Console.WriteLine("next foe, " + monster1.Name + "!");
                        MonsterIntro(player1, howManyMoreMonsters);
                        Fight(monsters, player1);
                    }
                    if (playerAnswer == 1)
                    {
                        Console.WriteLine("Which Slot?");
                        Console.WriteLine("1) Slot 1");
                        Console.WriteLine("2) Slot 2");
                        string playerInput1 = Console.ReadLine();
                        try
                        {
                            playerAnswer = Int32.Parse(playerInput1);
                        }
                        catch
                        {
                            LootPhase(player1, monsters, itemLevel);
                        }
                        if (playerAnswer == 1)
                        {
                            player1.EntityWeapon = newWeapon;
                        }
                        else
                            player1.PlayerWeapon2 = newWeapon;
                    }
                }

                else if (newItem.itemType == "Armor")
                {
                    Armor newArmor = code.CreateRandomArmor(itemLevel);
                    Console.WriteLine("Armor Slot is full, would you like to replace it with: " + newArmor.name + " Level " + newArmor.gearLevel + "?\n");
                    Console.WriteLine("Your Armor: " + player1.EntityArmor.name + " Level " + player1.EntityArmor.gearLevel);
                    Console.WriteLine("1) Yes");
                    Console.WriteLine("2) No");
                    string playerInput = Console.ReadLine();
                    try
                    {
                        playerAnswer = Int32.Parse(playerInput);
                    }
                    catch
                    {
                        LootPhase(player1, monsters, itemLevel);
                    }
                    if (playerAnswer == 1)
                    {
                        player1.EntityArmor = newArmor;
                    }
                    if (playerAnswer == 2) { }
                }
                howMuchLoot -= 1;
            }
            monster1 = code1.CreateRandomMonster();
            Console.WriteLine("next foe, " + monster1.Name + "!");
            MonsterIntro(player1, howManyMoreMonsters);
            Fight(monsters, player1);
        }

        public void DebuggerFight(Monster[] monsters, int playerHowFast)
        {
            for (int i = 0; i < monsters.Length; i++)
            {
                Render array = new Render();
                array.RenderMonsterStats(monsters[i]);
            }
            int howManyMonsterWent = 0;
            while (monsters.Length - 1 != 0)
            {
                Fight_Rounds code = new Fight_Rounds();
                Player code1 = new Player("", 0, 0, "");
                code.RoundStart(monsters, code1);
                for (int i = 0; i < monsters.Length - 1; i++)
                {
                    if (monsters[i] != null)
                    {
                        if (monsters[i].Health > 0)
                        {
                            monsters[i].MonsterActions(monsters[i], player1, monsters, true);
                            Thread.Sleep(playerHowFast);
                            if (monsters.Length == 0)
                            {
                                Console.WriteLine(monsters[0].Name + " wins!");
                            }
                        }
                        if (monsters[i].Health <= 0)
                        {
                            Console.WriteLine(monsters[i].Name + " has been defeated...");
                            monsters[i] = null;
                        }
                    }
                }
                Console.WriteLine("How many monsters went: " + howManyMonsterWent);
                if (howManyMonsterWent == 1)
                {
                    for (int i = 0; i < monsters.Length; i++)
                    {
                        if (monsters[i] != null)
                        {
                            Console.WriteLine(monsters[i].Name + " wins!");
                            return;
                        }
                    }
                }
                else
                    howManyMonsterWent = 0;
                code.RoundEnd(monsters, player1, isDebuggerFight);
            }
        }
        static int GetRandom(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max);
        }
        public static void ColorWriter(ConsoleColor color, string whatToWrite)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(whatToWrite + "\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
