using System;


namespace _1._2._1.AVERAGES
{
    class Program
    {
        static void Main(string[] args)
        {
            string textExample = Console.ReadLine();

            char [] separators = new char [] { '_', '-', ':', ';', '.', ',', '!', '?', ' ' };

            var x = textExample.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (string item in x)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
