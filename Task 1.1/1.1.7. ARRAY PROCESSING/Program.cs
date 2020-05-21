using System;


namespace _1._1._7.ARRAY_PROCESSING
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] array = new int[10];

            var rand = new Random();

            for (int i = 0; i < array.Length; i++)// Определение рандомных чисел для массива
            {
                array[i] = rand.Next(1000);
            }
            Console.WriteLine(string.Join(" ", array));

            for (int i = 1; i < array.Length; i++)// Определение максимального числа
            {
                if (array[i] < array[i-1])
                {
                    array[i] = array[i-1];
                }
            }
            Console.WriteLine("Максимальное число = " + array[array.Length - 1]);

            for (int i = 1; i < array.Length; i++)// Определение минимального числа
            {
                if (array[i] > array[i - 1])
                {
                    array[i] = array[i - 1];
                }
            }
            Console.WriteLine("Минимальное число = " + array[array.Length - 1]);
        }
    }
}
