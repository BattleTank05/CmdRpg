using System;

namespace Fight1PvG
{
	class Program
	{
		static void Main(string[] args)
		{
			Gladiator();
		}
		static void Gladiator() 
		{
			int pWeapon = 0;
			int input = 0;
			Console.WriteLine("Choose a weapon:");
			Console.WriteLine("1 Broadsword");
			Console.WriteLine("2 Mace");
			Console.WriteLine("3 Twin Daggers\n");
			string  info = Console.ReadLine();
			try
			{
				input = Int32.Parse(info);
			}
			catch 
			{
				Console.WriteLine("Creation Error... Restarting...");
				Gladiator();
			}
			switch (input) 
			{
				case 1:
					pWeapon = input;
					Console.WriteLine("Broadsword it is...");
					break;
				case 2:
					pWeapon = input;
					Console.WriteLine("Mace it is...");
					break;
				case 3:
				    pWeapon = input;
					Console.WriteLine("Twin Daggers it is...");
					break;
				default:
					Console.WriteLine("Creation Error... Restarting...");
					Gladiator();
					break;
			}
			int pGear = 0;
			int input2 = 0;
			Console.WriteLine("Choose a set of gear:");
			Console.WriteLine("1 Chainmail(Warrior)");
			Console.WriteLine("2 Thick Leather(Rogue)");
			Console.WriteLine("3 Sleek Silken Cloth(Mage)\n");
			string info1 = Console.ReadLine();
			try
			{
				input2 = Int32.Parse(info1);
			}
			catch
			{
				Console.WriteLine("Creation Error... Restarting...");
				Gladiator();
			}
			switch (input2)
			{
				case 1:
					pGear = input2;
					Console.WriteLine("Warrior it is...");
					break;
				case 2:
					pGear = input2;
					Console.WriteLine("Rogue it is...");
					break;
				case 3:
					pGear = input2;
					Console.WriteLine("Mage it is...");
					break;
				default:
					Console.WriteLine("Creation Error... Restarting...");
					Gladiator();
					break;
			}
			Console.WriteLine("Type in a name for your Gladiator\n");
			var Pname = Console.ReadLine();
			Console.WriteLine("ready yourself Gladiator\n");
			Console.WriteLine("your foe, GOBLIN!!!");
			int pHealth = 25;
			int gHealth = 15;
			int oHealth = 20;
			int tHealth = 30;
			Console.WriteLine("\nGoblin Health: " + gHealth);
			Console.WriteLine("Your Health: " + pHealth);
			PlayerActions(pHealth, gHealth, oHealth, tHealth);
		}
		static int GetRandom(int min, int max)
		{
			Random r = new Random();
			return r.Next(min, max);
		}
		static void PlayerActions(int pHealth, int gHealth, int oHealth, int tHealth)
		{
			Console.WriteLine("What would you like to do?\n");
			Console.WriteLine("1 Attack");
			Console.WriteLine("2 Defend");
			Console.WriteLine("3 Parry");
			Console.WriteLine("4 Heal and defend");
			string input = Console.ReadLine();
			switch (input)
			{
				case "1":
					Pattack(gHealth, pHealth, oHealth, tHealth);
					break;
				case "2":
					Gattack2(pHealth, gHealth, oHealth, tHealth);
					break;
				case "attack":
					Pattack(gHealth, pHealth, oHealth, tHealth);
					break;
				case "defend":
					Gattack2(pHealth, gHealth, oHealth, tHealth);
					break;
				case "3":
					Gattack3(pHealth, gHealth, oHealth, tHealth);
					break;
				case "parry":
					Gattack3(pHealth, gHealth, oHealth, tHealth);
					break;
				case "4":
					Heal1(pHealth, gHealth, oHealth, tHealth);
					break;
				case "heal":
					Heal1(pHealth, gHealth, oHealth, tHealth);
					break;
				default:
					PlayerActions(pHealth, gHealth, oHealth, tHealth);
					break;
			}
		}
		static void Heal1(int pHealth, int gHealth, int oHealth, int tHealth) 
		{
			int least = 1;
			int greatest = 5;
			int heal = GetRandom(least, greatest);
			int pHealth1 = pHealth + heal;
			Console.WriteLine("you Heal " + heal);
			Console.WriteLine("your Health: " + pHealth1);
			Gattack2(pHealth1, gHealth, oHealth, tHealth);
		}
		static void Pattack3(int pHealth, int gHealth, int oHealth, int tHealth)
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
				OgreIntro(pHealth, oHealth, tHealth);
			}
			PlayerActions(pHealth, gHealth1, oHealth, tHealth);
		}
		static void Pattack(int gHealth, int pHealth1, int oHealth, int tHealth)
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
				OgreIntro(pHealth1, oHealth, tHealth);
			}
			if (gHealth1 >= 0)
			{
				Gattack(pHealth1, gHealth1, oHealth, tHealth);
			}
		}
		static void Gattack(int pHealth, int gHealth1, int oHealth, int tHealth)
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
			Console.WriteLine("you take " + gAttack + " damage\n");
			Console.WriteLine("Your Health: " + pHealth1);
			if (pHealth1 < 1)
			{
				Console.WriteLine("you lose...\n");
				return;
			}
			PlayerActions(pHealth1, gHealth1, oHealth, tHealth);
		}
		static void Gattack2(int pHealth, int gHealth, int oHealth, int tHealth)
		{
			int least1 = 1;
			int greatest1 = 14;
			int dResult = GetRandom(least1, greatest1);
			Console.WriteLine("you gain " + dResult + " block");
			int least = 1;
			int greatest = 7;
			int gAttack1 = GetRandom(least, greatest);
			int gAttack2 = GetRandom(least, greatest);
			int gAttack = gAttack1 + gAttack2 - dResult;
			while (gAttack < 0) 
			{
				gAttack = gAttack + 1;
			}
			Console.WriteLine("Goblin damage: " + gAttack);
			int pHealth1 = pHealth - gAttack;
			Console.WriteLine("you take " + gAttack + " damage\n");
			Console.WriteLine("Your Health: " + pHealth1);
			if (pHealth1 < 1)
			{
				Console.WriteLine("you lose...\n");
				return;
			}
			PlayerActions(pHealth1, gHealth, oHealth, tHealth);
		}
		static void Gattack3(int pHealth, int gHealth, int oHealth, int tHealth) 
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
					Pattack3(pHealth, gHealth, oHealth, tHealth);
				}
				int gAttack4 = gAttack1 + gAttack3;
				Console.WriteLine("Goblin damage: " + gAttack4);
				int pHealth3 = pHealth - gAttack4;
				Console.WriteLine("you take " + gAttack4 + " damage\n");
				Console.WriteLine("Your Health: " + pHealth3);
				if (pHealth3 < 1)
				{
					Console.WriteLine("you lose...\n");
					return;
				}
				PlayerActions(pHealth3, gHealth, oHealth, tHealth);
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
				return;
			}
			PlayerActions(pHealth1, gHealth, oHealth, tHealth);
		}
		static void PlayerActions2(int pHealth1, int oHealth, int tHealth)
		{
			Console.WriteLine("What would you like to do?\n");
			Console.WriteLine("1 Attack");
			Console.WriteLine("2 Defend");
			Console.WriteLine("3 parry");
			Console.WriteLine("4 Heal and defend");
			string input = Console.ReadLine();
			switch (input)
			{
				case "1":
					Pattack2(pHealth1,oHealth, tHealth);
					break;
				case "2":
					Oattack2(pHealth1, oHealth, tHealth);
					break;
				case "attack":
					Pattack2(pHealth1, oHealth, tHealth);
					break;
				case "defend":
					Oattack2(pHealth1, oHealth, tHealth);
					break;
				case "3":
					Oattack3(pHealth1, oHealth, tHealth);
					break;
				case "parry":
					Oattack3(pHealth1, oHealth, tHealth);
					break;
				case "4":
					Heal2(pHealth1, oHealth, tHealth);
					break;
				case "Heal":
					Heal2(pHealth1, oHealth, tHealth);
					break;
				default:
					PlayerActions2(pHealth1, oHealth, tHealth);
					break;
			}
		}
		static void Heal2(int pHealth, int oHealth, int tHealth) 
		{
			int least = 1;
			int greatest = 10;
			int heal = GetRandom(least, greatest);
			int pHealth1 = pHealth + heal;
			Console.WriteLine("you Heal " + heal);
			Console.WriteLine("your Health: " + pHealth1);
			Oattack2(pHealth1, oHealth, tHealth);
		}
		static void Pattack2(int pHealth, int oHealth, int tHealth)
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
				TrollIntro(pHealth, tHealth);
			}
			if (oHealth1 > 0)
			{
				Oattack(pHealth, oHealth1, tHealth);
			}
		}
		static void Pattack4(int pHealth, int oHealth, int tHealth)
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
				TrollIntro(pHealth, tHealth);
			}
			PlayerActions2(pHealth, oHealth1, tHealth);
		}
		static void OgreIntro(int pHealth1, int oHealth, int tHealth)
		{
			Console.WriteLine("\nyour next foe...\n");
			Console.WriteLine("OGRE!!!\n");
			Console.WriteLine("Ogre Health: " + oHealth);
			Console.WriteLine("your Health: " + pHealth1 + "\n");
			PlayerActions2(pHealth1, oHealth, tHealth);
		}
		static void Oattack(int pHealth, int oHealth, int tHealth)
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
				return;
			}
			PlayerActions2(pHealth1, oHealth, tHealth);
		}
		static void Oattack2(int pHealth, int oHealth, int tHealth)
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
			while (oAttack < 0) 
			{
				oAttack = oAttack + 1;
			}
			Console.WriteLine("Ogre damage: " + oAttack);
			int pHealth1 = pHealth - oAttack;
			Console.WriteLine("you take " + oAttack + " damage\n");
			Console.WriteLine("Your Health: " + pHealth1);
			if (pHealth1 < 1)
			{
				Console.WriteLine("you lose...\n");
				return;
			}
			PlayerActions2(pHealth1, oHealth, tHealth);
		}
		static void Oattack3(int pHealth, int oHealth, int tHealth)
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
					Pattack4(pHealth, oHealth, tHealth);
				}
				int oAttack5 = oAttack1 + oAttack3;
				Console.WriteLine("Ogre damage: " + oAttack5);
				int pHealth2 = pHealth - oAttack5;
				Console.WriteLine("you take " + oAttack5 + " damage\n");
				Console.WriteLine("Your Health: " + pHealth2);
				if (pHealth2 < 1)
				{
					Console.WriteLine("you lose...\n");
					return;
				}
				PlayerActions2(pHealth2, oHealth, tHealth);
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
				return;
			}
			PlayerActions2(pHealth1, oHealth, tHealth);
		}
		static void TrollIntro(int pHealth1, int tHealth) 
		{
			Console.WriteLine("\nyour next foe...\n");
			Console.WriteLine("TROLL!!!\n");
			Console.WriteLine("Troll Health " + tHealth);
			Console.WriteLine("your Health: " + pHealth1 + "\n");
			Console.WriteLine("Troll goes first...\n");
			Tactions(pHealth1, tHealth);
		}
		static void PlayerActions3(int pHealth1, int tHealth1) 
		{
			Console.WriteLine("What would you like to do?\n");
			Console.WriteLine("1 Attack");
			Console.WriteLine("2 Defend");
			Console.WriteLine("3 parry");
			Console.WriteLine("4 Heal and defend");
			string input = Console.ReadLine();
			switch (input)
			{
				case "1":
					Pattack6(pHealth1, tHealth1);
					break;
				case "2":
					Tattack2(pHealth1, tHealth1);
					break;
				case "attack":
					Pattack6(pHealth1, tHealth1);
					break;
				case "defend":
					Tattack2(pHealth1, tHealth1);
					break;
				case "3":
					Tattack3(pHealth1, tHealth1);
					break;
				case "parry":
					Tattack3(pHealth1, tHealth1);
					break;
				case "4":
					Heal3(pHealth1, tHealth1);
					break;
				case "Heal":
					Heal3(pHealth1, tHealth1);
					break;
				default:
					PlayerActions3(pHealth1, tHealth1);
					break;
			}
		}
		static void Heal3(int pHealth, int tHealth)
		{
			int least = 1;
			int greatest = 15;
			int heal = GetRandom(least, greatest);
			int pHealth1 = pHealth + heal;
			Console.WriteLine("you Heal " + heal);
			Console.WriteLine("your Health: " + pHealth1);
			Tattack2(pHealth1, tHealth);
		}
		static void Pattack5(int pHealth, int tHealth)
		{
			int least = 1;
			int greatest = 5;
			int pAttack0 = GetRandom(least, greatest);
			int pAttack1 = GetRandom(least, greatest);
			int pAttack2 = GetRandom(least, greatest);
			int pAttack = pAttack0 + pAttack1 + pAttack2;
			int tHealth1 = tHealth - pAttack;
			Console.WriteLine("\nyou strike a deadly slice with your blade three times\n");
			Console.WriteLine("\nyou deal " + pAttack0 + " damage\n");
			Console.WriteLine("you deal " + pAttack1 + " damage\n");
			Console.WriteLine("you deal " + pAttack2 + " damage\n");
			Console.WriteLine("Troll takes " + pAttack + " damage\n");
			Console.WriteLine("Troll Health:" + tHealth1);
			if (tHealth1 <= 0)
			{
				Console.WriteLine("you win\n");
				return;
			}
			PlayerActions3(pHealth, tHealth1);
		}
		static void Pattack6(int pHealth1, int tHealth)
		{
			int least = 1;
			int greatest = 5;
			int pAttack0 = GetRandom(least, greatest);
			int pAttack1 = GetRandom(least, greatest);
			int pAttack2 = GetRandom(least, greatest);
			int pAttack = pAttack0 + pAttack1 + pAttack2;
			int tHealth1 = tHealth - pAttack;
			Console.WriteLine("\nyou strike a deadly slice with your blade three times\n");
			Console.WriteLine("\nyou deal " + pAttack0 + " damage\n");
			Console.WriteLine("you deal " + pAttack1 + " damage\n");
			Console.WriteLine("you deal " + pAttack2 + " damage\n");
			Console.WriteLine("Troll takes " + pAttack + " damage\n");
			Console.WriteLine("Troll Health:" + tHealth1);
			if (tHealth1 <= 0)
			{
				Console.WriteLine("you win\n");
				return;
			}
			if (tHealth1 >= 0)
			{
				Tactions(pHealth1, tHealth1);
			}
		}
		static void Pattack7(int pHealth1, int tHealth)
		{
			int least1 = 1;
			int greatest1 = 15;
			int tdefend = GetRandom(least1, greatest1);
			int least = 1;
			int greatest = 5;
			int pAttack0 = GetRandom(least, greatest);
			int pAttack1 = GetRandom(least, greatest);
			int pAttack2 = GetRandom(least, greatest);
			int pAttack = pAttack0 + pAttack1 + pAttack2;
			int tHealth1 = tHealth - pAttack;
			Console.WriteLine("Troll gains " + tdefend + " block");
			Console.WriteLine("\nyou strike a deadly slice with your blade three times\n");
			Console.WriteLine("\nyou deal " + pAttack0 + " damage\n");
			Console.WriteLine("you deal " + pAttack1 + " damage\n");
			Console.WriteLine("you deal " + pAttack2 + " damage\n");
			Console.WriteLine("Troll takes " + pAttack + " damage\n");
			Console.WriteLine("Troll Health:" + tHealth1);
			if (tHealth1 <= 0)
			{
				Console.WriteLine("you win\n");
				return;
			}
			if (tHealth1 >= 0)
			{
				PlayerActions3(pHealth1, tHealth1);
			}
		}
		static void Tactions(int pHealth, int tHealth) 
		{
			int least = 1;
			int greatest = 2;
			int tAction = GetRandom(least, greatest);
			switch (tAction) 
			{
				case 1:
					Tattack(pHealth, tHealth);
					break;
				case 2:
					Pattack7(pHealth, tHealth);
					break;
			}
		}
		static void Tattack(int pHealth, int tHealth)
		{
			int least = 1;
			int greatest = 7;
			int tAttack1 = GetRandom(least, greatest);
			int tAttack2 = GetRandom(least, greatest);
			int tAttack = tAttack1 + tAttack2;
			Console.WriteLine("Troll damage " + tAttack);
			int pHealth1 = pHealth - tAttack;
			Console.WriteLine("you take " + tAttack + " damage\n");
			Console.WriteLine("Your Health: " + pHealth1);
			if (pHealth1 < 1)
			{
				Console.WriteLine("you lose...\n");
				return;
			}
			PlayerActions3(pHealth1, tHealth);
		}
		static void Tattack2(int pHealth, int tHealth)
		{
			int least1 = 1;
			int greatest1 = 20;
			int dResult1 = GetRandom(least1, greatest1);
			Console.WriteLine("you gain " + dResult1 + " block\n");
			int least = 1;
			int greatest = 10;
			int tAttack1 = GetRandom(least, greatest);
			int tAttack2 = GetRandom(least, greatest);
			int tAttack = tAttack1 + tAttack2 - dResult1;
			while (tAttack < 0)
			{
				tAttack = tAttack + 1;
			}
			Console.WriteLine("Troll damage: " + tAttack);
			int pHealth1 = pHealth - tAttack;
			Console.WriteLine("you take " + tAttack + " damage\n");
			Console.WriteLine("Your Health: " + pHealth1);
			if (pHealth1 < 1)
			{
				Console.WriteLine("you lose...\n");
				return;
			}
			PlayerActions3(pHealth1, tHealth);
		}
		static void Tattack3(int pHealth, int tHealth)
		{
			int least1 = 1;
			int greatest1 = 10;
			int pResult = GetRandom(least1, greatest1);
			Console.WriteLine("you gain " + pResult + " parry\n");
			int least = 1;
			int greatest = 10;
			int tAttack1 = GetRandom(least, greatest);
			if (tAttack1 <= pResult)
			{
				Console.WriteLine("you successfully parry");
				tAttack1 = 0;
				int least2 = 1;
				int greatest2 = 10;
				int tAttack3 = GetRandom(least2, greatest2);
				if (tAttack3 <= pResult)
				{
					Console.WriteLine("you successfully parry");
					Pattack5(pHealth, tHealth);
				}
				int tAttack5 = tAttack1 + tAttack3;
				Console.WriteLine("Troll damage: " + tAttack5);
				int pHealth2 = pHealth - tAttack5;
				Console.WriteLine("you take " + tAttack5 + " damage\n");
				Console.WriteLine("Your Health: " + pHealth2);
				if (pHealth2 < 1)
				{
					Console.WriteLine("you lose...\n");
					return;
				}
				PlayerActions3(pHealth2, tHealth);
			}
			int tAttack2 = GetRandom(least, greatest);
			int tAttack = tAttack1 + tAttack2;
			Console.WriteLine("Troll damage: " + tAttack);
			int pHealth1 = pHealth - tAttack;
			Console.WriteLine("you take " + tAttack + " damage\n");
			Console.WriteLine("Your Health: " + pHealth1);
			if (pHealth1 < 1)
			{
				Console.WriteLine("you lose...\n");
				return;
			}
			PlayerActions3(pHealth1, tHealth);
		}
	}
}
