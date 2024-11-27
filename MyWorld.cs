using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMonoGame;

namespace EasyExplosion
{
    internal class MyWorld : World
    {
        public MyWorld() : base(800, 800)
        {
            // Tile background with the file "bluerock" in the Content folder.
            BackgroundTileName = "bluerock";

            Add(new Bee(), "bee", 200, 200);
        }  
    }
}
