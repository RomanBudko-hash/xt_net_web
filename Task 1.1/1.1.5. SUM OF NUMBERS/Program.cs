using System;


namespace _1._1._5.SUM_OF_NUMBERS
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] targetNumber = new int [999];// Массив для хранения всех чисел в выборке

            int[] filtrNumber = new int[999]; // Массив для отфильтрованных чисел

            int x = 0; // Переменная для удобства отсеивания

            int countofFiltrNumbers = 0; // Итоговая сумма всех чисел

            for (int i = 1; i < targetNumber.Length; i++)//Заполнение массива натуральными числами
            {
                targetNumber[0] = 1;
                targetNumber[i] = i+1;

                if (i % 3 == 0 || i % 5 == 0) //Отсеивание кратных 3м и 5и чисел
                {
                    filtrNumber[x] = i;
                }
                x++;
            }

            for(int j = 0; j < filtrNumber.Length; j++)//Нахождение итогового числа
            {
                countofFiltrNumbers += filtrNumber[j];
            }
            
            Console.WriteLine(countofFiltrNumbers);
            Console.ReadLine();
        }
    }
}
