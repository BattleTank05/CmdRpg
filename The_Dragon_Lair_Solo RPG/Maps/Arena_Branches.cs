using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace The_Dragon_Lair_SoloRPG.Maps
{
    public class Arena_Branches : Map
    {
        // --------Section 1-------                             --------Section 2-------                   
        // 1 2 3 4 5 6 7 8 9 10 11 12
        //          ~ ~ ~ ~ ~                                           ~ ~ ~ ~ ~
        //    ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~                               ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~
        //           ^part1^                                            ^part1^
        //  ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~                           ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ 
        //  ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ | ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ | ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ 
        //  ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ | ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ | ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ 
        //  ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ | ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ | ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ 
        //  ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ | ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ | ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ 
        //  ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~        ^Section2^         ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ 
        //           ^part2^                                            ^part2^ 
        //    ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~                              ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~
        //         ~ ~ ~ ~ ~                                           ~ ~ ~ ~ ~
        //          ^part3^                                             ^part3^
        public int S1P1LengthX1 = 5;
        public int S1P1LengthY1 = 1;
        public int S1P1LengthX2 = 11;
        public int S1P1LengthY2 = 1;

        public int S1P2LengthX = 13;
        public int S1P2LengthY = 6;

        public int S1P3LengthX1 = 5;
        public int S1P3LengthY1 = 1;
        public int S1P3LengthX2 = 11;
        public int S1P3LengthY2 = 1;

        public int S2LengthX = 11;
        public int S2LengthY = 4;

        public int S3P1LengthX1 = 5;
        public int S3P1LengthY1 = 1;
        public int S3P1LengthX2 = 11;
        public int S3P1LengthY2 = 1;

        public int S3P2LengthX = 13;
        public int S3P2LengthY = 6;

        public int S3P3LengthX1 = 5;
        public int S3P3LengthY1 = 1;
        public int S3P3LengthX2 = 11;
        public int S3P3LengthY2 = 1;
        public Arena_Branches(string mapName) : base(mapName)
        {
        }
        public static void Build(List<Monster> monsters, Player player1, string spaceIcon)
        {
            Console.Clear();
            Map map = new Map("Arena_Branches");
            Render code = new Render();


            code.RenderMapGivenCoordinates(map, monsters, player1, "~", 5, 1);
            code.RenderMapGivenCoordinates(map, monsters, player1, "~", 11, 1);

            code.RenderMapGivenCoordinates(map, monsters, player1, "~", 13, 6);

            code.RenderMapGivenCoordinates(map, monsters, player1, "~", 11, 1);
            code.RenderMapGivenCoordinates(map, monsters, player1, "~", 5, 1);

            code.RenderMapGivenCoordinates(map, monsters, player1, "~", 11, 4);

            code.RenderMapGivenCoordinates(map, monsters, player1, "~", 5, 1);
            code.RenderMapGivenCoordinates(map, monsters, player1, "~", 11, 1);

            code.RenderMapGivenCoordinates(map, monsters, player1, "~", 13, 6);

            code.RenderMapGivenCoordinates(map, monsters, player1, "~", 11, 1);
            code.RenderMapGivenCoordinates(map, monsters, player1, "~", 5, 1);
        }
    }
}

