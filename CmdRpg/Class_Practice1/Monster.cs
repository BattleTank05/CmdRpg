using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Practice1
{
    class Monster
    {
        public int Health = 10;
        public int Armor = 12;
        public int Parry = 6;
        public int Strength = 0;
        public int Dodge = 0;
        public int Intellect = 0;
		public int MinDamage = 5;
        public int MaxDamage = 11;
        public int AttackAmount = 2;
        public int TrollAttack(int PlayerHealth, int PlayerArmor, int PlayerParry, int TrollMinDamage, int TrollMaxDamage, int TrollStrength, int TrollAttackAmount)
        {
            int TrollAttack1 = GetRandom(TrollMinDamage, TrollMaxDamage);
            int TrollAttack2 = GetRandom(TrollMinDamage, TrollMaxDamage);
            int TrollDamage = TrollAttack1 + TrollAttack2 - PlayerArmor;
            int PlayerHealth1 = PlayerHealth - TrollDamage;
            Console.WriteLine("Your Health: " + PlayerHealth1);
            if (PlayerHealth1 < 1)
            {
                Console.WriteLine("you Lose...\n");
                Program code = new Program();
                code.Environment();
            }
            return PlayerHealth1;
        }
        public int Troll_Defend(int TrollArmor)
        {
            int least = TrollArmor/2;
            int greatest = TrollArmor * 9/6;
            int TrollArmor1 = GetRandom(least, greatest);
            Console.WriteLine("Troll gains " + TrollArmor1 + " Block");
            return TrollArmor1;
        }
        public int Troll_Parry(int TrollParry, int TrollArmor)
        {
            int least = TrollArmor / 2;
            int greatest = TrollArmor * 9 / 6;
            TrollParry = GetRandom(least, greatest);
            Console.WriteLine("Troll gains " + TrollParry + " Parry");
            return TrollParry;
        }
        public int Troll_Heal(int TrollHealth, int TrollArmor)
        {
            int least = 1;
            int greatest = 10;
            int Heal = GetRandom(least, greatest);
            TrollHealth = TrollHealth + Heal;
            Console.WriteLine("Troll Heals " + Heal + " Health");
            Console.WriteLine("Troll Health: " + TrollHealth);
            return TrollHealth;
        }
        static int GetRandom(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max);
        }
    }
}
