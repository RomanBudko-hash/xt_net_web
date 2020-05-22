using System;


namespace _1._1._8.NO_POSITIVE
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] arr = new int[2, 2, 2];

            var rand = new Random();

            for (int i = 0; i < arr.GetLength(0); i++) // Наградил каждый элемент массива рандомным числом
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int n = 0; n < arr.GetLength(2); n++)
                    {
                        arr[i, j, n] = rand.Next(5);

                        Console.Write(arr[i, j, n] + " ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Разделитель между двумя вариантами");

            for (int i = 0; i < arr.GetLength(0); i++) // Заменил все положительные числа на нули
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int n = 0; n < arr.GetLength(2); n++)
                    {
                        if (arr[i, j, n] > 0)
                        {
                            arr[i, j, n] = 0;
                        }
                        Console.Write(arr[i, j, n] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
