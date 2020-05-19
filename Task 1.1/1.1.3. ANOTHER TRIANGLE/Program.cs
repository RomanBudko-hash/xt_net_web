using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1._3.ANOTHER_TRIANGLE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int numberOfDrop = 0;
            //Проверка на корректность ввода
            if(int.TryParse(Console.ReadLine(), out int x))
            {
                numberOfDrop = x;
            }
            else
            {
                Console.WriteLine("Введите корректное число");
            }
            //Рисовка треугольника
            if(numberOfDrop > 0)
            {
                for (int i = 0; i < numberOfDrop; i++)
                {
                    for(int j = numberOfDrop - i; j > 0; j--)
                    {
                        Console.Write(" ");
                    }
                    for(int k = 0; k <= 2 * i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Введите корректное число");
            }
        }
    }
}
