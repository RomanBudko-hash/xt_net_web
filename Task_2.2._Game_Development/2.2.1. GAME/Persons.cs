using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._1.GAME
{
    public abstract class Persons
    {
        public int PointOfBeingX { get; set; }

        public int PointOfBeingY { get; set; }

        public readonly int SpeedOfSomebodyAlive;

        private int Health = 100;

        public int health
        {
            get => Health;

            set
            {
                if (Health <= 100)
                {
                    Health = health;
                }
            }
        }

        public Persons(int Speed, int PointOfBeingX, int PointOfBeingY)
        {
            if (Speed > 0 && Speed <= 5)
            {
                SpeedOfSomebodyAlive = Speed;
            }
            this.PointOfBeingX = PointOfBeingX;
            this.PointOfBeingY = PointOfBeingY;
        }
    }
}
