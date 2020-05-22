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
            TypeOfWrite wot;
            tow = TypeOfWrite.None;
            wot = TypeOfWrite.bold;

            EnterAtTheConsole(tow);
            Check(out tow);
            EnterAtTheConsole(tow);
            Check(out wot);
            EnterAtTheConsole(tow, wot);
            Check(out tow);
            EnterAtTheConsole(tow);
        }

        public static string s = "";

        public static void EnterAtTheConsole(TypeOfWrite x)// Метод для отображения в консоль с 1 параметром
        {
            Console.WriteLine("Параметры надписи: " + x);
            Console.WriteLine("Введите:");
            Console.WriteLine(s.PadRight(7) + "1: " + TypeOfWrite.bold);
            Console.WriteLine(s.PadRight(7) + "2: " + TypeOfWrite.italic);
            Console.WriteLine(s.PadRight(7) + "3: " + TypeOfWrite.underline);
        }
        public static void EnterAtTheConsole(TypeOfWrite x, TypeOfWrite y)// Метод для отображения в консоль с 2 параметрами
        {
            Console.WriteLine("Параметры надписи: " + x + " " + y);
            Console.WriteLine("Введите:");
            Console.WriteLine(s.PadRight(7) + "1: " + TypeOfWrite.bold);
            Console.WriteLine(s.PadRight(7) + "2: " + TypeOfWrite.italic);
            Console.WriteLine(s.PadRight(7) + "3: " + TypeOfWrite.underline);
        }
        public static void Check(out TypeOfWrite x) // Проверка ввода
        {
            x = 0;
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    x = TypeOfWrite.bold;
                    break;
                case 2:
                    x = TypeOfWrite.italic;
                    break;
                case 3:
                    x = TypeOfWrite.underline;
                    break;
                default:
                    Console.WriteLine("Введено некорректное значение");
                    break;
            }
        }
    }
}
