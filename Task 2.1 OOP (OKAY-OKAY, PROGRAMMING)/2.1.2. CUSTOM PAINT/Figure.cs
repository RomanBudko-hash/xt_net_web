using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2.CUSTOM_PAINT
{
    public abstract class Figure
    {
        protected int x
        {
            get => x;
            
            set
            {
                if (value > 0)
                {
                    x = value;
                }
                else
                {
                    Console.WriteLine("Uncorrect enter");
                }
            }
        }

        protected int y
        {
            get => y;

            set
            {
                if (value > 0)
                {
                    y = value;
                }
                else
                {
                    Console.WriteLine("Uncorrect enter");
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
