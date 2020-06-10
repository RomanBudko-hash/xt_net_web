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

        public NewStringClass(char[] someString) => this.someString = someString;

        public override string ToString()
        {
            return new string(someString);
        }

        public bool CompareTwoStrings(NewStringClass anotherString)
        {
            char[] oneStringView = ToString().ToCharArray();

            char[] twoStringView = anotherString.ToString().ToCharArray();

            bool result = false;

            if (oneStringView.Length == twoStringView.Length)
            {
                for (int i = 0; i < oneStringView.Length; i++)
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

        public char this[int index]
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

        public int SearchOfString(char anyChar)
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

        public static NewStringClass operator +(NewStringClass oneString, NewStringClass twoString)
        {
            return new NewStringClass(oneString.someString.Concat(twoString.someString).ToArray());
        }

        public static explicit operator char[](NewStringClass oneString)
        {
            char[] array = new char[oneString.someString.Length];
            Array.Copy(oneString.someString, 0, array, 0, array.Length);
            return array;
        }

        public static explicit operator NewStringClass(char[] arr)
        {
            return new NewStringClass(arr);
        }


    }
}
