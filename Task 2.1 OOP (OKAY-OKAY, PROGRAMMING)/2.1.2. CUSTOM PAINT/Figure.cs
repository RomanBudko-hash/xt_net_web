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
                if (int.TryParse(Console.ReadLine(), out int x) && x > 0)
                {
                    this.x = x;
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
                if (int.TryParse(Console.ReadLine(), out int y) && y > 0)
                {
                    this.y = y;
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
