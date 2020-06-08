﻿using System;
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
                    insideRadius = value;
                }
                else
                {
                    Console.WriteLine("Uncorrect enter");
                }
            }
        }

        public double insidePerimetr { get; set; }

        public CircleShape(int x, int y, double insideRadius) : base(x, y)
        {
            this.insideRadius = insideRadius;
            Console.WriteLine("CircleShape is created!!!");
        }

        public virtual void FindToInsidePerimetr()
        {
            insidePerimetr = 2 * Math.PI * insideRadius;
        }

        public void GetInfo()
        {
            FindToInsidePerimetr();
            Console.WriteLine("Figure Circle is created! \n" +
                                "Radius: " + insideRadius + "\n" +
                                   "Perimetr: " + insidePerimetr + "\n" +
                                       "Points of being: " + x + y);
        }
    }
}


