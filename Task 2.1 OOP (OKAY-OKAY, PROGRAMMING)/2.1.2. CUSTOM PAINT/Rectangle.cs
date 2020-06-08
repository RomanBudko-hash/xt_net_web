using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2.CUSTOM_PAINT
{
    public class Rectangle : Figure, IGetInfo
    {
        int area { get; set; }
        int perimetr { get; set; }

        private int sideA
        {
            get => sideA;

            set
            {
                if (value > 0)
                {
                    sideA = x;
                }
                else
                {
                    Console.WriteLine("Uncorrect enter");
                }
            }
        }

        private int sideB
        {
            get => sideB;

            set
            {
                if (value > 0)
                {
                    sideB = x;
                }
                else
                {
                    Console.WriteLine("Uncorrect enter");
                }
            }
        }

        public Rectangle(int x, int y, int sideA, int sideB) : base(x, y)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            Console.WriteLine("Rectangle is created!!!");
        }

        public void FindToArea()
        {
            area = sideA * sideB;
        }

        public void FindToPerimetr()
        {
            perimetr = (sideB + sideA) * 2;
        }

        void IGetInfo.GetInfo()
        {
            FindToArea();
            FindToPerimetr();
            Console.WriteLine("Figure Circle is created! \n" +
                                  "Area: " + area + "\n" +
                                  "Perimetr: " + perimetr + "\n" +
                                        "Points of being: " + x + y);
        }
    }
}
