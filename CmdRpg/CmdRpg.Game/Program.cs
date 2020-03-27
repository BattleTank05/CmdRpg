using System;

namespace Fight1PvG
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Attack simulator 1\n");
			Console.WriteLine("Type in a name for your Character\n");
			var Pname = Console.ReadLine();
			Console.WriteLine("\nprepare to fight, " + Pname + "\n");
			Console.WriteLine("your foe, GOBLIN!!!");
			Console.WriteLine("\nGoblin Health: 10\n");
			Console.WriteLine("Your Health: 10\n");
			PlayerActions();
		}
		static void Gattack2()
		{
			int least1 = 1;
			int greatest1 = 10;
			int dResult = GetRandom(least1, greatest1);
			Console.WriteLine("you gain " + dResult + " block");
			int least = 1;
			int greatest = 12;
			int gAttack1 = GetRandom(least, greatest);
			int least2 = 1;
			int greatest2 = 12;
			int gAttack2 = GetRandom(least2, greatest2);
			int gAttack = gAttack1 + gAttack2 - dResult;
			Console.WriteLine("Goblin damage: " + gAttack);
			int pHealth = 10;
			int eResult = GAttackArray(pHealth, gAttack);
			if (eResult < 1)
			{
				Console.WriteLine("you lose...\n");
			}
			PlayerActions();
		}
		static int GAttackArray(int health, int attack)
		{
			int eResult = health - attack;
			Console.WriteLine("takes " + attack + " damage\n");
			Console.WriteLine("Your Health: " + eResult);
			return eResult;
		}
		static void PlayerActions()
		{
			Console.WriteLine("What would you like to do?\n");
			Console.WriteLine("1 Attack");
			Console.WriteLine("2 Defend");
			string input = Console.ReadLine();
			switch (input)
			{
				case "1":
					Pattack();
					break;
				case "2":
					Gattack2();
					break;
				case "attack":
					Pattack();
					break;
				case "defend":
					Gattack2();
					break;
				default:
					PlayerActions();
					break;
			}
		}
		static void Pattack()
		{
			int least = 1;
			int greatest = 5;
			int pAttack0 = GetRandom(least, greatest);
			int pAttack1 = GetRandom(least, greatest);
			int pAttack2 = GetRandom(least, greatest);
			int pAttack = pAttack0 + pAttack1 + pAttack2;
			int gHealth = 7 - pAttack;
			Console.WriteLine("\nyou strike a deadly slice with your blade three times\n");
			Console.WriteLine("\nyou deal " + pAttack0 + " damage\n");
			Console.WriteLine("you deal " + pAttack1 + " damage\n");
			Console.WriteLine("you deal " + pAttack2 + " damage\n");
			Console.WriteLine("Goblin takes " + pAttack + " damage\n");
			Console.WriteLine("Goblin Health:" + gHealth);
			if (gHealth <= 0)
			{
				Console.WriteLine("you win\n");
				OgreIntro();
			}
			if (gHealth >= 0)
			{
				Gattack();
			}
		}
		static void Gattack()
		{
			int least1 = 1;
			int greatest1 = 12;
			int gAttack1 = GetRandom(least1, greatest1);
			int least = 1;
			int greatest = 12;
			int gAttack2 = GetRandom(least, greatest);
			int gAttack = gAttack1 + gAttack2;
			Console.WriteLine("Goblin damage: " + gAttack);
			int pHealth = 10;
			int eResult = pHealth - gAttack;
			Console.WriteLine("takes " + gAttack + " damage\n");
			Console.WriteLine("Your Health: " + eResult);
			if (eResult < 1)
			{
				Console.WriteLine("you lose...\n");
			}
			PlayerActions();
		}

		static int GetRandom(int min, int max)
		{
			Random r = new Random();
			return r.Next(min, max);
		}
		static void OgreIntro()
		{
			Console.WriteLine("\nyour next foe...\n");
			Console.WriteLine("OGRE!!!\n");
			Console.WriteLine("Ogre Health: 15\n");
			Console.WriteLine("your Health: 13");
			PlayerActions2();
		}
		static void PlayerActions2()
		{
			string input = Console.ReadLine();
			Console.WriteLine("What would you like to do?\n");
			Console.WriteLine("1 Attack");
			Console.WriteLine("2 Defend");
			switch (input)
			{
				case "1":
					Pattack2();
					break;
				case "2":
					Oattack2();
					break;
				case "attack":
					Pattack2();
					break;
				case "defend":
					Oattack2();
					break;
				default:
					PlayerActions2();
					break;
			}
		}
		static void Pattack2()
		{
			int least = 1;
			int greatest = 10;
			int pAttack0 = GetRandom(least, greatest);
			int pAttack1 = GetRandom(least, greatest);
			int pAttack2 = GetRandom(least, greatest);
			int pAttack = pAttack0 + pAttack1 + pAttack2;
			int oHealth = 15 - pAttack;
			Console.WriteLine("\nyou strike a deadly slice with your blade three times\n");
			Console.WriteLine("\nyou deal " + pAttack0 + " damage\n");
			Console.WriteLine("you deal " + pAttack1 + " damage\n");
			Console.WriteLine("you deal " + pAttack2 + " damage\n");
			Console.WriteLine("Ogre takes " + pAttack + " damage\n");
			Console.WriteLine("Ogre Health:" + oHealth);
			if (oHealth <= 0)
			{
				Console.WriteLine("you win\n");
			}
			if (oHealth > 0)
			{
				Oattack();
			}
		}
		static void Oattack()
		{
			int least = 1;
			int greatest = 15;
			int pHealth = 13;
			int oAttack1 = GetRandom(least, greatest);
			int oAttack2 = GetRandom(least, greatest);
			int oAttack = oAttack1 + oAttack2;
			Console.WriteLine("Ogre damage " + oAttack);
			int eResult = pHealth - oAttack;
			Console.WriteLine("you take " + oAttack + " damage\n");
			Console.WriteLine("Your Health: " + eResult);
			if (pHealth < 1)
			{
				Console.WriteLine("you lose...\n");
			}
			PlayerActions2();
		}
		static void Oattack2()
		{
			int least1 = 1;
			int greatest1 = 15;
			int dResult1 = GetRandom(least1, greatest1);
			Console.WriteLine("you gain " + dResult1 + " block\n");
			int least = 1;
			int greatest = 15;
			int pHealth = 13;
			int oAttack1 = GetRandom(least, greatest);
			int oAttack2 = GetRandom(least, greatest);
			int oAttack = oAttack1 + oAttack2 - dResult1;
			Console.WriteLine("Ogre damage: " + oAttack);
			int eResult = pHealth - oAttack;
			Console.WriteLine("you take " + oAttack + " damage\n");
			Console.WriteLine("Your Health: " + eResult);
			if (pHealth < 1)
			{
				Console.WriteLine("you lose...\n");
			}
			PlayerActions2();
		}
	}
}
