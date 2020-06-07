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
                if (value > 0)
                {
                    area = x;
                }
                else
                {
                    Console.WriteLine("Введено некорректое значение");
                }
            }
        }

        public Round(int x, int y, double insideRadius) : base(x, y, insideRadius)
        {
            this.insideRadius = insideRadius;
        }

        public void FindToArea()
        {
            area = insideRadius * Math.PI * insideRadius;
        }

        public void GetInfo()
        {
            Console.WriteLine("Figure Circle is created! \n" +
                               "Radius: " + insideRadius + "\n" +
                                  "Area: " + area + "\n" +
                                        "Points of being: " + x + y);

        }
    }
}