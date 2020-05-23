using System;

namespace _1._2._1.AVERAGES
{
    class Program
    {
        static void Main(string[] args)
        {
            // При дробном значении дробная часть опускается

            string textExample = "Викентий хорошо отметил день рождения: покушал пиццу, посмотрел кино, пообщался со студентами в чате";

            char [] separators = new char [] { '_', '-', ':', ';', '.', ',', '!', '?', ' ' };

            string [] completeString = textExample.Split(separators, StringSplitOptions.RemoveEmptyEntries); // Массив строк без знаков препинания

            Console.WriteLine("Количество слов = " + completeString.Length); // Количество слов

            string singleRow = string.Join("", completeString); // Преобразование массива строк в одну строку без разделителей

            Console.WriteLine("Количество символов = " + singleRow.Length); // Количество символов в строке

            Console.WriteLine("Среднее количество знаков в слове = " + (singleRow.Length/completeString.Length)); // Вывод в консоль среднего знначения знаков в строке
        }
    }
}
