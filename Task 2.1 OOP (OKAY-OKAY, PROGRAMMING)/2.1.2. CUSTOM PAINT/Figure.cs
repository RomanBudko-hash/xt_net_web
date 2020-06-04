using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2.CUSTOM_PAINT
{
    public abstract class Figure
    {
        public int x { get; } // Coordinates of center point being
        public int y { get; }

        protected Figure (int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        protected abstract void ShowInfo();
    }
}
