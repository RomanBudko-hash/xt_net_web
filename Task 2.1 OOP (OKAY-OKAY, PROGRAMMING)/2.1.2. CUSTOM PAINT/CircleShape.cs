using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2.CUSTOM_PAINT
{
    public class CircleShape : Figure
    {
        public int insideRadius { get; }

        private int lenghtCircleShape
        {
            get => Perimetr;
        }

        public CircleShape(int x, int y, int insideRadius) : base(x, y) 
        {
            this.insideRadius = insideRadius;
        }

        public int Perimetr(int insideRadius)
        {
            Perimetr = 2* Math.PI * insideRadius;
            return Perimetr;
        }

        public void ShowInfo()
        {

        }
    }
}
        
