using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2.CUSTOM_PAINT
{
    public abstract class Figure
    {
        private int X;

        protected int x
        {
            get => X;

            set
            {
                if (value > 0)
                {
                    X = value;
                }
            }
        }
        private int Y;

        protected int y
        {
            get => Y;

            set
            {
                if (value > 0)
                {
                    Y = value;
                }
            }
        }

        protected Figure(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
