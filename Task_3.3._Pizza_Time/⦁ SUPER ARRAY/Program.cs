using System;
using System.Linq;

namespace __SUPER_ARRAY
{
    public class Program
    {
        static void Main(string[] args)
        {
            int [] NumbersArray = { 1, 2, 3, 12, 4, 5, 1 };

            NumbersArray.ForeachItem( a => a * 3);

            Console.WriteLine(NumbersArray.SumOfItem() + "\n");

            Console.WriteLine(NumbersArray.AverageOfItem() + "\n");

            Console.WriteLine(NumbersArray.OftenRetry() + "\n");

            foreach (var item in NumbersArray)
            {
                Console.WriteLine(item);
            }
        }
    }
    public static class ArrayExtension
    {
        public static void ForeachItem(this int [] array, Func<int, int> func)
        {
            if (array is null || array.Length == 0)
            {
                throw new ArgumentException();
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = func(array[i]);
                }
            }
        }

        public static int SumOfItem(this int[] array)
        {
            if (array is null || array.Length == 0)
            {
                throw new ArgumentException();
            }
            else
            {
                return array.Sum();
            }
        }

        public static double AverageOfItem(this int[] array)
        {
            if (array is null || array.Length == 0)
            {
                throw new ArgumentException();
            }
            else
            {
                return array.Average();
            }
        } 

        public static int OftenRetry(this int[] array)
        {
            return 0;
        }
    }
}
