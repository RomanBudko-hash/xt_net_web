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
            int[] parameter = new int[5];

            List<Figure> saveResult = new List<Figure>();

            while (true)
            {
                Console.WriteLine("Please select the acts: ");
                Console.WriteLine("1. Add a figure");
                Console.WriteLine("2. Display the figures");
                Console.WriteLine("3. Clean all");
                Console.WriteLine("4. Exit");

                int.TryParse(Console.ReadLine(), out int userSelect);

                switch (userSelect)
                {
                    case 1:

                        Console.WriteLine("Please select type of a figure");
                        Console.WriteLine("1. Ring");
                        Console.WriteLine("2. CircleShape");
                        Console.WriteLine("3. Round");
                        Console.WriteLine("4. Square");
                        Console.WriteLine("5. Rectangle");
                        Console.WriteLine("6. Line");
                        Console.WriteLine("7. Triangle");

                        int.TryParse(Console.ReadLine(), out int userSelect2);

                        Console.WriteLine("Please enter all parametrs of a figure (x, y)");
                        Console.WriteLine("For ring, except coordinate points please write two parameters: " +
                            "inside radius and outside radius \n" +
                            "For circleshape, except coordinate points please write one parameter: inside radius \n" +
                            "For round, except coordinate points please write one parameter: inside radius \n" +
                            "For square, except coordinate points please write one parameter: side \n" +
                            "For rectangle, except coordinate points please write two parameters: side A and side B \n" +
                            "For line, except coordinate points please write one parameter: length of line \n" +
                            "For triangle, except coordinate points please write three parameters: the length of each side \n");

                        for (int j = 0; j < 5; j++)
                        {
                            int.TryParse(Console.ReadLine(), out int x);

                            if (x <= 0 || string.IsNullOrWhiteSpace(x.ToString()))
                            {
                                userSelect2 = 8;
                            }
                            parameter[j] = x;
                        }

                        switch (userSelect2)
                        {
                            case 1:
                                saveResult.Add(new Ring(parameter[0], parameter[1], parameter[2], parameter[3]));
                                break;
                            case 2:
                                saveResult.Add(new CircleShape(parameter[0], parameter[1], parameter[2]));
                                break;
                            case 3:
                                saveResult.Add(new Round(parameter[0], parameter[1], parameter[2]));
                                break;
                            case 4:
                                saveResult.Add(new Square(parameter[0], parameter[1], parameter[2]));
                                break;
                            case 5:
                                saveResult.Add(new Rectangle(parameter[0], parameter[1], parameter[2], parameter[3]));
                                break;
                            case 6:
                                saveResult.Add(new Line(parameter[0], parameter[1], parameter[2]));
                                break;
                            case 7:
                                saveResult.Add(new Triangle(parameter[0], parameter[1], parameter[2], parameter[3], parameter[4]));
                                break;
                            default:
                                Console.WriteLine("This figure is have't in the Task");
                                break;
                        }
                        break;
                    case 2:
                        for (int i = 0; i < saveResult.Count; i++)
                        {
                            Console.WriteLine(saveResult[i].ToString());
                        }
                        break;
                    case 3:
                        saveResult.Clear();
                        break;
                    case 4:
                        return;
                }
            }
        }
    }
}
