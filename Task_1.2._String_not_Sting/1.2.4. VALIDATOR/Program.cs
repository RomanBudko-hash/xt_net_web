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

            for (int i = 0; i < enterInCharArray.Length - 2; i++)
            {
                if (enterInCharArray[i].Equals('.')
                 || enterInCharArray[i].Equals('!')
                 || enterInCharArray[i].Equals('?'))
                {
                    enterInCharArray[i + 2] = char.ToUpper(enterInCharArray[i+2]);
                }
            }

            Console.WriteLine(string.Join("", enterInCharArray));
        }
    }
}


