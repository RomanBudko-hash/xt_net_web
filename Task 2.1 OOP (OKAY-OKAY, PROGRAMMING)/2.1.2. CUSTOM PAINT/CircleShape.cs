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
        public double insideRadius
        {
            get => insideRadius;

            set
            {
                if (double.TryParse(Console.ReadLine(), out double x) && x > 0)
                {
                    insideRadius = x;
                }
            }
        }

        private double perimetr
        {
            get => perimetr;

            set
            {
                if (double.TryParse(Console.ReadLine(), out double x) && x > 0)
                {
                    perimetr = x;
                }
            }
        }

        public CircleShape(int x, int y, double insideRadius) : base(x, y)
        {
            this.insideRadius = insideRadius;
        }

        public void FindToPerimetr(int insideRadius)
        {
            perimetr = 2 * Math.PI * insideRadius;
        }

        public void GetInfo()
        {
            throw new NotImplementedException();
        }
    }
}

