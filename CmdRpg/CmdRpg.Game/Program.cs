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
			Console.WriteLine("\nGoblin Health: 70\n");
			Console.WriteLine("Your Health: 100\n");
			PlayerActions();
		}
		//static int Phealth(int attack, int attack2)
		//{
		//	return pHealth;
		//}
		static int gAttackArray(int health, int attack)
		{
			int eResult = health - attack;
			Console.WriteLine("\nGoblin attacks twice, his blade going up and you being to slow to dodge it...\n");
			Console.WriteLine("takes " + attack + " damage\n");
			Console.WriteLine("Your Health: " + eResult);
			return eResult;
		}
		static void PlayerActions()
		{
			string input = Console.ReadLine();
			Console.WriteLine("What would you like to do?\n");
			Console.WriteLine("1 Attack");
			Console.WriteLine("2 Defend");
			switch (input)
			{
				case "1":
					Pattack();
					break;
				case "2":
					Pdefend();
					break;
				case "attack":
					Pattack();
					break;
				case "defend":
					Pdefend();
					break;
				default:
					PlayerActions();
					break;
			}
		}
		static void Pattack()
		{
			int least = 1;
			int greatest = 7;
			int pAttack0 = GetRandom(least, greatest);
			int pAttack1 = GetRandom(least, greatest);
			int pAttack2 = GetRandom(least, greatest);
			int pAttack = pAttack0 + pAttack1 + pAttack2;
			int gHealth = 70 - pAttack;
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
		static int Pdefend()
		{
			int dResult = 0;
			return dResult;
		}
		static void Gattack()
		{
			int least = 1;
			int greatest = 12;

			int gAttack = GetRandom(least, greatest);
			int gAttack2 = GetRandom(least, greatest);
			Console.WriteLine(gAttack2);
			int pHealth = 100;
			int eResult = gAttackArray(pHealth, gAttack);
			Console.WriteLine(eResult);
			if (pHealth <= 0)
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
			Console.WriteLine("Ogre Health: 150\n");
			Console.WriteLine("your Health: 125");
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
					//Pdefend2();
					break;
				case "attack":
					Pattack2();
					break;
				case "defend":
					//Pdefend2();
					break;
				default:
					PlayerActions2();
					break;
			}
		}
		static void Pattack2()
		{
			int least = 7;
			int greatest = 10;
			int pAttack0 = GetRandom(least, greatest);
			int pAttack1 = GetRandom(least, greatest);
			int pAttack2 = GetRandom(least, greatest);
			int pAttack = pAttack0 + pAttack1 + pAttack2;
			int oHealth = 150 - pAttack;
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
			int greatest = 85;
			int pHealth = 125;
			int oAttack = GetRandom(least, greatest);
			int oAttack2 = GetRandom(least, greatest);
			int eResult = OAttackArray(pHealth, oAttack);
			if (pHealth <= 0)
			{
				Console.WriteLine("you lose...\n");
			}
			PlayerActions2();
		}
		static int OAttackArray(int health, int attack)
		{
			int eResult = health - attack;
			Console.WriteLine("\nOgre attacks twice, his Fence Post going Down on your head and you being to slow to dodge it...\n");
			Console.WriteLine("you take " + attack + " damage\n");
			Console.WriteLine("Your Health: " + eResult);
			return eResult;
		}
	}
}
