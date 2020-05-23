using System;
using System.Linq;

namespace _1._2._2.DOUBLER
{
    class Program
    {
        static void Main(string[] args)
        {
            string textEnter = "написать программу, которая";
            
            string secondRow = "описание";
            
            string finalString = "";

            foreach (char ch in textEnter) // Цикл, который при нахождении одинаковых символов удваивает этот символ
            {
                if (!secondRow.Contains(ch))
                {
                    finalString += ch;
                }
                else
                {
                    finalString += ch;
                    finalString += ch;
                }
            }
            Console.WriteLine(finalString);
        }
    }
}
