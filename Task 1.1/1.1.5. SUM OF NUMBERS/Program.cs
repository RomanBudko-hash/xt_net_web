using System;


namespace _1._1._5.SUM_OF_NUMBERS
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] targetNumber = new int [999];

            for (int i = 1; i < targetNumber.Length; i++)
            {
                targetNumber[0] = 1;
                targetNumber[i] = i+1;
            }

            Console.WriteLine(string.Join(" ", targetNumber));
            Console.ReadLine();
        }
    }
}
