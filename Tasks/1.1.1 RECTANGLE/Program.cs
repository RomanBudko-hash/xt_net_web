using System;


namespace _1._1._1_RECTANGLE
{
    class Program
    {
        static void Main(string[] args)
        {
            int aSide = 0;

            Console.WriteLine("Введите размер первой стороны");
            
            if (int.TryParse(Console.ReadLine(), out int x))
            {
                aSide = x;
            }

            int bSide = 0;

            Console.WriteLine("Введите размер другой стороны");

            if (int.TryParse(Console.ReadLine(), out int y))
            {
                bSide = y;
            }


            CountOfRectangleArea(aSide, bSide);
        }

        
        
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
