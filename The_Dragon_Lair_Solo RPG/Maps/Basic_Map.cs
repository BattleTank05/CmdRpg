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
            Console.Clear();
            Map map = new Map("Basic_Map");
            Render code = new Render();
            code.RenderMapGivenCoordinates(map, monsters, player1, "~", 10, 10);
        }
    }
}
