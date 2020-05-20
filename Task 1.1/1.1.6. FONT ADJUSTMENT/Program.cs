using System;


namespace _1._1._6.FONT_ADJUSTMENT
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            EnterAtTheConsole();
            int enterNumber = 0;

            if (int.TryParse(Console.ReadLine(), out int x))
            {
                enterNumber = x;
            }
            else
            {
                Console.WriteLine("Введено некорректное значение");
            }
        }

        public static string[] arrForTitle = new string[] { "None", "bold", "italic", "underline" };

        public static string s = "";

        public static void EnterAtTheConsole()
        {
            Console.WriteLine("Параметры надписи: " + arrForTitle[0]);
            Console.WriteLine("Введите:");

            for (int i = 1; i < arrForTitle.Length; i++)
            {
                Console.WriteLine(s.PadRight(7) + i + ":" + arrForTitle[i]);
            }
        }
    }
}
