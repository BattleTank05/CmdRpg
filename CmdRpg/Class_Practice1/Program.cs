using System;

namespace Class_Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player2 = new Player("");
            Program code = new Program();
            code.Environment();
        }
        public void Environment() 
        {
            int least = 1;
            int greatest = 1;
            int environment = GetRandom(least, greatest);
            switch (environment) 
            {
                case 1:
                    Gladiator();
                    break;
                case 2:
                    //Raid();
                    break;
            }
        }
        static void Gladiator() 
        {
            Console.WriteLine("type a name for your Character");
            string PlayerName = Console.ReadLine();
            Player player1 = new Player(PlayerName);
            player1.Health += 10;
            player1.Block += 2;
            player1.Parry += 1;
            player1.Strength += 2;
            player1.Dodge += 1;
            player1.Intellect += 1;
            Console.WriteLine("Your Health: " + player1.Health);
            Console.WriteLine("Your Armor: " + player1.Block);
            Console.WriteLine("Your Strength: " + player1.Strength);
            Console.WriteLine("Your Dodge: " + player1.Dodge);
            Console.WriteLine("Your Intellect: " + player1.Intellect + "\n");
            Console.WriteLine("Choose a weapon: ");
            Console.WriteLine("1) Broadsword");
            Console.WriteLine("2) Mace");
            Console.WriteLine("3) Twin Daggers");
            Console.WriteLine("4) War Axe\n");
            string info = Console.ReadLine();
            try
            {
                player1.Weapon = Int32.Parse(info);
            }
            catch
            {
                Console.WriteLine("Creation Error... Shutting...Down....");
                Program code = new Program();
                code.Environment();
            }
            switch (player1.Weapon)
            {
                case 1:
                    player1.MaxDamage += 2;
                    player1.MinDamage += 2;
                    player1.AttackAmount += 1;
                    Console.WriteLine("Broadsword it is...");
                    break;
                case 2:
                    player1.MaxDamage += 3;
                    player1.MinDamage += 3;
                    Console.WriteLine("Mace it is...");
                    break;
                case 3:
                    player1.MaxDamage -= 5;
                    player1.MinDamage -= 5;
                    player1.AttackAmount += 3;
                    Console.WriteLine("Twin Daggers it is...");
                    break;
                case 4:
                    player1.MaxDamage += 5;
                    player1.MinDamage += 5;
                    Console.WriteLine("War Axe it is...");
                    break;
                default:
                    Console.WriteLine("Creation Error... Shutting...Down....");
                    Program code = new Program();
                    code.Environment();
                    break;
            }
            Console.WriteLine("Choose a set of gear:");
            Console.WriteLine("1) Chainmail(Warrior)");
            Console.WriteLine("2) Thick Leather(Rogue)");
            Console.WriteLine("3) Rough Sinews interlinked with Bone(Primitive)\n");
            string info1 = Console.ReadLine();
            try
            {
                player1.Gear = Int32.Parse(info1);
            }
            catch
            {
                Console.WriteLine("Creation Error... Restarting...");
                Program code = new Program();
                code.Environment();
            }
            switch (player1.Gear)
            {
                case 1:
                    player1.Gear += 5;
                    Console.WriteLine("Warrior it is...");
                    break;
                case 2:
                    player1.Gear += 3;
                    Console.WriteLine("Rogue it is...");
                    break;
                case 3:
                    player1.Gear = 0;
                    Console.WriteLine("Mage it is...");
                    break;
                default:
                    Console.WriteLine("Creation Error... Restarting...");
                    Program code = new Program();
                    code.Environment();
                    break;
            }
            Console.WriteLine(player1.PlayerName + "'s stats: ");
            Console.WriteLine("Your Health: " + player1.Health);
            Console.WriteLine("Your Armor: " + player1.Block);
            Console.WriteLine("Your Parry: " + player1.Parry);
            Console.WriteLine("Gear Armor: " + player1.Gear);
            Console.WriteLine("Your Strength: " + player1.Strength);
            Console.WriteLine("Your Dodge: " + player1.Dodge);
            Console.WriteLine("Your Intellect: " + player1.Intellect);
            Console.WriteLine("Amount of times you can attack: " + player1.AttackAmount);
            Console.WriteLine("Weapon damage(Min): " + player1.MinDamage);
            Console.WriteLine("Weapon damage(Max): " + player1.MaxDamage + "\n");
            Console.WriteLine("ready yourself, Gladiator...\n");
            Console.WriteLine("your first foe, the Troll!\n");
            Monster Troll = new Monster();
            Troll.Health += 15;
            Troll.Armor += 2;
            Troll.Parry += 1;
            Troll.Strength += 2;
            Troll.Dodge += 0;
            Troll.Intellect += 0;
            Troll.AttackAmount += 0;
            Console.WriteLine("Troll Health: " + Troll.Health);
            Console.WriteLine("Troll Armor: " + Troll.Armor);
            Console.WriteLine("Troll Parry: " + Troll.Parry);
            Console.WriteLine("Troll Strength: " + Troll.Strength);
            Console.WriteLine("Troll Dodge: " + Troll.Dodge);
            Console.WriteLine("Troll Intellect: " + Troll.Intellect);
            Console.WriteLine("Amount of times Troll can attack: " + Troll.AttackAmount);
            Console.WriteLine("Troll Damage(Min): " + Troll.MinDamage);
            Console.WriteLine("Troll Damage(Max): " + Troll.MaxDamage + "\n");
            PlayerActions(player1.Health, player1.MinDamage, player1.MaxDamage, player1.Strength, player1.Block, player1.Parry, player1.AttackAmount, Troll.Health, Troll.MinDamage, Troll.MaxDamage, Troll.Strength, Troll.Armor, Troll.Parry, Troll.AttackAmount);
        }
        static void PlayerActions(int PlayerHealth, int PlayerMinDamage, int PlayerMaxDamage, int PlayerStrength, int PlayerBlock, int PlayerParry, int PlayerAttackAmount, int TrollHealth, int TrollMinDamage, int TrollMaxDamage, int TrollStrength, int TrollArmor, int TrollParry, int TrollAttackAmount) 
        {
            Player player2 = new Player("");
            Console.WriteLine("What would you like to do?\n");
            Console.WriteLine("1) Attack");
            Console.WriteLine("2) Defend");
            Console.WriteLine("3) Parry");
            Console.WriteLine("4) Heal and defend");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    int Trollhealth = player2.PlayerAttack(TrollHealth, TrollArmor, TrollParry, PlayerMinDamage, PlayerMaxDamage, PlayerStrength, PlayerAttackAmount);
                    break;
                case "2":
                    PlayerBlock = player2.Player_Defend(PlayerBlock);
                    break;
                case "attack":
                    Trollhealth = player2.PlayerAttack(TrollHealth, TrollArmor, TrollParry, PlayerMinDamage, PlayerMaxDamage, PlayerStrength, PlayerAttackAmount);
                    break;
                case "defend":
                    PlayerBlock = player2.Player_Defend(PlayerBlock);
                    break;
                case "3":
                    PlayerParry = player2.Player_Parry(PlayerParry, PlayerBlock);
                    break;
                case "parry":
                    PlayerParry = player2.Player_Parry(PlayerParry, PlayerBlock);
                    break;
                case "4":
                    PlayerHealth = player2.Player_Heal(PlayerHealth, PlayerBlock);
                    break;
                case "heal":
                    PlayerHealth = player2.Player_Heal(PlayerHealth, PlayerBlock);
                    break;
                default:
                    PlayerActions(PlayerHealth, PlayerMinDamage, PlayerMaxDamage, PlayerStrength, PlayerBlock, PlayerParry, PlayerAttackAmount, TrollHealth, TrollMinDamage, TrollMaxDamage, TrollStrength, TrollArmor, TrollParry, TrollAttackAmount);
                    break;
            }
            TrollActions(PlayerHealth, PlayerMinDamage, PlayerMaxDamage, PlayerStrength, PlayerBlock, PlayerParry, PlayerAttackAmount, TrollHealth, TrollMinDamage, TrollMaxDamage, TrollStrength, TrollArmor, TrollParry, TrollAttackAmount);
        }
        static void TrollActions(int PlayerHealth, int PlayerMinDamage, int PlayerMaxDamage, int PlayerStrength, int PlayerBlock, int PlayerParry, int PlayerAttackAmount, int TrollHealth, int TrollMinDamage, int TrollMaxDamage, int TrollStrength, int TrollArmor, int TrollParry, int TrollAttackAmount)
        {
            Monster start = new Monster();
            int least = 1;
            int greatest = 4;
            int TrollAction = GetRandom(least, greatest);
            switch (TrollAction)
            {
                case 1:
                    PlayerHealth = start.TrollAttack(PlayerHealth, PlayerBlock, PlayerParry, TrollMinDamage, TrollMaxDamage, TrollStrength, TrollAttackAmount);
                    break;
                case 2:
                    TrollArmor = start.Troll_Defend(TrollArmor);
                    break;
                case 3:
                    TrollParry = start.Troll_Parry(TrollParry, TrollArmor);
                    break;
                case 4:
                    TrollHealth = start.Troll_Heal(TrollHealth, TrollArmor);
                    break;
            }
            PlayerActions(PlayerHealth, PlayerMinDamage, PlayerMaxDamage, PlayerStrength, PlayerBlock, PlayerParry, PlayerAttackAmount, TrollHealth, TrollMinDamage, TrollMaxDamage, TrollStrength, TrollArmor, TrollParry, TrollAttackAmount);
        }
        static int GetRandom(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max);
        }
    }
}
