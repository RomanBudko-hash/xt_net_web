using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2.CUSTOM_PAINT
{
    public class Round : CircleShape
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
        }

        public void FindToArea()
        {
            insideAreaOfRound = insideRadius * Math.PI * insideRadius;
        }

        public override string ToString()
        {
            FindToArea();

            return "Figure Round is created! \n" +
                        "Radius: " + insideRadius + "\n" +
                            "Area: " + insideAreaOfRound + "\n" +
                                "Points of being: " + x + " " + y;
        }
    }
}