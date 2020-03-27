using System;

namespace Environments1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to random RPG\n");
            int least = 1;
            int greatest = 1;
            int environment = GetRandom(least, greatest);
            if (environment == 1)
            {
                Console.WriteLine("you find yourself in a peaceful village\n");
                Console.WriteLine("the daily bustle around you is totally normal, you wonder how you got here...\n");
                Console.WriteLine("1 Find and enter the Tavern\n");
                Console.WriteLine("2 Find and enter the Village Lord's Longhouse\n");
                Console.WriteLine("3 Find and enter the General Goods shop\n");
                Console.WriteLine("4 By talking to the person next to you, attempt to find out where you are\n");
                Console.WriteLine("5 See your stats and gear\n");
                PActions();
            }
            if (environment == 2)
            {
                Console.WriteLine("you find yourself in a large jungle\n");
                Console.WriteLine("there is a Jungle Temple in front of you\n");
                Console.WriteLine("1 Attempt to enter");
                Console.WriteLine("2 Look around for any traps");
                Console.WriteLine("3 See your stats and gear");
            }
            if (environment == 3)
            {
                Console.WriteLine("you find yourself in a large jungle\n");
                Console.WriteLine("there is a Jungle Temple in front of you\n");
                Console.WriteLine("1 Attempt to enter");
                Console.WriteLine("2 Look around for any traps");
                Console.WriteLine("3 See your stats and gear");
            }
            if (environment == 4)
            {
                Console.WriteLine("you find yourself in a Blackness\n");
                Console.WriteLine("there is but blackness in front of you\n");
                Console.WriteLine("1 reach out in the blackness for signs of anything");
                Console.WriteLine("2 Look around for any traps");
                Console.WriteLine("3 See your stats and gear");
            }
            if (environment == 5)
            {
                Console.WriteLine("you find yourself standing at the mouth of a large Cave\n");
                Console.WriteLine("there is but a distant light in the cave in front of you\n");
                Console.WriteLine("1 Enter the Cave\n");
                Console.WriteLine("2 Look around for any traps\n");
                Console.WriteLine("3 See your stats and gear\n");
            }
            if (environment == 6)
            {
                Console.WriteLine("you find yourself standing at the mouth of a large Cave\n");
                Console.WriteLine("there is but a distant light in the cave in front of you\n");
                Console.WriteLine("1 Enter the Cave\n");
                Console.WriteLine("2 Look around for any traps\n");
                Console.WriteLine("3 See your stats and gear\n");
            }
            if (environment == 7)
            {
                Console.WriteLine("you find yourself standing at the mouth of a large Cave\n");
                Console.WriteLine("there is but a distant light in the cave in front of you\n");
                Console.WriteLine("1 Enter the Cave\n");
                Console.WriteLine("2 Look around for any traps\n");
                Console.WriteLine("3 See your stats and gear\n");
            }
            if (environment == 8)
            {
                Console.WriteLine("you find yourself in a peaceful village\n");
                Console.WriteLine("the daily bustle around you is totally normal, you wonder how you got here...\n");
                Console.WriteLine("1 Find and enter the Tavern\n");
                Console.WriteLine("2 Find and enter the village Lord's Longhouse\n");
                Console.WriteLine("3 Find and enter the General goods shop\n");
                Console.WriteLine("4 By talking to the person next to you, attempt to find out where you are\n");
                Console.WriteLine("5 See your stats and gear\n");
                PActions();
            }
            if (environment == 9)
            {
                Console.WriteLine("you find yourself in a Large boat sailing the seas\n");
                Console.WriteLine("the swaying makes you nauseated, as does the smell of fish\n");
                Console.WriteLine("1 Find the Captains cabin and enter\n");
                Console.WriteLine("2 enter lower deck\n");
                Console.WriteLine("3 talk to the man next to you to try and find out where you are\n");
                Console.WriteLine("4 See your stats and gear\n");
            }
        }
        static void statsNgear()
        {
            Console.WriteLine("your stats:\n");
            Console.WriteLine("Strength: 3 (+3)(Gear)\n");
            Console.WriteLine("Dodge: 0 (No Modifiers)\n");
            Console.WriteLine("Intellect: 0 (No Modifiers)\n");
            Console.WriteLine("Armor: 5-10\n");
            Console.WriteLine("Weapons: shortsword(), shortbow()\n");
            Console.WriteLine("Gear: worn Leather Armor(+5 Armor)\n");
            Console.WriteLine("you have no items at this time\n");
        }
        static void PActions()
        {

            var pAction = Console.ReadLine();
            switch (pAction)
            {
                case "1":
                    TavernIntro();
                    break;
                //case "2":
                //    Longhouse();
                //    break;
                //case "3":
                //    Gshop();
                //    break;
                //case "4":
                //    Person1();
                //    break;
                case "5":
                    statsNgear();
                    break;
                default:
                    PActions();
                    break;
            }
        }
        static void TavernIntro() 
        {
            Console.WriteLine("Tavern is a small wood building with a few windows here and there, but its nothing special.\n");
            Console.WriteLine("the flimsy wood door creaks as you open it, and all the people on wood chairs surrounding wood tables turn to look at you.\n");
            Console.WriteLine("you get the feeling youre not supposed to be here...\n");
            Console.WriteLine("1 Take a seat at the nearest table\n");
            Console.WriteLine("2 go up to the bar and ask the bartender about the latest rumor\n");
            Console.WriteLine("3 Leave\n");
            Console.WriteLine("4 see your stats and gear\n");
        }
        static void Tavern() 
        {
            var pActions = Console.ReadLine();
            switch (pActions) 
            {
                case "1":
                    Console.WriteLine("you sit down on the rough wooden chair");
                    break;
            }
        }
        static int GetRandom(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max);
        }
    }
}
