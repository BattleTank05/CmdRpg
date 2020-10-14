using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace The_Dragon_Lair_SoloRPG.Maps
{
    public class Basic_Map : Map
    {
        public static int lengthX = 10;
        public static int lengthY = 10;
        public Basic_Map(string mapName) : base(mapName)
        {
        }
        public static void Build(Monster[] monsters, Player player1, string spaceIcon) 
        {
            Console.Clear();
            Part1(monsters, player1, spaceIcon);
        }
        public static void Part1(Monster[] monsters, Player player1, string spaceIcon) 
        {
            Section1(monsters, player1, spaceIcon);
        }
        public static void Section1(Monster[] monsters, Player player1, string spaceIcon) 
        {
            Thread.Sleep(1000);
            int restoreLX = lengthX;
            int restoreLY = lengthY;
            int number = 1;
            int number2 = 1;
            while (lengthX > number - 1)
            {
                Console.Write(" " + number);
                number += 1;
            }
            Console.Write("\n");
            while (lengthX > 0 && lengthY > number2 - 1)
            {
                number = 0;
                bool isMonster = false;
                while (lengthX > number)
                {
                    for (int i = 0; i < monsters.Length; i++)
                    {
                        if (number + 1 == monsters[i].posX && number2 == monsters[i].posY)
                        {
                            Console.Write(" " + monsters[i].mapIcon);
                            isMonster = true;
                        }
                    }
                    if (number + 1 == player1.posX && number2 == player1.posY)
                    {
                        Console.Write(" " + player1.mapIcon);
                    }
                    else if (isMonster == false)
                    {
                        Console.Write(" " + spaceIcon);
                    }
                    else if (isMonster == true) 
                    {
                        isMonster = false;
                    }
                    number += 1;
                }
                Console.Write(" " + number2);
                number2 += 1;
                Console.Write("\n");
                number = 0;
            }
            Thread.Sleep(1000);
        }
    }
}
