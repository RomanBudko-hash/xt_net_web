// I made the task without "*"

using System;

namespace _2._2._1.GAME
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var RandForMobs = new Random();

            Player pl = new Player(0, 0);

            Mobs mo = new Mobs(10, 10);

            Mobs mob = new Mobs(11, 12);

            Rock rock = new Rock(20, 15);

            Bonus cherry = new Bonus(RandForMobs.Next(Map.Width),
                                     RandForMobs.Next(Map.Height)); // Вишенка появляется в рандомном месте

            ConsoleKeyInfo info;

            bool StopGame = false;

            while (!StopGame)
            {
                if (Console.KeyAvailable)
                {
                    info = Console.ReadKey(intercept: true);

                    switch (info.Key) // Имитация движения путем изменения координат
                    {
                        case ConsoleKey.UpArrow:
                            pl.PointOfBeingY++;
                            break;
                        case ConsoleKey.DownArrow:
                            pl.PointOfBeingY--;
                            break;
                        case ConsoleKey.LeftArrow:
                            pl.PointOfBeingX--;
                            break;
                        case ConsoleKey.RightArrow:
                            pl.PointOfBeingX++;
                            break;
                    }

                    if (pl.PointOfBeingX == mo.PointOfBeingX // Если встретил врага, то получает урон
                    && pl.PointOfBeingY == mo.PointOfBeingY ||
                    pl.PointOfBeingX == mob.PointOfBeingX
                    && pl.PointOfBeingY == mob.PointOfBeingY)
                    {
                        mo.DamageOfPlayer(pl);
                    }

                    if (pl.PointOfBeingX == cherry.PointOfBeingX // Если встретил вишенку, то плюсуется здоровье
                    && pl.PointOfBeingY == cherry.PointOfBeingY)
                    {
                        pl.GetHealth();
                    }

                    switch (RandForMobs.Next(7)) // Пытался сделать хоть какую-то логику
                    {
                        case 0:
                            mo.PointOfBeingX++;
                            break;
                        case 1:
                            mo.PointOfBeingX--;
                            break;
                        case 2:
                            mo.PointOfBeingY++;
                            break;
                        case 3:
                            mo.PointOfBeingY--;
                            break;
                        case 4:
                            mob.PointOfBeingX++;
                            break;
                        case 5:
                            mob.PointOfBeingX--;
                            break;
                        case 6:
                            mob.PointOfBeingY++;
                            break;
                        case 7:
                            mob.PointOfBeingY--;
                            break;
                    }

                    if (pl.Health == 0)
                    {
                        StopGame = true;
                    }

                    if (pl.PointOfBeingX == rock.PointOfBeingX
                     && pl.PointOfBeingY == rock.PointOfBeingY) // Встреча с камнем
                    {
                        rock.GetAround(pl);
                    }

                    else if (mo.PointOfBeingX == rock.PointOfBeingX
                          && mo.PointOfBeingY == rock.PointOfBeingY)
                         {
                        rock.GetAround(mo);
                         }

                    else if (mob.PointOfBeingX == rock.PointOfBeingX
                          && mob.PointOfBeingY == rock.PointOfBeingY)
                         {
                        rock.GetAround(mob);
                         }
                }
            }
        }
    }
}
