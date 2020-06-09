using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2.CUSTOM_PAINT
{
    public class Ring : CircleShape, IGetInfo
    {
        public new int size = 4;

        private double OutsideRadius;
        public double outsideRagius
        {
            get => OutsideRadius;

            set
            {
                if (value > 0)
                {
                    OutsideRadius = value;
                }
            }
        }

        public double OutsidePerimetr { get; set; }

        public double Area { get; set; }

        public Ring(int x, int y, double insideRadius, double outsideRadius) : base(x, y, insideRadius)
        {
            OutsideRadius = outsideRadius;
        }

        public virtual void FindToOutsidePerimetr()
        {
            OutsidePerimetr = 2 * Math.PI * OutsideRadius;
        }

        public void FindToArea()
        {
            Area = Math.PI * ((OutsideRadius * OutsideRadius) - (insideRadius * insideRadius));
        }

        void IGetInfo.GetInfo()
        {
            FindToInsidePerimetr();
            FindToArea();

            Console.WriteLine("Figure Circle is created! \n" +
                                "Outside radius: " + OutsideRadius + "\n" +
                                    "Inside radius: " + insideRadius + "\n" +
                                        "Inside perimetr: " + InsidePerimetr + "\n" +
                                            "Outside perimetr: " + OutsidePerimetr + "\n" +
                                                "Area: " + Area + "\n" +
                                                    "Points of being: " + x + ""+ y);
        }
    }
}