using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._1.CUSTOM_STRING
{
    public class NewStringClass
    {
        public char[] someString;

        public NewStringClass(char[] someString) => this.someString = someString; // В моей реализации только один конструктор

        public override string ToString() // Переопределенный ТуСтринг
        {
            return new string (someString);
        }
        public bool CompareTwoStrings(NewStringClass anotherString) // Метод сравнения двух стрингов
        {
            string two = anotherString.ToString();
            string one = ToString();
            char[] oneStringView = one.ToCharArray();
            char[] twoStringView = two.ToCharArray();
            bool result = false;

            if (one.Length == two.Length)
            {
                for (int i = 0; i < one.Length; i++)
                { 
                    if (oneStringView[i] == twoStringView[i])
                    {
                        result = true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                result = false;
            }
            return result;
        }
        public bool IsContains(NewStringClass anotherString) // Метод, возвращающий true при нахождении подстроки внутри строки
        {
            string two = anotherString.ToString();
            string one = ToString();
            char[] oneStringView = one.ToCharArray();
            char[] twoStringView = two.ToCharArray();

            bool result;
            int[] saveControlResults = new int [oneStringView.Length];
            int sumOfchars = 0;

            for (int i = 0; i < oneStringView.Length; i++)
            {
                for (int j = 0;  j < two.Length;  j++)
                {
                    if (oneStringView[i] != twoStringView[j])
                    {
                        saveControlResults[i] = 0;
                    }
                    else
                    {
                        saveControlResults[i] = 1;
                    }
                }
            }
            for (int i = 0; i < saveControlResults.Length; i++)
            {
                sumOfchars += saveControlResults[i];
            }
            if (sumOfchars == two.Length)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
