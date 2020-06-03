using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2.CUSTOM_PAINT
{
    abstract class CircleShape : Figure
    {
        private int _insideRadius;

        protected CircleShape(int x, int y, int insideRadius) : base (x, y)
        {
            base;
            if (!string.IsNullOrWhiteSpace && int.TryParse(Console.ReadLine(), out int someNumber))
            {
                insideRadius = _insideRadius;
            }
        }
        protected abstract int MethodForFindArea(int _insideRadius)
        {
            return radius * Math.PI * radius;
        }
        protected abstract int MetodForFindPerimetr(int _insideRadius)
        {
            return 2 * radius * Math.PI;
        }
        protected void ShowInfo(int _insideRadius, int MethodForFindArea, int MetodForFindPerimetr, int x, int y)
        {
            Console.WriteLine("Figure Circle is created! \n" +
                               "Radius: " + _insideRadius + "\n" +
                                  "Area: " + MethodForFindArea + "\n" +
                                     "Perimetr: " + MetodForFindPerimetr + "\n" +
                                        "Points of being: " + x + y);
        }
    }
}
        
