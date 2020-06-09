using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2.CUSTOM_PAINT
{
    public class Square : Figure, IGetInfo
    {
        private int SideOfSquare;
        public int Side
        {
            get => SideOfSquare;

            set
            {
                if (value > 0)
                {
                    SideOfSquare = value;
                }
            }
        }

        public int perimeter { get; set; }

        public int area { get; set; }

        public Square(int x, int y, int sideOfSquare) : base(x, y)
        {
            this.SideOfSquare = sideOfSquare;
        }

        public void FindToPerimeter()
        {
            perimeter = SideOfSquare * 4;
        }

        public void FindToArea()
        {
            area = SideOfSquare * SideOfSquare;
        }

        public void GetInfo()
        {
            FindToArea();
            FindToPerimeter();

            Console.WriteLine("Figure Circle is created! \n" +
                                  "Area: " + area + "\n" +
                                     "Perimetr: " + perimeter + "\n" +
                                        "Points of being: " + x + ""+ y);
        }

    }
}