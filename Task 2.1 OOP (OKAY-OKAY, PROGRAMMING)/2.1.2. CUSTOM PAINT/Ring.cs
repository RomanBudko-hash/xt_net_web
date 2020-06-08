using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2.CUSTOM_PAINT
{
    public class Ring : CircleShape, IGetInfo
    {
        private double outsideRadius
        {
            get => outsideRadius;

            set
            {
                if (value > 0)
                {
                    outsideRadius = value;
                }
            }
        }

        public double outsidePerimetr { get; set; }

        public double area { get; set; }

        public Ring(int x, int y, double insideRadius, double outsideRadius) : base(x, y, insideRadius)
        {
            this.outsideRadius = outsideRadius;
        }

        public virtual void FindToOutsidePerimetr()
        {
            outsidePerimetr = 2 * Math.PI * outsideRadius;
        }

        public void FindToArea()
        {
            area = Math.PI * ((outsideRadius * outsideRadius) - (insideRadius * insideRadius));
        }

        void IGetInfo.GetInfo()
        {
            FindToInsidePerimetr();
            FindToArea();

            Console.WriteLine("Figure Circle is created! \n" +
                                "Outside radius: " + outsideRadius + "\n" +
                                    "Inside radius: " + insideRadius + "\n" +
                                        "Inside perimetr: " + insidePerimetr + "\n" +
                                            "Outside perimetr: " + outsidePerimetr + "\n" +
                                                "Area: " + area + "\n" +
                                                    "Points of being: " + x + y);
        }
    }
}