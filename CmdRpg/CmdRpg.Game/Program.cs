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
			int pHealth = 25;
			int gHealth = 15;
			int oHealth = 20;
			Console.WriteLine("\nGoblin Health: " +gHealth);
			Console.WriteLine("Your Health: " + pHealth);
			PlayerActions(pHealth, gHealth, oHealth);
		}
		static void Gattack2(int pHealth, int gHealth, int oHealth)
		{
			int least1 = 1;
			int greatest1 = 14;
			int dResult = GetRandom(least1, greatest1);
			Console.WriteLine("you gain " + dResult + " block");
			int least = 1;
			int greatest = 7;
			int gAttack1 = GetRandom(least, greatest);
			int least2 = 1;
			int greatest2 = 7;
			int gAttack2 = GetRandom(least2, greatest2);
			int gAttack = gAttack1 + gAttack2 - dResult;
			Console.WriteLine("Goblin damage: " + gAttack);
			int pHealth1 = pHealth - gAttack;
			Console.WriteLine("takes " + gAttack + " damage\n");
			Console.WriteLine("Your Health: " + pHealth1);
			if (pHealth1 < 1)
			{
				Console.WriteLine("you lose...\n");
			}
			PlayerActions(pHealth1, gHealth, oHealth);
		}
		static void PlayerActions(int pHealth, int gHealth, int oHealth)
		{
			Console.WriteLine("What would you like to do?\n");
			Console.WriteLine("1 Attack");
			Console.WriteLine("2 Defend");
			Console.WriteLine("3 Parry");
			string input = Console.ReadLine();
			switch (input)
			{
				case "1":
					Pattack(gHealth, pHealth, oHealth);
					break;
				case "2":
					Gattack2(pHealth, gHealth, oHealth);
					break;
				case "attack":
					Pattack(gHealth, pHealth, oHealth);
					break;
				case "defend":
					Gattack2(pHealth, gHealth, oHealth);
					break;
				case "3":
					Gattack3(pHealth, gHealth, oHealth);
					break;
				case "parry":
					Gattack3(pHealth, gHealth, oHealth);
					break;
				default:
					PlayerActions(pHealth, gHealth, oHealth);
					break;
			}
		}
		static void Gattack3(int pHealth, int gHealth, int oHealth) 
		{
			int least1 = 1;
			int greatest1 = 7;
			int pResult = GetRandom(least1, greatest1);
			Console.WriteLine("you gain " + pResult + " Parry");
			int least = 1;
			int greatest = 7;
			int gAttack1 = GetRandom(least, greatest);
			if (gAttack1 <= pResult) 
			{
				Console.WriteLine("you successfully parry!");
				gAttack1 = 0;
				int least3 = 1;
				int greatest3 = 7;
				int gAttack3 = GetRandom(least3, greatest3);
				if (gAttack3 <= pResult) 
				{
					Console.WriteLine("you successfully parry");
					Pattack3(pHealth, gHealth, oHealth);
				}
				int gAttack4 = gAttack1 + gAttack3;
				Console.WriteLine("Goblin damage: " + gAttack4);
				int pHealth3 = pHealth - gAttack4;
				Console.WriteLine("you take " + gAttack4 + " damage\n");
				Console.WriteLine("Your Health: " + pHealth3);
				if (pHealth3 < 1)
				{
					Console.WriteLine("you lose...\n");
				}
				PlayerActions(pHealth3, gHealth, oHealth);
			}
			int least2 = 1;
			int greatest2 = 7;
			int gAttack2 = GetRandom(least2, greatest2);
			int gAttack = gAttack1 + gAttack2;
			Console.WriteLine("Goblin damage: " + gAttack);
			int pHealth1 = pHealth - gAttack;
			Console.WriteLine("takes " + gAttack + " damage\n");
			Console.WriteLine("Your Health: " + pHealth1);
			if (pHealth1 < 1)
			{
				Console.WriteLine("you lose...\n");
			}
			PlayerActions(pHealth1, gHealth, oHealth);
		}
		static void Pattack4(int pHealth, int oHealth) 
		{
			int least = 1;
			int greatest = 10;
			int pAttack0 = GetRandom(least, greatest);
			int pAttack1 = GetRandom(least, greatest);
			int pAttack2 = GetRandom(least, greatest);
			int pAttack = pAttack0 + pAttack1 + pAttack2;
			int oHealth1 = oHealth - pAttack;
			Console.WriteLine("\nyou strike a deadly slice with your blade three times\n");
			Console.WriteLine("\nyou deal " + pAttack0 + " damage\n");
			Console.WriteLine("you deal " + pAttack1 + " damage\n");
			Console.WriteLine("you deal " + pAttack2 + " damage\n");
			Console.WriteLine("Ogre takes " + pAttack + " damage\n");
			Console.WriteLine("Ogre Health:" + oHealth1);
			if (oHealth1 <= 0)
			{
				Console.WriteLine("you win\n");
			}
			PlayerActions(pHealth, oHealth1, oHealth);
		}
		static void Pattack3(int pHealth, int gHealth, int oHealth) 
		{
			int least = 1;
			int greatest = 5;
			int pAttack0 = GetRandom(least, greatest);
			int pAttack1 = GetRandom(least, greatest);
			int pAttack2 = GetRandom(least, greatest);
			int pAttack = pAttack0 + pAttack1 + pAttack2;
			int gHealth1 = gHealth - pAttack;
			Console.WriteLine("\nyou strike a deadly slice with your blade three times\n");
			Console.WriteLine("\nyou deal " + pAttack0 + " damage\n");
			Console.WriteLine("you deal " + pAttack1 + " damage\n");
			Console.WriteLine("you deal " + pAttack2 + " damage\n");
			Console.WriteLine("Goblin takes " + pAttack + " damage\n");
			Console.WriteLine("Goblin Health:" + gHealth1);
			if (gHealth1 <= 0)
			{
				Console.WriteLine("you win\n");
				OgreIntro(pHealth, oHealth);
			}
			PlayerActions(pHealth, gHealth1, oHealth);
		}
		static void Pattack(int gHealth, int pHealth1, int oHealth)
		{
			int least = 1;
			int greatest = 5;
			int pAttack0 = GetRandom(least, greatest);
			int pAttack1 = GetRandom(least, greatest);
			int pAttack2 = GetRandom(least, greatest);
			int pAttack = pAttack0 + pAttack1 + pAttack2;
			int gHealth1 = gHealth - pAttack;
			Console.WriteLine("\nyou strike a deadly slice with your blade three times\n");
			Console.WriteLine("\nyou deal " + pAttack0 + " damage\n");
			Console.WriteLine("you deal " + pAttack1 + " damage\n");
			Console.WriteLine("you deal " + pAttack2 + " damage\n");
			Console.WriteLine("Goblin takes " + pAttack + " damage\n");
			Console.WriteLine("Goblin Health:" + gHealth1);
			if (gHealth1 <= 0)
			{
				Console.WriteLine("you win\n");
				OgreIntro(pHealth1, oHealth);
			}
			if (gHealth1 >= 0)
			{
				Gattack(pHealth1, gHealth1, oHealth);
			}
		}
		static void Gattack(int pHealth, int gHealth1, int oHealth)
		{
			int least1 = 1;
			int greatest1 = 7;
			int gAttack1 = GetRandom(least1, greatest1);
			int least = 1;
			int greatest = 7;
			int gAttack2 = GetRandom(least, greatest);
			int gAttack = gAttack1 + gAttack2;
			Console.WriteLine("Goblin damage: " + gAttack);
			int pHealth1 = pHealth - gAttack;
			Console.WriteLine("takes " + gAttack + " damage\n");
			Console.WriteLine("Your Health: " + pHealth1);
			if (pHealth1 < 1)
			{
				Console.WriteLine("you lose...\n");
			}
			PlayerActions(pHealth1, gHealth1, oHealth);
		}

		static int GetRandom(int min, int max)
		{
			Random r = new Random();
			return r.Next(min, max);
		}
		static void OgreIntro(int pHealth1, int oHealth)
		{
			Console.WriteLine("\nyour next foe...\n");
			Console.WriteLine("OGRE!!!\n");
			Console.WriteLine("Ogre Health: " + oHealth);
			Console.WriteLine("your Health: " + pHealth1 + "\n");
			PlayerActions2(pHealth1, oHealth);
		}
		static void PlayerActions2(int pHealth1, int oHealth)
		{
			Console.WriteLine("What would you like to do?\n");
			Console.WriteLine("1 Attack");
			Console.WriteLine("2 Defend");
			Console.WriteLine("3 parry");
			string input = Console.ReadLine();
			switch (input)
			{
				case "1":
					Pattack2(pHealth1,oHealth);
					break;
				case "2":
					Oattack2(pHealth1, oHealth);
					break;
				case "attack":
					Pattack2(pHealth1, oHealth);
					break;
				case "defend":
					Oattack2(pHealth1, oHealth);
					break;
				case "3":
					Oattack3(pHealth1, oHealth);
					break;
				case "parry":
					Oattack3(pHealth1, oHealth);
					break;
				default:
					PlayerActions2(pHealth1, oHealth);
					break;
			}
		}
		static void Oattack3(int pHealth, int oHealth) 
		{
			int least1 = 1;
			int greatest1 = 10;
			int pResult = GetRandom(least1, greatest1);
			Console.WriteLine("you gain " + pResult + " parry\n");
			int least = 1;
			int greatest = 10;
			int oAttack1 = GetRandom(least, greatest);
			if (oAttack1 <= pResult) 
			{
				Console.WriteLine("you successfully parry");
				oAttack1 = 0;
				int least2 = 1;
				int greatest2 = 10;
				int oAttack3 = GetRandom(least2, greatest2);
				if (oAttack3 <= pResult) 
				{
					Console.WriteLine("you successfully parry");
					Pattack4(pHealth, oHealth);
				}
				int oAttack5 = oAttack1 + oAttack3;
				Console.WriteLine("Ogre damage: " + oAttack5);
				int pHealth2 = pHealth - oAttack5;
				Console.WriteLine("you take " + oAttack5 + " damage\n");
				Console.WriteLine("Your Health: " + pHealth2);
				if (pHealth2 < 1)
				{
					Console.WriteLine("you lose...\n");
				}
				PlayerActions2(pHealth2, oHealth);
			}
			int oAttack2 = GetRandom(least, greatest);
			int oAttack = oAttack1 + oAttack2;
			Console.WriteLine("Ogre damage: " + oAttack);
			int pHealth1 = pHealth - oAttack;
			Console.WriteLine("you take " + oAttack + " damage\n");
			Console.WriteLine("Your Health: " + pHealth1);
			if (pHealth1 < 1)
			{
				Console.WriteLine("you lose...\n");
			}
			PlayerActions2(pHealth1, oHealth);
		}
		static void Pattack2(int pHealth, int oHealth)
		{
			int least = 1;
			int greatest = 10;
			int pAttack0 = GetRandom(least, greatest);
			int pAttack1 = GetRandom(least, greatest);
			int pAttack2 = GetRandom(least, greatest);
			int pAttack = pAttack0 + pAttack1 + pAttack2;
			int oHealth1 = oHealth - pAttack;
			Console.WriteLine("\nyou strike a deadly slice with your blade three times\n");
			Console.WriteLine("\nyou deal " + pAttack0 + " damage\n");
			Console.WriteLine("you deal " + pAttack1 + " damage\n");
			Console.WriteLine("you deal " + pAttack2 + " damage\n");
			Console.WriteLine("Ogre takes " + pAttack + " damage\n");
			Console.WriteLine("Ogre Health:" + oHealth1);
			if (oHealth1 <= 0)
			{
				Console.WriteLine("you win\n");
			}
			if (oHealth1 > 0)
			{
				Oattack(pHealth, oHealth1);
			}
		}
		static void Oattack(int pHealth, int oHealth)
		{
			int least = 1;
			int greatest = 10;
			int oAttack1 = GetRandom(least, greatest);
			int oAttack2 = GetRandom(least, greatest);
			int oAttack = oAttack1 + oAttack2;
			Console.WriteLine("Ogre damage " + oAttack);
			int pHealth1 = pHealth - oAttack;
			Console.WriteLine("you take " + oAttack + " damage\n");
			Console.WriteLine("Your Health: " + pHealth1);
			if (pHealth1 < 1)
			{
				Console.WriteLine("you lose...\n");
			}
			PlayerActions2(pHealth1, oHealth);
		}
		static void Oattack2(int pHealth, int oHealth)
		{
			int least1 = 1;
			int greatest1 = 20;
			int dResult1 = GetRandom(least1, greatest1);
			Console.WriteLine("you gain " + dResult1 + " block\n");
			int least = 1;
			int greatest = 10;
			int oAttack1 = GetRandom(least, greatest);
			int oAttack2 = GetRandom(least, greatest);
			int oAttack = oAttack1 + oAttack2 - dResult1;
			Console.WriteLine("Ogre damage: " + oAttack);
			int pHealth1 = pHealth - oAttack;
			Console.WriteLine("you take " + oAttack + " damage\n");
			Console.WriteLine("Your Health: " + pHealth1);
			if (pHealth1 < 1)
			{
				Console.WriteLine("you lose...\n");
			}
			PlayerActions2(pHealth1, oHealth);
		}
	}
}
