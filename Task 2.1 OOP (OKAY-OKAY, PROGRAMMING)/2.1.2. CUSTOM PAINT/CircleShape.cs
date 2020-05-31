using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2.CUSTOM_PAINT
{
    class CircleShape : Figure // Окружность
    {
        public int radius;

        public CircleShape(int Radius) : base(0, 0)
        {
            CheckEnter = Radius;
        }
        public CircleShape(int x, int y, int Radius) : base(x, y)
        {
            CheckEnter = Radius;
        }
        public int CheckEnter
        {
            get
            {
                return radius;
            }
            set
            {
                if (int.TryParse(value, out int x) > 0)
                {
                    radius = x;
                }
                else
                {
                    Console.WriteLine("Uncorrect entered the radius");
                }
            }
        }
        public override int MethodForFindArea(int radius)
        {
            return radius * Math.PI * radius;
        }
        public override int MetodForFindPerimetr(int radius)
        {
            return 2 * radius * Math.PI;
        }
        public void ShowInfo(int radius, int MethodForFindArea, int MetodForFindPerimetr, int x, int y)
        {
            Console.WriteLine("Figure Circle is created! \n" +
                               "Radius: " + radius + "\n" +
                                  "Area: " + MethodForFindArea + "\n" +
                                     "Perimetr: " + MetodForFindPerimetr + "\n" +
                                        "Points of being: " + x + y);
        }
    }
}
