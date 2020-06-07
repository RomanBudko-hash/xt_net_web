﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2.CUSTOM_PAINT
{
    public class Square : Figure, IGetInfo
    {
        private int side
        {
            get => side;

            set
            {
                if (value > 0)
                {
                    side = x;
                }
                else
                {
                    Console.WriteLine("Введено некорректное значение");
                }
            }
        }

        private int perimetr { get; set; }

        private int area { get; set; }

        public Square(int x, int y, int side) : base(x, y)
        {
            this.side = side;
        }

        public void FindToPerimetr()
        {
            perimetr = side * 4;
        }

        public void FindToArea()
        {
            area = side * side;
        }

        public void GetInfo()
        {
            Console.WriteLine("Figure Circle is created! \n" +
                                  "Area: " + area + "\n" +
                                     "Perimetr: " + perimetr + "\n" +
                                        "Points of being: " + x + y);
        }

    }
}