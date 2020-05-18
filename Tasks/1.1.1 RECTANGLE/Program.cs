using System;


namespace _1._1._1_RECTANGLE
{
    class Program
    {
        static void Main(string[] args)
        {
            int aSide = 0;

            Console.WriteLine("Введите размер первой стороны");

            CheckOfNumber(ref aSide);

            int bSide = 0;

            Console.WriteLine("Введите размер другой стороны");

            CheckOfNumber(ref bSide);

            CountOfRectangleArea(aSide, bSide);
        }
        //Метод для проверки введенного числа на корректность

        static void CheckOfNumber(ref int targetNumber)
        {
            if(int.TryParse(Console.ReadLine(), out int x))
            {
                targetNumber = x;
            }
            else
            {
                CheckOfNumber(ref targetNumber);
            }
        }
        //Метод для дальнейшей проверки числа на неотрицательность, дальнейшее решение
        
        static void CountOfRectangleArea(int aSide, int bSide)
        {
            if (aSide <= 0 || bSide <= 0)
            {
                Console.WriteLine("Некорректный ввод сторон прямоугольника");
            }
            else
            {
                int area = aSide * bSide;

                Console.WriteLine("Площадь прямоугольника = " + area);
            }
        }
    }
}
