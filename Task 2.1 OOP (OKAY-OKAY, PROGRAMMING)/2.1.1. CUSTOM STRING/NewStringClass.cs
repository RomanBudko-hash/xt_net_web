using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._1.CUSTOM_STRING
{
    public sealed class NewStringClass
    {
        private char[] someString;

        public NewStringClass(char [] someString)
        {
            this.someString = someString;
        }

        public bool CompareTwoStrings(char [] first, char [] second)
        {
            bool result = false;

            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] == second[i] && first.Length == second.Length)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }
    }
}
