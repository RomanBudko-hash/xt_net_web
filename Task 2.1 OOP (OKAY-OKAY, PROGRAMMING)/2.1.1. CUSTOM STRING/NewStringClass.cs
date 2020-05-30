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
        private char[] someString;

        public NewStringClass(char[] someString) => this.someString = someString; // В моей реализации только один конструктор

        public override string ToString() // Переопределенный ТуСтринг
        {
            return new string (someString);
        }
        public bool CompareTwoStrings(NewStringClass anotherString) // Метод сравнения
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
        public char this [int index] // Индексатор
        {
            get
            {
                return someString[index];
            }
            set
            {
                someString[index] = value;
            }
        }
        public int SearchOfString(char anyChar) // Поиск символа в строке
        {
            if (someString.Contains(anyChar))
            {
                return Array.IndexOf(someString, anyChar);
            }
            else
            {
                return -1;
            }
        }
        public static NewStringClass operator +(NewStringClass oneString, NewStringClass twoString) // Конкатенация
        {
            return new NewStringClass(oneString.someString.Concat(twoString.someString).ToArray());
        }
        public static explicit operator char [] (NewStringClass oneString) // Преобразование NewStringClass в массив
        {
            char[] array = new char [oneString.someString.Length];
            Array.Copy(oneString.someString, 0, array, 0, array.Length);
            return array;
        }
        public static explicit operator NewStringClass(char[] arr) // Преобразование из массива в NewStringClass
        {
            return new NewStringClass (arr);
        }
    }
}
