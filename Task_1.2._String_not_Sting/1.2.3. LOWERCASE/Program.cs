using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Был выбран пример со *
namespace _1._2._3.LOWERCASE
{
    class Program
    {
        static void Main(string[] args)
        {
            string theMainRow = "Антон хорошо начал утро: послушал Стинга, выпил кофе и посмотрел Звёздные Войны";

            char[] separators = new char[] { '_', '-', ':', ';', '.', ',', '!', '?', ' ' };

            string[] breakTheMainRow = theMainRow.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            int result = 0;

            for (int i = 0; i < breakTheMainRow.Length; i++) // Цикл, проверяющий является ли слово в массиве большебуквеннным
            {
                if (char.IsLower(breakTheMainRow[i][0]))
                {
                    result++;
                }
            }
            Console.WriteLine(result);
        }
    }
}
