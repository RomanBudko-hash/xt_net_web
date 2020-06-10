using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2.CUSTOM_PAINT
{
    class Line : Figure
    {
        private int Length;
        public int length
        {
            get => Length;

            set
            {
                if (value > 0)
                {
                    Length = value;
                }
            }
        }

        public Line(int x, int y, int length) : base(x, y)
        {
            Length = length;
        }

        public override string ToString()
        {
            return "Figure Line is created! \n" +
                        "Inside perimetr: " + length + "\n" +
                            "Area: " + length + "\n" +
                                "Points of being: " + x + " " + y;
        }
    }
}
