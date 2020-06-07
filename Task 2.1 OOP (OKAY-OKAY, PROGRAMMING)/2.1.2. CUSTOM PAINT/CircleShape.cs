using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2.CUSTOM_PAINT
{
    public class CircleShape : Figure, IGetInfo
    {
        protected double insideRadius
        {
            get => insideRadius;

            set
            {
                if (value > 0)
                {
                    insideRadius = x;
                }
                else
                {
                    Console.WriteLine("Uncorrect enter");
                }
            }
        }

        public double perimetr { get; set; }

        public CircleShape(int x, int y, double insideRadius) : base(x, y)
        {
            this.insideRadius = insideRadius;
            Console.WriteLine("CircleShape is created!!!");
        }

        public void FindToPerimetr()
        {
            perimetr = 2 * Math.PI * insideRadius;
        }

        public void GetInfo()
        {
            FindToPerimetr();
            Console.WriteLine("Figure Circle is created! \n" +
                               "Radius: " + insideRadius + "\n" +
                                     "Perimetr: " + perimetr + "\n" +
                                        "Points of being: " + x + y);

        }
    }
}


