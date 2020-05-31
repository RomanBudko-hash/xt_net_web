using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2.CUSTOM_PAINT
{
    abstract class Figure
    {
        private double x; // Coordinate of point being
        private double y;

        public Figure (double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        abstract public int MethodForFindArea(); 
    }
}
