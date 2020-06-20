using System;

namespace _2._2._1.GAME
{
    public class Rock : Coordinates
    {
        public Rock(int PointOfBeingX, int PointOfBeingY) : base(PointOfBeingX, PointOfBeingY)
        {
            this.PointOfBeingX = PointOfBeingX;
            this.PointOfBeingY = PointOfBeingY;
        }

        public void GetAround(Coordinates MobOrPlayer) // Подскальзываясь на камне двигающиеся объекты меняют координаты
        {
            Random rand = new Random();

            switch (rand.Next(1))
            {
                case 0:
                    MobOrPlayer.PointOfBeingX--;
                    MobOrPlayer.PointOfBeingY--;
                    break;
                case 1:
                    MobOrPlayer.PointOfBeingX++;
                    MobOrPlayer.PointOfBeingY++;
                    break;
            }
        }
    }
}
