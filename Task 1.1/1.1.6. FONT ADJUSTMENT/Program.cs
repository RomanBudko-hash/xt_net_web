using System;


namespace _1._1._6.FONT_ADJUSTMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            string[] arrForTitle = new string [] { "None", "bold", "italic", "underline" };

            string s = "";

            Console.WriteLine("Параметры надписи: " + arrForTitle[0]);
            Console.WriteLine("Введите:");
            
            for (int i = 1; i <arrForTitle.Length; i++)
            {
                Console.WriteLine(s.PadRight(7) + i + ":" + arrForTitle[i]);
            }
            int enterNumber = int.Parse(Console.ReadLine());
        }
    }
}
