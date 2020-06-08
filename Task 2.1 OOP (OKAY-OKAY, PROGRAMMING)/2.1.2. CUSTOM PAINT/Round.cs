using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2.CUSTOM_PAINT
{
    public class Round : CircleShape, IGetInfo
    {
        protected double insideArea
        {
            get => insideArea;

            set
            {
                if (value > 0)
                {
                    insideArea = value;
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
            insideArea = insideRadius * Math.PI * insideRadius;
        }

        void IGetInfo.GetInfo()
        {
            FindToArea();
            Console.WriteLine("Figure Circle is created! \n" +
                                "Radius: " + insideRadius + "\n" +
                                    "Area: " + insideArea + "\n" +
                                        "Points of being: " + x + y);
        }
    }
}