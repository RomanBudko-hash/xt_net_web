using System;


namespace _1._1._6.FONT_ADJUSTMENT
{
    public class Program
    {
        public enum TypeOfWrite
        {
            None = 0,
            bold,
            italic,
            underline
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            TypeOfWrite tow;

            tow = TypeOfWrite.None;

            EnterAtTheConsole(tow);

            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    tow = TypeOfWrite.bold;
                    break;
                case 2:
                    tow = TypeOfWrite.italic;
                    break;
                case 3:
                    tow = TypeOfWrite.underline;
                    break;
                default:
                    Console.WriteLine("Введено некорректное значение");
                    break;
            }
            EnterAtTheConsole(tow);
        }

        public static string s = "";

        public static void EnterAtTheConsole(TypeOfWrite x)
        {
            Console.WriteLine("Параметры надписи: " + x);
            Console.WriteLine("Введите:");
            Console.WriteLine(s.PadRight(7) + "1: " + TypeOfWrite.bold);
            Console.WriteLine(s.PadRight(7) + "2: " + TypeOfWrite.italic);
            Console.WriteLine(s.PadRight(7) + "3: " + TypeOfWrite.underline);
        }


    }
}
