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
		static void Pattack3()
		{
			int least = 1;
			int greatest = 7;
			int pAttack0 = GetRandom(least, greatest);
			int pAttack1 = GetRandom(least, greatest);
			int pAttack2 = GetRandom(least, greatest);
			int least1 = 1;
			int greatest1 = 10;
			int gdefend = GetRandom(least1, greatest1);
			int pAttack = pAttack0 + pAttack1 + pAttack2 - gdefend;
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
		static void Gattack2()
		{
			int least2 = 1;
			int greatest2 = 2;
			int dType = GetRandom(least2, greatest2);
			int least1 = 1;
			int greatest1 = 10;
			int dResult = GetRandom(least1, greatest1);
			Console.WriteLine("you gain " + dResult + " block");
			if (dType == 2) 
			{
				Console.WriteLine("Goblin attacks and just misses you...\n");
				PlayerActions();
			}
			if (dType == 1)
			{
				int least = 1;
				int greatest = 12;
				int gAttack1 = GetRandom(least, greatest);
				Console.WriteLine("Goblin damage: " + gAttack1);
				int gAttack = gAttack1 - dResult;
				int pHealth = 100;
				int eResult = gAttackArray(pHealth, gAttack);
				Console.WriteLine(eResult);
				if (eResult <= 0)
				{
					Console.WriteLine("you lose...\n");
				}
				if (eResult > 0)
				{
					pHealth = eResult;
				}
				PlayerActions();
			}
		}
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
		static void Gattack()
		{
			int least1 = 1;
			int greatest1 = 3;
			int gAttack = GetRandom(least1, greatest1);
			if (gAttack == 3)
			{
				Pattack3();
			}
			if (gAttack == 1)
			{
				Console.WriteLine("Goblin attacks and just misses you...\n");
				PlayerActions();
			}
			if (gAttack == 2)
			{
				int least = 1;
				int greatest = 12;
				int gAttack2 = GetRandom(least, greatest);
				Console.WriteLine(gAttack2);
				int pHealth = 100;
				int eResult = gAttackArray(pHealth, gAttack);
				Console.WriteLine(eResult);
				if (eResult <= 0)
				{
					Console.WriteLine("you lose...\n");
				}
				if (eResult > 0)
				{
					pHealth = eResult;
				}
				PlayerActions();
			}
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
