using System;

namespace Compendium1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Compendium 1.0");
            UserInput();
        }
        static string UserInput()
        {
            Console.WriteLine("\nCompendium 1.0\n");
            Console.WriteLine("Enter Classes, Races, Enemies, or Commands(/Help) by typing them in\n");
            string UserInfo = Console.ReadLine();
            switch (UserInfo)
            {
                case "bandit":
                    Bandit();
                    break;

                case "goblin":
                    Goblin();
                    break;

                case "ogre":
                    Ogre();
                    break;

                case "/help":
                    CommandsList();
                    break;

                case "/define":
                    Definitions();
                    break;

                case "/basic_stats":
                    Stats();
                    break;

                default:
                    Console.WriteLine("Error\n");
                    UserInput();
                    break;
            }
            return UserInfo;
        }
        static void Stats()
        {
            Console.WriteLine("Player Stats\n");
            Console.WriteLine("Basic Stats:\n");
            Console.WriteLine("Health: 10 + Cons Modifier\n");
            Console.WriteLine("Weapons: Starting weapons vary with your Class\n");
            Console.WriteLine("Traits: Traits vary with your Race\n");
            Console.WriteLine("Dodge: 10 + Dex Modifier\n");
            Console.WriteLine("Strength: 10 + Str Modifier\n");
            Console.WriteLine("Intellect: 10 + SC Modifier\n");
            Console.WriteLine("Initiative: 10 + Dex Modifier\n");
            Console.WriteLine("Level Scale: 1-25\n");
            Console.WriteLine("Classes: Rogue, Mage, Warrior, Cleric(SC), Cleric(str), Mage\n");
            Console.WriteLine("Races: Human, Elf, Dwarf\n\n");
            Console.WriteLine("Enemy Stats\n");
            Console.WriteLine("Basic Stats:\n");
            Console.WriteLine("Health: 10 + Cons Modifier\n");
            Console.WriteLine("Weapons: Starting weapons vary with their Class\n");
            Console.WriteLine("Traits: Traits vary with their Race\n");
            Console.WriteLine("Dodge: 10 + Dex Modifier\n");
            Console.WriteLine("Strength: 10 + Str Modifier\n");
            Console.WriteLine("Intellect: 10 + SC Modifier\n");
            Console.WriteLine("Initiative: 10 + Dex Modifier\n");
            Console.WriteLine("Level Scale: 1-25\n");
            Console.WriteLine("Classes: Rogue, Mage, Warrior\n");
            Console.WriteLine("Races: Goblin, Ogre, Human(Bandit)\n");
            UserInput();
        }
        static void Definitions()
        {
            Console.WriteLine("what would you like to define?\n");
            string define = Console.ReadLine();
            switch (define)
            {
                case "health":
                    Console.WriteLine("Health(HP) is reduced when you take damage. When your health is 0, you die. Max health is increased by gaining levels. When your health is not full, you can\nregain some by using spells or potions\n");
                    Definitions();
                    break;

                case "armor":
                    Console.WriteLine("Your Armor will help take less damage, some gear, potions, and spells will grant armor for you. If your armor is less than the incoming damage, you will\nrecieve damage equal to what your armor could not negate.");
                    break;

                case "exit":
                    UserInput();
                    break;

                default:
                    Definitions();
                    break;
            }
            UserInput();
        }
        static void CommandsList()
        {
            Console.WriteLine("\n/help (Shows Commands List)\n");
            Console.WriteLine("/define (Defines a Keyword for you. Keywords are words with capital letter begginings\n");
            Console.WriteLine("/basic_stats (shows the basic stats of any mob or player)");
            UserInput();
        }
        static void Bandit()
        {
            Console.WriteLine("Bandit stats:\n");
            Console.WriteLine("Health: 15\n");
            Console.WriteLine("Armor: 10(-2)(Mage) 10(-2)(Rogue) 14(+2)(Warrior)");
            Console.WriteLine("Weapons: Bow (10-15 Dmg. 25 ft. range), Shortsword (Melee, 17-20 Dmg), Dagger (Melee, 7-10 x2 Dmg), LongSword(20-23 + 3sl. Dmg(Two Hand), War Axe(20 + 3P Dmg)\nGreatAxe(23-26 + 5P Dmg(Two Hand)))\n");
            Console.WriteLine("Spells: Fireball (10-15 + 3 Fire Dmg), Frostbolt (10-15 + 3 Freeze Dmg), Mend (10-15 Healing + one -Buff removed)\n");
            Console.WriteLine("Traits: Bands(There will always be at least 3 Bandits when you encounter them)\n");
            Console.WriteLine("Dodge: 11 (+1)(Mage) 13 (+3)(Rogue) 9 (-1)(Warrior)\n");
            Console.WriteLine("Strength: 8 (-2)(Mage) 10(Rogue) 12 (+2)(Warrior)\n");
            Console.WriteLine("Intellect: 13 (+3)(Mage) 10(Rogue) 9 (-1)(Warrior)\n");
            Console.WriteLine("Initiative: 10 (+Dodge)\n");
            Console.WriteLine("Level Scale: 1-10\n");
            Console.WriteLine("Classes: Rogue, Warrior, Mage\n");
            UserInput();
        }
        static void Goblin()
        {
            Console.WriteLine("Goblin stats:\n");
            Console.WriteLine("Health: 7\n");
            Console.WriteLine("Armor: 9 -2(Rogue)(-1)(Goblin)\n");
            Console.WriteLine("Weapons: Bow (10-15 Dmg. 25 ft. range), Shortsword (Melee, 17-20 Dmg), Dagger (Melee, 7-10 x2 Dmg)\n");
            Console.WriteLine("Traits: Small/nimble (Dodge increased/Critical Chance increased/Initiative increased) Sly (Grants Ability 'Hey, Fellas') Goblin (Armor decreased)\n");
            Console.WriteLine("Dodge: 13 (+3)\n");
            Console.WriteLine("Strength: 8 (-2)\n");
            Console.WriteLine("Intellect: 10\n");
            Console.WriteLine("Initiative: 10 (+3)\n");
            Console.WriteLine("Level Scale: 1-5\n");
            Console.WriteLine("Classes: Rogue\n");
            UserInput();
        }
        static void Ogre()
        {
            Console.WriteLine("Ogre stats:\n");
            Console.WriteLine("Health: 25 (+15)\n");
            Console.WriteLine("Armor 12(+2)(Warrior)\n");
            Console.WriteLine("Weapons: Large Rock (30-35 (Bludgeoning) Dmg. 15 ft. range), Huge Post (Melee, (Bludgeoning) 35-40 Dmg), Ogre Fists (Melee, (Bludgeoning) 19-22 x2 Dmg)\n");
            Console.WriteLine("Traits: Huge/Tall (Dogde decreased/Initiative decreased/Health increased) Ogre (Strength Increased, Attacks have Bludgeoning, Intellect/Initiative decreased)\nWarrior (Armor/Strength increased)\n");
            Console.WriteLine("Dodge: 8 (-1)(Ogre)(-1)(Huge)\n");
            Console.WriteLine("Strength: 13 (+1)(Ogre)(+2)(Warrior)\n");
            Console.WriteLine("Intellect: 7 (-2)(Ogre)\n");
            Console.WriteLine("Initiative: 7 (-2(Huge)(-1)(Ogre)\n");
            Console.WriteLine("Level Scale: 5-10\n");
            Console.WriteLine("Classes: Warrior\n");
            UserInput();
        }
    }
}
