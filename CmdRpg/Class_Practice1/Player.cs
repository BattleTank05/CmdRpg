using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Practice1
{
    class Player
    {
        public string PlayerName;
        public int Weapon;
        public int Gear = 0;
        public int Health = 15;
        public int MinBlock = 1;
        public int MaxBlock = 12;
        public int MinParry = 1;
        public int MaxParry = 6;
        public int Strength = 0;
        public int Dodge = 0;
        public int Intellect = 0;
        public int MinDamage = 7;
        public int MaxDamage = 13;
        public int AttackAmount = 1;
        public Player(string playerName)
        {
            PlayerName = playerName;
        }
        public int PlayerAttack(int TrollHealth, int TrollArmor, int TrollParry, int PlayerMinDamage, int PlayerMaxDamage, int PlayerStrength, int PlayerAttackAmount) 
        {
            int PlayerAttack1 = GetRandom(PlayerMinDamage, PlayerMaxDamage);
            Console.WriteLine(PlayerAttack1);
            int PlayerAttack2 = GetRandom(PlayerMinDamage, PlayerMaxDamage);
            Console.WriteLine(PlayerAttack2);
            int PlayerDamage = PlayerAttack1 + PlayerAttack2;
            Console.WriteLine(PlayerDamage);
            int TrollHealth1 = TrollHealth - PlayerDamage;
            Console.WriteLine("Troll Health: " + TrollHealth1);
            if (TrollHealth1 < 1)
            {
                Console.WriteLine("you Win\n");
                //Console.WriteLine("your points: " + points);
                Program code = new Program();
                code.Environment();
            }
            return TrollHealth1;
        }
        public int Player_Defend(int PlayerBlock) 
        {
            PlayerBlock1 = GetRandom(PlayerBlockMin, PlayerBlockMax);
            PlayerBlock = PlayerBlock1 + Gear;
            Console.WriteLine("you gain " + PlayerBlock + " Block");
            return PlayerBlock;
        }
        public int Player_Parry(int PlayerParry, int PlayerBlock) 
        {
            PlayerParry = PlayerBlock - Gear;
            Console.WriteLine("you gain " + PlayerParry + " Parry");
            return PlayerParry;
        }
        public int Player_Heal(int PlayerHealth, int PlayerBlock) 
        {
            int least = 1;
            int greatest = 10;
            int Heal = GetRandom(least, greatest);
            PlayerHealth = PlayerHealth + Heal;
            Console.WriteLine("You Heal " + Heal + " Health");
            Console.WriteLine("Your Health: " + PlayerHealth);
            return PlayerHealth;
        }
        static int GetRandom(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max);
        }
    }
}
