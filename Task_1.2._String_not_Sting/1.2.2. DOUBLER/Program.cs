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

            foreach (char item in textEnter) // Цикл, который при нахождении одинаковых символов удваивает этот символ
            {
                if (!secondRow.Contains(item))
                {
                    finalString += item;
                }
                else
                {
                    finalString += item;
                    finalString += item;
                }
            }
            Console.WriteLine(finalString);
        }
    }
}
