using System;


namespace _1._1._10._2D_ARRAY
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3,4];

            int sum = 0;
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum++;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
