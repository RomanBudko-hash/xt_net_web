using System;


namespace _1._2._2.DOUBLER
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пример строки");

            string textEnter = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(textEnter) || int.TryParse(textEnter, out int x)) // Проверка введенных значений на корректность
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
                char[] separators = new char[] { '_', '-', ':', ';', '.', ',', '!', '?', ' ' };
                string[] completeTextExample = doublerFirstRow.Split(separators, StringSplitOptions.RemoveEmptyEntries); // Избавление от разделителей
                string total = string.Join("", completeTextExample).ToLower(); // Создание строки только из букв в нижнем регистре
            }
        }
    }
}
