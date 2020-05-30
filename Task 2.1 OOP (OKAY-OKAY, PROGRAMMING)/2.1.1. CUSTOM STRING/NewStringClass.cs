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
        public static string operator +(NewStringClass twoString)
        {
            string twoStringView = twoString.ToString();
            return new string((this) + ;
        }
        public bool isContains()
        {

        }
    }
}
