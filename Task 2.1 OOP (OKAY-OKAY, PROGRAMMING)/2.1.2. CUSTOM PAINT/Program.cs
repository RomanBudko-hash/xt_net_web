﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2.CUSTOM_PAINT
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] paramert = new int[4];

            List<Figure> saveResult = new List<Figure>();

            while (true)
            {
                Console.WriteLine("Please select the acts: ");
                Console.WriteLine("1. Add a figure");
                Console.WriteLine("2. Display the figures");
                Console.WriteLine("3. Clean all");
                Console.WriteLine("4. Exit");

                int.TryParse(Console.ReadLine(), out int userSelect2);

                switch (userSelect2)
                {
                    case 1:

                        Console.WriteLine("Please select type of a figure");
                        Console.WriteLine("1. Ring");
                        Console.WriteLine("2. CircleShape");
                        Console.WriteLine("3. Round");
                        Console.WriteLine("4. Square");
                        Console.WriteLine("5. Rectangle");
                        Console.WriteLine("6. Line");

                        int.TryParse(Console.ReadLine(), out int userSelect);

                        Console.WriteLine("Please enter all parametrs of a figure");

                        for (int j = 0; j < 4; j++)
                        {
                            int.TryParse(Console.ReadLine(), out int x);
                            paramert[j] = x;
                        }

                        switch (userSelect)
                        {
                            case 1:
                                saveResult.Add(new Ring(paramert[0], paramert[1], paramert[2], paramert[3]));
                                break;
                            case 2:
                                saveResult.Add(new CircleShape(paramert[0], paramert[1], paramert[2]));
                                break;
                            case 3:
                                saveResult.Add(new Round(paramert[0], paramert[1], paramert[2]));
                                break;
                            case 4:
                                saveResult.Add(new Square(paramert[0], paramert[1], paramert[2]));
                                break;
                            case 5:
                                saveResult.Add(new Rectangle(paramert[0], paramert[1], paramert[2], paramert[3]));
                                break;
                            case 6:
                                saveResult.Add(new Line(paramert[0], paramert[1], paramert[2]));
                                break;
                            default:
                                Console.WriteLine("This figure is have't in the Task");
                                break;
                        }
                        break;
                    case 2:
                       // IGetInfo listOfFigures = new 
                        break;
                    case 3:
                        saveResult.RemoveRange(0, (int)saveResult.LongCount());
                        break;
                    case 4:
                        return;
                }
            }
        }
    }
}
