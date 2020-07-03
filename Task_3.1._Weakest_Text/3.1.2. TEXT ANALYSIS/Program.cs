using System;
namespace _3._1._2.TEXT_ANALYSIS
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;

            AHeartOfProject aHeart = new AHeartOfProject();

            Console.WriteLine(aHeart.Titul.PadLeft(50));

            string example = Console.ReadLine();

            var s = aHeart.FindRetryWords(aHeart.DeleteCharacters
                (aHeart.CheckPhraseOnNullOrWhiteSpace(example)));

            Console.WriteLine(string.Join(" ", s));
            Console.WriteLine(string.Join(" ", aHeart.ResultWriting(s)));
        }
    }
}
