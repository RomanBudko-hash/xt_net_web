using System;


namespace _1._1._5.SUM_OF_NUMBERS
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] targetNumber = new int [999];

            int[] filtrNumber = new int[999];

            int x = 0;

            int countofFiltrNumbers = 0;

            for (int i = 1; i < targetNumber.Length; i++)
            {
                targetNumber[0] = 1;
                targetNumber[i] = i+1;

                if (i % 3 == 0 || i % 5 == 0)
                {
                    filtrNumber[x] = i;
                }
                x++;
            }
            for(int j = 0; j < filtrNumber.Length; j++)
            {
                countofFiltrNumbers = 
            }
            
            Console.WriteLine(string.Join(" ", targetNumber));
            Console.WriteLine();
            Console.WriteLine(string.Join(" ", filtrNumber));
            Console.ReadLine();
        }
    }
}
