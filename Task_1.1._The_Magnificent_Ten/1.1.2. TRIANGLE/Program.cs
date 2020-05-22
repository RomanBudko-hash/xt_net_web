using System;


namespace _1._1._2.TRIANGLE
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
                for(int i = 1; i <= numberOfDrop; i++)
                {
                    for (int j = 1; j <= numberOfDrop - i; j++)
                    {
                    Console.Write("");
                    }
                    for(int k = 1; k <= i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("Введите корректное число");
            }
        }
    }
}
