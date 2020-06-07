using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2.CUSTOM_PAINT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> countOfObjects = new List<int>();

            while (true)
            {
                Console.WriteLine("Please select the acts: ");
                Console.WriteLine("1. Add a figure");
                Console.WriteLine("2. Display the figures");
                Console.WriteLine("3. Clean all");
                Console.WriteLine("4. Exit");

                var enter = int.TryParse(Console.ReadLine(), out int x);

                switch (x)
                {
                    case 1:
                        Console.WriteLine("Please select type of a figure");
                        break;
                }
            }
        }
    }
}
