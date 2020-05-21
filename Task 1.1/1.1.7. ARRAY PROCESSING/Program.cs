using System;


namespace _1._1._7.ARRAY_PROCESSING
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] array = new int[10];

            var rand = new Random();

            int max = 0;
            int min = 1000;

            for (int i = 0; i < array.Length; i++)// Определение рандомных чисел для массива
            {
                array[i] = rand.Next(1000);
            }
            Console.WriteLine(string.Join(" ", array));

            for (int i = 0; i < array.Length - 1; i++)// Определение максимального числа
            {
                if (array[i] > array[i+1] && array[i] > max)
                {
                    max = array[i];
                }
                if(array[i] < array[i+1] && array[i+1] > max)
                {
                    max = array[i + 1];
                }
            }
            Console.WriteLine("Максимальное число = " + max);

            for (int i = 0; i < array.Length - 1; i++)// Определение минимального числа
            {
                if (array[i] < array[i + 1] && array[i] < min)
                {
                    min = array[i];
                }
                if (array[i] > array[i + 1] && array[i + 1] < min)
                {
                    min = array[i + 1];
                }
                Console.WriteLine("Минимальное число = " + min);
            }
        }
    }
}
