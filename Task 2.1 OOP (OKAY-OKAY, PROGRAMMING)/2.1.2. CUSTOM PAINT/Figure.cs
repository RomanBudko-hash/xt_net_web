using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2.CUSTOM_PAINT
{
    abstract class Figure
    {
        public int x; // Coordinate of point being
        public int y;

        public Figure (int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public abstract int MethodForFindArea();
        public abstract int MetodForFindPerimetr();
        public abstract void ShowInfo();
    }
}
