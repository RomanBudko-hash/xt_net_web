using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2.CUSTOM_PAINT
{
    class Line : Figure, IGetInfo
    {
        private int length
        {
            get => length;

            set
            {
                if (value > 0)
                {
                    length = value;
                }
            }
        }

        public Line(int x, int y, int length) : base(x, y)
        {
            this.length = length;
        }

        void IGetInfo.GetInfo()
        {
            Console.WriteLine("Figure Line is created! \n" +
                                "Inside perimetr: " + length + "\n" +
                                    "Area: " + length + "\n" +
                                        "Points of being: " + x + y);
        }
    }
}
