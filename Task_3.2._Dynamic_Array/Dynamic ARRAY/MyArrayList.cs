using System.Collections.Generic;

namespace Dynamic_ARRAY
{
    public class MyArrayList<T> //: IEnumerable<T>
    {
        public T[] Array { get; set; }

        public int Length { get; set; }

        public MyArrayList() 
        {
            Array = new T[8];
        }

        public MyArrayList(int x)
        {
            Array = new T[x];
        }

        public MyArrayList(IEnumerable<T> collection)
        {
            int pieceCount = 0;
            int iterator = 0;

            foreach (var item in collection)
            {
                pieceCount++;
            }

            T [] arr = new T[pieceCount];

            foreach (var item in collection)
            {
                arr[iterator] = item;
                iterator++;
            }
        }
    }
}
