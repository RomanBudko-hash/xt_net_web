using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2.CUSTOM_PAINT
{
    public class Square : Figure, IGetInfo
    {
        public int side
        {
            get => side;

            set
            {
                if (int.TryParse(Console.ReadLine(), out int x) || x <= 0)
                {
                    side = x;
                }
            }
        }

        public Square(int x, int y, int side) : base(x, y)
        {
            this.side = side;
        }

        public void GetInfo()
        {
            throw new NotImplementedException();
        }
    }
}