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
                if (double.TryParse(Console.ReadLine(), out double x) && x > 0)
                {
                    area = x;
                }
            }
        }

        public Round(int x, int y, int insideRadius) : base(x, y, insideRadius)
        {
            this.insideRadius = insideRadius;
        }

        public void FindToArea(int insideRadius)
        {
            area = insideRadius * Math.PI * insideRadius;
        }

        public void GetInfo()
        {
            throw new NotImplementedException();
        }
    }
}