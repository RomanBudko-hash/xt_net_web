using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._1.GAME
{
    public class Mobs : Persons
    {
        private readonly int Damage = 25;

        public Mobs(int Speed, int PointOfBeingX, int PointOfBeingY)
        : base(Speed, PointOfBeingX, PointOfBeingY) { }

        public int DamageOfPlayer(Player player)
        {
            return player.health - Damage;
        }
    }
}
