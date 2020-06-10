using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2.CUSTOM_PAINT
{
    public class CircleShape : Figure
    {
        private double InsideRadius;
        public double insideRadius
        {
            get => InsideRadius;

            set
            {
                if (value > 0)
                {
                    InsideRadius = value;
                }
            }
        }

        public double InsidePerimetr { get; set; }

        public CircleShape(int x, int y, double insideRadius) : base(x, y)
        {
            InsideRadius = insideRadius;
        }

        public virtual void FindToInsidePerimetr()
        {
            InsidePerimetr = 2 * Math.PI * InsideRadius;
        }

        public override string ToString()
        {
            FindToInsidePerimetr();
            return "Figure Circle is created! \n" +
                        "Radius: " + insideRadius + "\n" +
                            "Perimetr: " + InsidePerimetr + "\n" +
                                "Points of being: " + x + " " + y;
        }
    }
}


