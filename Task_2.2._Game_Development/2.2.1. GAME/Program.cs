using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// I made the task without "*"

namespace _2._2._1.GAME
{
    class Program
    {
        static void Main(string[] args)
        {
            Player pl = new Player(4, 0, 0);

            Mobs mo = new Mobs(1, 10, 10);

            if (pl.PointOfBeingX == mo.PointOfBeingX
             && pl.PointOfBeingY == mo.PointOfBeingY)
            {
                mo.DamageOfPlayer(pl);
            }
            

        }
    }
}
