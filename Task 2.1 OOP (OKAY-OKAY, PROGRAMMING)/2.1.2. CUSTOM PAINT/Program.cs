using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2.CUSTOM_PAINT
{
    class Program
    {
        static void Main(string[] args)
        {
            int enterParametr1;
            int enterParametr2;
            int enterParametr3;
            int enterParametr4;
            int enterParametr5;
            int enterParametr6;
            int userSelect;
            while (true)
            {
                Console.WriteLine("Please select type of a figure");
                Console.WriteLine("1. Ring");
                Console.WriteLine("2. CircleShape");
                Console.WriteLine("3. Round");
                Console.WriteLine("4. Square");
                Console.WriteLine("5. Rectangle");
                Console.WriteLine("6. Line");

                var firstEnter = int.TryParse(Console.ReadLine(), out int i);
                userSelect = i;

                Console.WriteLine("Please enter all parametrs of a figure");

                switch (userSelect)
                {
                    case 1:
                        //new Ring(enterParametr1, enterParametr2, enterParametr3);
                        break;
                    case 2:
                        new CircleShape(enterParametr1, enterParametr2, enterParametr3);
                        break;
                    case 3:
                        new Round(enterParametr1, enterParametr2, enterParametr3);
                        break;
                    case 4:
                        new Square(enterParametr1, enterParametr2, enterParametr3);
                        break;
                    case 5:
                        new Rectangle(enterParametr1, enterParametr2, enterParametr3, enterParametr4);
                        break;
                    case 6:
                        //new Line(enterParametr1, enterParametr2, enterParametr3);
                        break;
                }

                Console.WriteLine("Please select the acts: ");
                Console.WriteLine("1. Add a figure");
                Console.WriteLine("2. Display the figures");
                Console.WriteLine("3. Clean all");
                Console.WriteLine("4. Exit");

            }
        }
    }
}
