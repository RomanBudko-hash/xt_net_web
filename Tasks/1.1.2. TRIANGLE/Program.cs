using System;


namespace _1._1._2.TRIANGLE
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDrop = 0;

            if(int.TryParse(Console.ReadLine(), out int x))
            {
                numberOfDrop = x;
            }
            else
            {
                Console.WriteLine("Введите корректное число");
            }
            
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
