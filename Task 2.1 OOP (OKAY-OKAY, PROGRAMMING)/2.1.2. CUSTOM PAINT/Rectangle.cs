using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2.CUSTOM_PAINT
{
    public class Rectangle : Figure
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

        private int sideBOfRectangle;
        public int sideB
        {
            get => sideBOfRectangle;

            set
            {
                if (value > 0)
                {
                    sideBOfRectangle = value;
                }
            }
        }

        public Rectangle(int x, int y, int sideAOfRectangle, int sideBOfRectungle) : base(x, y)
        {
            sideA = sideAOfRectangle;
            sideB = sideBOfRectungle;
        }

        public void FindToArea()
        {
            area = sideA * sideB;
        }

        public void FindToPerimetr()
        {
            perimetr = (sideB + sideA) * 2;
        }

        public override string ToString()
        {
            FindToArea();
            FindToPerimetr();
            return "Figure Rectangle is created! \n" +
                        "Area: " + area + "\n" +
                            "Perimetr: " + perimetr + "\n" +
                                "Points of being: " + x + " " + y;
        }
    }
}
