using System;


namespace _1._2._1.AVERAGES
{
    class Program
    {
        static void Main(string[] args)
        {
            string textExample = "Викентий хорошо отметил день рождения: покушал пиццу, посмотрел кино, пообщался со студентами в чате";

            char [] separators = new char [] { '_', '-', ':', ';', '.', ',', '!', '?', ' ' };

            string [] completeString = textExample.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(completeString.Length); // Количество слов

        }
    }
}
