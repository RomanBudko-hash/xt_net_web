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

            int userSelect;
            int[] paramert = new int[4];
            List<object> saveResult = new List<object>();

            while (true)
            {
                Console.WriteLine("Please select type of a figure");
                Console.WriteLine("1. Ring");
                Console.WriteLine("2. CircleShape");
                Console.WriteLine("3. Round");
                Console.WriteLine("4. Square");
                Console.WriteLine("5. Rectangle");
                Console.WriteLine("6. Line");

                int.TryParse(Console.ReadLine(), out int i);
                userSelect = i;

                Console.WriteLine("Please enter all parametrs of a figure");

                for (int j = 0; j < 4; j++)
                {
                    int.TryParse(Console.ReadLine(), out int x);
                    paramert[j] = x;
                }

                switch (userSelect)
                {
                    case 1:
                        new Ring(paramert[0], paramert[1], paramert[2], paramert[3]);
                        break;
                    case 2:
                        new CircleShape(paramert[0], paramert[1], paramert[2]);
                        break;
                    case 3:
                        new Round(paramert[0], paramert[1], paramert[2]);
                        break;
                    case 4:
                        new Square(paramert[0], paramert[1], paramert[2]);
                        break;
                    case 5:
                        new Rectangle(paramert[0], paramert[1], paramert[2], paramert[3]);
                        break;
                    case 6:
                        new Line(paramert[0], paramert[1], paramert[2]);
                        break;
                }

                saveResult.Add(userSelect);

                Console.WriteLine("Please select the acts: ");
                Console.WriteLine("1. Add a figure");
                Console.WriteLine("2. Display the figures");
                Console.WriteLine("3. Clean all");
                Console.WriteLine("4. Exit");



            }
        }
    }
}
