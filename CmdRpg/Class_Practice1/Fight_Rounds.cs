﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Text;

namespace The_Dragon_Lair_SoloRPG
{
    public class Fight_Rounds
    {
        public int currentRound = 0;

        public void RoundStart(Monster[] monsters, Player player1) 
        {
            currentRound += 1;
            Console.WriteLine("----------Round " + currentRound + " Start----------\n");
            if (player1.entityBleeding > 0)
            {
                player1.Health -= player1.entityBleeding;
                Program.ColorWriter(ConsoleColor.Red, "You Take " + player1.entityBleeding + " Bleeding Damage");
                Console.WriteLine("Your Health: " + player1.Health);
                player1.entityBleeding -= 1;
            }
            if (player1.entityOnFire > 0)
            {
                player1.Health -= player1.entityOnFire;
                Program.ColorWriter(ConsoleColor.Red, "You Take " + player1.entityOnFire + " Burning Damage");
                Console.WriteLine("Your Health: " + player1.Health);
                player1.entityOnFire -= 1;
            }
            if (player1.Health <= 0) 
            {
                Console.WriteLine("You lose...");
                return;
            }
            Render code = new Render();
            int defeatedMonsters = 0;
            for (int i = 0; i < monsters.Length; i++) 
            {
                if (monsters[i] != null) 
                {
                    if (monsters[i].Health > 0) 
                    {
                        if (monsters[i].monsterBleeding > 0)
                        {
                            monsters[i].Health -= monsters[i].monsterBleeding;
                            Program.ColorWriter(ConsoleColor.Red, monsters[i].Name + " takes " + monsters[i].monsterBleeding + " Bleeding damage!" + "\n" + monsters[i].Name + " Health: " + monsters[i].Health);
                            monsters[i].monsterBleeding -= 1;
                        }
                        if (monsters[i].monsterOnFire > 0)
                        {
                            monsters[i].Health -= monsters[i].monsterOnFire;
                            Program.ColorWriter(ConsoleColor.Red, monsters[i].Name + " takes " + monsters[i].monsterBleeding + " Burning damage!" + "\n" + monsters[i].Name + " Health: " + monsters[i].Health);
                            monsters[i].monsterOnFire -= 1;
                        }
                        if (monsters[i].Health <= 0)
                        {
                            Console.WriteLine(monsters[i].Name + " has been defeated...");
                        }
                        defeatedMonsters += 1;
                    }
                }
            }
        }
        public void RoundEnd(Monster[] monsters, Player player1, bool isDebuggerFight) 
        {
            Program code = new Program();
            if (isDebuggerFight == false)
            {
                for (int i = 0; i < monsters.Length - 1; i++)
                {
                    if (monsters[i] != null)
                    {
                        return;
                    }
                }
                Program.ColorWriter(ConsoleColor.Green, "You Win!");
                code.LootPhase(player1, monsters, GetRandom(1, monsters.Length + player1.level));
            }
            else if (isDebuggerFight == true)
            {
                if (monsters.Length - 1 == 0)
                    Program.ColorWriter(ConsoleColor.Green, monsters[0].Name + " Wins!");
            }
            Console.WriteLine("----------Round " + currentRound + " End----------\n");
        }
        static int GetRandom(int min, int max) 
        {
            Random r = new Random();
            return r.Next(min, max);
        }
    }
}
