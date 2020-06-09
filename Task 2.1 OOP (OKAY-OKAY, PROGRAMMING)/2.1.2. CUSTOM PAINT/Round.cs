using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2.CUSTOM_PAINT
{
    public class Round : CircleShape, IGetInfo
    {
        private double insideAreaOfRound;
        protected double insideArea
        {
            get => insideAreaOfRound;

            set
            {
                if (value > 0)
                {
                    insideAreaOfRound = value;
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
            insideAreaOfRound = insideRadius * Math.PI * insideRadius;
        }

        void IGetInfo.GetInfo()
        {
            FindToArea();
            Console.WriteLine("Figure Circle is created! \n" +
                                "Radius: " + insideRadius + "\n" +
                                    "Area: " + insideAreaOfRound + "\n" +
                                        "Points of being: " + x + "" + y);
        }
    }
}