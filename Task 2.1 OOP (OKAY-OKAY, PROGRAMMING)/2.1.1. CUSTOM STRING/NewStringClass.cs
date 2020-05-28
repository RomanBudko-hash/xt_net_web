using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._1.CUSTOM_STRING
{
    public sealed class NewStringClass
    {
        public char[] someString;

        public NewStringClass(char [] someString)
        {
            this.someString = someString;
        }

        public void CompareTwoStrings(char [] first, char [] second)
        {
            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] == second[i])
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
        }
    }
}
