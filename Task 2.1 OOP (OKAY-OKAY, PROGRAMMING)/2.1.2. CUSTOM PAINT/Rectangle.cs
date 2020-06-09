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

        private int sideAOfRectangle;
        public int sideA
        {
            get => sideAOfRectangle;

            set
            {
                if (value > 0)
                {
                    sideAOfRectangle = value;
                }
            }
        }

        private int sideBOfRectungle;
        public int sideB
        {
            get => sideBOfRectungle;

            set
            {
                if (value > 0)
                {
                    sideBOfRectungle = value;
                }
                else
                {
                    Console.WriteLine("Uncorrect enter");
                }
            }
        }

        public Rectangle(int x, int y, int sideA, int sideB) : base(x, y)
        {
            this.sideA = sideAOfRectangle;
            this.sideB = sideBOfRectungle;
            Console.WriteLine("Rectangle is created!!!");
        }

        public void FindToArea()
        {
            area = sideAOfRectangle * sideBOfRectungle;
        }

        public void FindToPerimetr()
        {
            perimetr = (sideBOfRectungle + sideAOfRectangle) * 2;
        }

        void IGetInfo.GetInfo()
        {
            FindToArea();
            FindToPerimetr();
            Console.WriteLine($"Figure Circle is created! \n" +
                                "Area: " + area + "\n" +
                                  "Perimetr: " + perimetr + "\n" +
                                    "Points of being: " + x + "" + y);
        }
    }
}
