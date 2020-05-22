using System;


namespace _1._1._9.NON_NEGATIVE_SUM
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {0,1,2,0,4,5,101,7,0,9};

            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sum += array[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
