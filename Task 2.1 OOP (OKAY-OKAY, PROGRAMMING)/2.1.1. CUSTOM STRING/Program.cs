using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._1.CUSTOM_STRING
{
    class Program
    {
        static void Main(string[] args)
        {
            NewStringClass myFirstString = new NewStringClass(new char[] { 'b', 'b', 'c' });
            NewStringClass mySecondString = new NewStringClass(new char[] { 'b', 'c' });

            Console.WriteLine(myFirstString.IsContains(mySecondString));
            
        }
    }
}
