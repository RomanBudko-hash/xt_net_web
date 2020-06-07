using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2.CUSTOM_PAINT
{
    public class Round : CircleShape, IGetInfo
    {
        private double area
        {
            get => area;

            set
            {
                if (int.TryParse(Console.ReadLine(), out int x) && x > 0)
                {
                    area = x;
                }
                else
                {
                    Console.WriteLine("Uncorrect enter");
                }
            }
        }

        public Round(int x, int y, double insideRadius) : base(x, y, insideRadius)
        {
            this.insideRadius = insideRadius;
            Console.WriteLine("Round is created!!!");
        }

        public void FindToArea()
        {
            area = insideRadius * Math.PI * insideRadius;
        }

        void IGetInfo.GetInfo()
        {
            FindToArea();
            FindToPerimetr();
            Console.WriteLine("Figure Circle is created! \n" +
                               "Radius: " + insideRadius + "\n" +
                                  "Area: " + area + "\n" +
                                        "Points of being: " + x + y);

        }
    }
}