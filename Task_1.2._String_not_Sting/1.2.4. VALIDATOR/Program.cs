using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2._4.VALIDATOR
{
    class Program
    {
        static void Main(string[] args)
        {
            string enter = "я плохо учил русский язык. забываю начинать предложения с заглавной. хорошо, что можно написать программу!";

            char[] enterInCharArray = enter.ToCharArray();

            for (int i = 0; i < enterInCharArray.Length - 2; i++) // Длину массива сократил на 2 т.к.
            {                                                     // считаю что предложения в 2 символа
                if (enterInCharArray[i].Equals('.')               // (где первый символ - пробел после точки) 
                 || enterInCharArray[i].Equals('!')               // - это некорректное предложение.
                 || enterInCharArray[i].Equals('?'))
                {
                    enterInCharArray[i + 2] = char.ToUpper(enterInCharArray[i + 2]);
                }
            }
            enterInCharArray[0] = char.ToUpper(enterInCharArray[0]);
            Console.WriteLine(string.Join("", enterInCharArray));
        }
    }
}


