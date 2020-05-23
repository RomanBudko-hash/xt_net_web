using System;


namespace _1._2._2.DOUBLER
{
    class Program
    {
        static string MethodForCreateWorkingRow(string textExample)
        {
            char[] separators = new char[] { '_', '-', ':', ';', '.', ',', '!', '?', ' ' };
            string[] completeTextExample = textExample.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return string.Join("", completeTextExample).ToLower();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите пример строки");

            string textEnter = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(textEnter))
            {
                Console.WriteLine("Введенная строка не соответствует требованиям");
            }
            else
            {
                Console.WriteLine("Введите строку, которая должна дублировать символы первой строки");

                string doublerFirstRow = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(doublerFirstRow))
                {
                    Console.WriteLine("Введенная строка не соответствует требованиям");
                }

                if (MethodForCreateWorkingRow(textEnter).Contains(MethodForCreateWorkingRow(doublerFirstRow)))
                {
                    Console.WriteLine("Пошел нахер");
                }
            }
        }
    }
}
