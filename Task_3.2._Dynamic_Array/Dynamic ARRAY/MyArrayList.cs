using System;
using System.Collections.Generic;

namespace Dynamic_ARRAY
{
    public class MyArrayList<T> //: IEnumerable, IEnumerable<T>
    {
        public T[] Array { get; set; }

        private int length;

        public int Length 
        { 
            get => length;

            set 
            {
                foreach (var item in Array)
                {
                    length++;
                }
            } 
        }

        public int Capacity
        { 
            get => length;

            set
            {
                if (value < length)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (value > length)
                {
                    T[] array = new T[value];

                    Array.CopyTo(array, 0);
                }
            }
        }

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
            int index = 0;

            foreach (var item in collection)
            {
                pieceCount++;
            }

            T [] arr = new T[pieceCount];

            foreach (var item in collection)
            {
                arr[index] = item;
                index++;
            }
        }

        public void Add(T item)
        {
            if (Capacity == length)
            {
                T[] arr = new T[Capacity * 2];
                Array.CopyTo(arr, 0);
                Array = arr;

            }

            Array[length] = item;
            length++;
        }


    }
}
