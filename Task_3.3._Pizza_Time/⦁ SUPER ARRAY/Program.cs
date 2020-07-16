using System;
using System.Linq;

namespace __SUPER_ARRAY
{
    public class Program
    {
        static void Main(string[] args)
        {
            int [] NumbersArray = { 1, 2, 3, 12, 4, 5, 1 };

            Console.WriteLine("Сумма всех элементов = " + NumbersArray.SumOfItem() + "\n");

            Console.WriteLine("Среднее = " + NumbersArray.AverageOfItem() + "\n");

            Console.WriteLine("Часто повторяющееся значение = " + NumbersArray.OftenRetry() + "\n");

            NumbersArray.ForeachItem(a => a * 3);

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

        public static T OftenRetry<T>(this T[] array)
        {
            if (array is null || array.Length == 0)
            {
                throw new ArgumentException();
            }
            else
            {
                return array.GroupBy(item => item).OrderBy(elem => elem.Count()).Last().Key;
            }
        }
    }
}
