using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace The_Dragon_Lair_SoloRPG.Maps
{
    public class Basic_Map : Map
    {
        public int lengthX = 10;
        public int lengthY = 10;
        public Basic_Map(string mapName) : base(mapName)
        {
        }
        public static void Build(List<Monster> monsters, Player player1, string spaceIcon)
        {
            //Console.Clear();
            Part1(monsters, player1, spaceIcon);
        }
        public static void Part1(List<Monster> monsters, Player player1, string spaceIcon)
        {
            Section1(monsters, player1, spaceIcon);
        }
        public static void Section1(List<Monster> monsters, Player player1, string spaceIcon)
        {
            Basic_Map code = new Basic_Map("Basic_Map");
            int restoreLX = code.lengthX;
            int restoreLY = code.lengthY;
            int number = 1;
            int number2 = 1;
            while (code.lengthX > number - 1)
            {
                Console.Write(" " + number);
                number += 1;
            }
            Console.Write("\n");
            while (code.lengthX > 0 && code.lengthY > number2 - 1)
            {
                number = 0;
                bool isMonster = false;
                while (code.lengthX > number)
                {
                    for (int i = 0; i < monsters.Count; i++)
                    {
                        if (monsters[i] != null)
                        {
                            if (number + 1 == monsters[i].posX && number2 == monsters[i].posY)
                            {
                                Console.Write(" " + monsters[i].mapIcon);
                                isMonster = true;
                            }
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
