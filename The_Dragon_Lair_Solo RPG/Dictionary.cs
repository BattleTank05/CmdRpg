using System;

namespace The_Dragon_Lair_SoloRPG
{
    class Dictionary
    {
        public static void StartUp()
        {
            Console.WriteLine("Welcome to Compendium 1.0");
            UserInput();
        }
        static void UserInput()
        {
            Console.WriteLine("\nCompendium 1.0\n");
            Console.WriteLine("Enter Classes, Races, Enemies, or Commands(/Help) by typing them in\n");
            string UserInfo = Console.ReadLine();
            switch (UserInfo)
            {
                case "mage":
                    Mage();
                    break;
                case "warrior":
                    Warrior();
                    break;
                case "troll":
                    Troll();
                    break;
                case "rogue":
                    Rogue();
                    break;
                case "thief":
                    Thief();
                    break;
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
                case "/exit":
                    Program.PlayerChooseGameMode();
                    break;
                default:
                    Console.WriteLine("Error\n");
                    UserInput();
                    break;
            }
            return;
        }
        static void Mage() 
        {
            Console.WriteLine("Mages are known for their intelligence, they are smart and very wise about their ways. They specialize in the Intellect Modifier, crushing you with pure arcane force.");
            Console.WriteLine("Their spells will rend you with fire and ice, with a touch of healing?");
            Console.WriteLine("Note: when you see your opponents class and there is a '*' after it, that means they have mastered the class and get extra buffs\n");
            UserInput();
        }
        static void Warrior() 
        {
            Console.WriteLine("Warriors are not known for their intelligence, but they are tough and hard to kill. They specialize in the Strength Modifier, crushing you with pure force.");
            Console.WriteLine("Their swords and fists will rend you to dust if you are not careful, so stay back!");
            Console.WriteLine("Note: when you see your opponents class and there is a '*' after it, that means they have mastered the class and get extra buffs\n");
            UserInput();
        }
        static void Troll() 
        {
            Console.WriteLine("Troll stats:\n");
            Console.WriteLine("Health: 15 (+15)(Ogre)(Huge)\n");
            Console.WriteLine("Armor 13(+2)(Warrior)(+1)(Thick)\n");
            Console.WriteLine("Weapons: Fist Pummel (10-15 x3 Dmg.), Troll Smash (Airborne, (Bludgeoning) 35-40 Dmg.), Chomp (Melee, (Piercing, Bleeding) 15-20 Dmg.)\n");
            Console.WriteLine("Traits: Thick/Burly (Strength/Constitution increased) Troll (Strength/Constitution Increased, resistant to poison)\nWarrior (Armor/Strength increased)\n");
            Console.WriteLine("Dodge: 0 (no modifiers)\n");
            Console.WriteLine("Constitution: 10(+5)(Troll)(+5)(Thick)");
            Console.WriteLine("Strength: 3 (+1)(Burly)(+2)(Warrior)\n");
            Console.WriteLine("Intellect: 0 (no modifiers)\n");
            Console.WriteLine("Initiative: 0\n");
            Console.WriteLine("Level Scale: 1-15\n");
            Console.WriteLine("Classes: Warrior\n");
            UserInput();
        }
        static void Rogue() 
        {
            Console.WriteLine("Rogues are fast, sly, very slippery and hard to hit. They specialize in the Dodge Modifier, and they are very stealthy about their buisness.");
            Console.WriteLine("They can easily catch you by surprise, so be careful!");
            Console.WriteLine("Note: when you see your opponents class and there is a '*' after it, that means they have mastered the class and get extra buffs\n");
            UserInput();
        }
        static void Stats()
        {
            Console.WriteLine("Basic Stats");
            Console.WriteLine("Player Stats:");
            Console.WriteLine("Health: 10 + Cons Modifier");
            Console.WriteLine("Armor: 12 + Gear Modifier");
            Console.WriteLine("Weapons: Starting weapons vary with your Class");
            Console.WriteLine("Traits: Traits vary with your Race");
            Console.WriteLine("Dodge: 1 + Dex Modifier");
            Console.WriteLine("Strength: 1 + Str Modifier");
            Console.WriteLine("Intellect: 1 + SC Modifier");
            Console.WriteLine("Initiative: 1 + Dex Modifier");
            Console.WriteLine("Level Scale: 1-25");
            Console.WriteLine("Classes: Rogue, Mage, Warrior, Cleric(SC), Cleric(str), Mage");
            Console.WriteLine("Races: Human, Elf, Dwarf\n");
            Console.WriteLine("Enemy Stats\n");
            Console.WriteLine("Basic Stats:");
            Console.WriteLine("Health: 10 + Cons Modifier");
            Console.WriteLine("Armor: 10 + Gear Modifier");
            Console.WriteLine("Weapons: Starting weapons vary with their Class");
            Console.WriteLine("Traits: Traits vary with their Race");
            Console.WriteLine("Dodge: 1 + Dex Modifier");
            Console.WriteLine("Strength: 1 + Str Modifier");
            Console.WriteLine("Intellect: 1 + SC Modifier");
            Console.WriteLine("Initiative: 1 + Dex Modifier");
            Console.WriteLine("Level Scale: 1-25");
            Console.WriteLine("Classes: Rogue, Mage, Warrior");
            Console.WriteLine("Races: Goblin, Ogre, Human(Bandit)\n");
            UserInput();
        }
        static void Definitions()
        {
            Console.WriteLine("what would you like to define?\n");
            string define = Console.ReadLine();
            switch (define)
            {
                case "trait":
                    Console.WriteLine("traits are positive/negative modifiers for your modifiers(arm, dex, str, int)\n");
                    Definitions();
                    break;
                case "armor":
                    Console.WriteLine("Armor is applied when taking damage. you gain Armor each turn according to that of your gear. If you dont 'defend' to gain block and take damage directly to your");
                    Console.WriteLine("gear, your gear will give less armor per turn equal to the damage you take halved(always rounding down). Certain spells and potions sill grant temporary Armor");
                    Console.WriteLine("to have your damaged gear give you full armor again, you must either buy better gear, or repair your current gear.\n");
                    Definitions();
                    break;
                case "intellect":
                    Console.WriteLine("Intellect is the modifier applied to Spellcasting, discerning things, being brilliant, Etc. Intellect is the most powerful of the modifiers, but cannot work without");
                    Console.WriteLine("the other modifiers\n");
                    Definitions();
                    break;
                case "dodge":
                    Console.WriteLine("Dodge is the Modifier applied to you when you are trying to avoid something, like arrows, swords, Etc. Dodge has a chance to negate all or half of incoming damage");
                    Console.WriteLine("Dodge will go away at the start of your turn\n");
                    Definitions();
                    break;
                case "strength":
                    Console.WriteLine("Strength is the Modifier applied when attacking, lifting, Moving, Etc. the more strength you have, the more damage/things you can do!\n");
                    Definitions();
                    break;
                case "health":
                    Console.WriteLine("Health(HP) is reduced when you take damage. When your health is 0, you die. Max health is increased by gaining levels. When your health is not full, you can\nregain some by using spells or potions\n");
                    Definitions();
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
        static void Thief() 
        {
            Console.WriteLine("Thief stats:\n");
            Console.WriteLine("Health: 10");
            Console.WriteLine("Armor: 8 -2(Rogue)");
            Console.WriteLine("Weapons: ShortBow (10-15 Dmg. 20 ft. range), Shortsword (Melee, 17-20 Dmg), Dagger x2 (Melee, 7-10 x2 Dmg)");
            Console.WriteLine("Traits: Adept Rogue (Dodge/Critical Chance/Initiative/Strength/Constitution/intellect increased)");
            Console.WriteLine("Dodge: 3 (+2)(Rogue*)(+1)(Human)");
            Console.WriteLine("Constitution: 1 (+1)(Rogue*)");
            Console.WriteLine("Strength: 2 (+2)(Rogue*)");
            Console.WriteLine("Intellect: 1 (+1)(Rogue*)");
            Console.WriteLine("Initiative: 0 (+2)(Rogue*)");
            Console.WriteLine("Level Scale: 5-15");
            Console.WriteLine("Classes: Rogue");
            UserInput();
        }
        static void Bandit()
        {
            Console.WriteLine("Bandit stats:\n");
            Console.WriteLine("Health: 15\n");
            Console.WriteLine("Armor: 8(-2)(Mage) 8(-2)(Rogue) 12(+2)(Warrior)");
            Console.WriteLine("Weapons: Bow (10-15 Dmg. 25 ft. range), Shortsword (Melee, 17-20 Dmg), Dagger (Melee, 7-10 x2 Dmg), LongSword(20-23 + 3sl. Dmg(Two Hand), War Axe(20 + 3P Dmg)\nGreatAxe(23-26 + 5P Dmg(Two Hand)))\n");
            Console.WriteLine("Spells: Fireball (10-15 + 3 Fire Dmg), Frostbolt (10-15 + 3 Freeze Dmg), Mend (10-15 Healing + one -Buff removed)\n");
            Console.WriteLine("Traits: Bands(There will always be at least 3 Bandits when you encounter them)\n");
            Console.WriteLine("Dodge: 1 (+1)(Mage) 3 (+3)(Rogue) -1 (-1)(Warrior)\n");
            Console.WriteLine("Constitution:");
            Console.WriteLine("Strength: -2 (-2)(Mage) 0 (Rogue) 2 (+2)(Warrior)\n");
            Console.WriteLine("Intellect: 3 (+3)(Mage) 0 (Rogue) -1 (-1)(Warrior)\n");
            Console.WriteLine("Initiative: 0 (+Dodge)\n");
            Console.WriteLine("Level Scale: 1-10\n");
            Console.WriteLine("Classes: Mage, Rogue, Warrior\n");
            UserInput();
        }
        static void Goblin()
        {
            Console.WriteLine("Goblin stats:\n");
            Console.WriteLine("Health: 7\n");
            Console.WriteLine("Armor: 7 -2(Rogue)(-1)(Goblin)\n");
            Console.WriteLine("Weapons: Bow (10-15 Dmg. 25 ft. range), Shortsword (Melee, 17-20 Dmg), Dagger (Melee, 7-10 x2 Dmg)\n");
            Console.WriteLine("Traits: Small/nimble (Dodge/Critical Chance/Initiative increased, Strength decreased), Goblin (Armor/Constitution decreased)\n");
            Console.WriteLine("Dodge: 3 (+2)(Small)(+1)(Rogue)\n");
            Console.WriteLine("Constitution: -3 (-3)(Goblin)");
            Console.WriteLine("Strength: -1 (-1)(Small)(+1)(Rogue)\n");
            Console.WriteLine("Intellect: 0\n");
            Console.WriteLine("Initiative: 0 (+1)(Rogue)(+2)(Small)\n");
            Console.WriteLine("Level Scale: 1-5\n");
            Console.WriteLine("Classes: Rogue\n");
            UserInput();
        }
        static void Ogre()
        {
            Console.WriteLine("Ogre stats:\n");
            Console.WriteLine("Health: 25 (+15)(Ogre)(Huge)\n");
            Console.WriteLine("Armor 12(+2)(Warrior)\n");
            Console.WriteLine("Weapons: Large Rock (30-35 (Bludgeoning) Dmg. 15 ft. range), Huge Post (Melee, (Bludgeoning) 35-40 Dmg), Ogre Fists (Melee, (Bludgeoning) 19-22 x2 Dmg)\n");
            Console.WriteLine("Traits: Huge/Tall (Dogde decreased/Initiative decreased/Constitution increased) Ogre (Strength Increased, Attacks have Bludgeoning, Intellect/Initiative decreased)\nWarrior (Armor/Strength increased)\n");
            Console.WriteLine("Dodge: 8 (-1)(Ogre)(-1)(Huge)\n");
            Console.WriteLine("Constitution: 15(+5)(Ogre)(+10)(Huge)");
            Console.WriteLine("Strength: 3 (+1)(Ogre)(+2)(Warrior)\n");
            Console.WriteLine("Intellect: -3 (-2)(Ogre)\n");
            Console.WriteLine("Initiative: -3 (-2(Huge)(-1)(Ogre)\n");
            Console.WriteLine("Level Scale: 5-15\n");
            Console.WriteLine("Classes: Warrior\n");
            UserInput();
        }
    }
}
