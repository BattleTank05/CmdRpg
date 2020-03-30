using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Practice1
{
    class FightBackround
    {
        static void ArenaIntro() 
        {
            Console.WriteLine("You wake to find yourself in a musty dark room, armor and weaponry decorating the walls.");
            Console.WriteLine("a Gaurd in front of you, wearing a hauburk bearing the sigil of an unfamiliar region says:");
            Console.WriteLine("'you're going to want to get suited up pretty soon... its not looking so good out there...'");
        }
        static void GladiatorArena() 
        {
            
        }
        static int GetRandom(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max);
        }
    }
    class VillageRaid 
    {
        static void RaidIntro() 
        {
        
        }
        static int GetRandom(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max);
        }
    }
}
