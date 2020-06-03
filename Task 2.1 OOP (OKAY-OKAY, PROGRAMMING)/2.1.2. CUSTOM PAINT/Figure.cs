using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2.CUSTOM_PAINT
{
    public abstract class Figure
    {
        private int x; // Coordinates of center point being
        private int y;

        protected Figure (int x, int y)
        {
            if (!string.IsNullOrWhiteSpace && int.TryParse(Console.ReadLine(), out int someNumber))
            {
                this.x = x;
                this.y = y;
            }
        }
        protected abstract int FindArea();
        protected abstract int FindPerimetr();
        protected abstract void ShowInfo();
    }
}
