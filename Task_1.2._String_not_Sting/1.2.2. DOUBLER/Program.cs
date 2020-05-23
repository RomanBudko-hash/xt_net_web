using System;


namespace _1._2._2.DOUBLER
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пример строки");

            string textEnter = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(textEnter))
            {
                Console.WriteLine("Введенная строка не соответствует требованиям");
            }
            string doublerFirstRow = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(doublerFirstRow))
            {
                Console.WriteLine("Введенная строка не соответствует требованиям");
            }

        }
    }
}
