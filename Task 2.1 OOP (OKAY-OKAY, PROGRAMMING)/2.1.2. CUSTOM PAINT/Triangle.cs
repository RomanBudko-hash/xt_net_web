using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2.CUSTOM_PAINT
{
    class Triangle : Figure
    {
        int area { get; set; }
        int perimetr { get; set; }

        private int sideAOfTreangle;
        public int sideA
        {
            get => sideAOfTreangle;

            set
            {
                if (value > 0)
                {
                    sideAOfTreangle = value;
                }
            }
        }

        private int sideBOfTreangle;
        public int sideB
        {
            get => sideBOfTreangle;

            set
            {
                if (value > 0)
                {
                    sideBOfTreangle = value;
                }
            }
        }

        private int sideCOfTreangle;
        public int sideC
        {
            get => sideCOfTreangle;

            set
            {
                if (value > 0)
                {
                    sideCOfTreangle = value;
                }
            }
        }

        public Triangle(int x, int y, int sideAOfRectangle, int sideBOfRectungle, int sideCOfRectungle) : base(x, y)
        {
            this.sideA = sideAOfRectangle;
            this.sideB = sideBOfRectungle;
            this.sideC = sideCOfRectungle;
        }

        public void FindToArea()
        {
            area = (int)Math.Sqrt(perimetr * (perimetr - sideA) * (perimetr - sideB) * (perimetr - sideC));
        }

        public void FindToPerimeter()
        {
            perimetr = sideA + sideB + sideC;
        }

        public override string ToString()
        {
            FindToArea();
            FindToPerimeter();
            return "Figure Triangle is created! \n" +
                        "Area: " + area + "\n" +
                            "Perimetr: " + perimetr + "\n" +
                                "Points of being: " + x + " " + y;
        }
    }
}
