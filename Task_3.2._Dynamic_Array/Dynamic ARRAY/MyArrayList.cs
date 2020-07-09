using System;
using System.Collections;
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
                    length = value++;
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
            Length++;
        }

        public void AddRange(IEnumerable<T> collection)
        {
            int countCollection = 0;

            int oldLength = Length;

            if (collection is null)
            {
                throw new ArgumentNullException();
            }

            foreach (var item in collection)
            {
                countCollection++;
            }

            if (Length + countCollection > Capacity)
            {
                T[] arr = new T[Length + countCollection + 1];

                foreach (var item in collection)
                {
                    arr[oldLength + 1] = item;
                    oldLength++;
                }
            }
            else
            {
                foreach (var item in collection)
                {
                    Array[Length + 1] = item;
                    Length++;
                }
            }
        }

        public bool Remove(int index)
        {
            if (index >= Length || index < 0)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < Length - 1; i++)
                {
                    if (i == index && index != Length - 1)
                    {
                        Array[i] = Array[i+1];
                    }
                    if(index == Length - 1)
                    {
                        Length--;
                    }
                    if (i > index)
                    {
                        Array[i] = Array[i-1];
                    }
                }
                return true;
            }
        }

        public bool Insert(int index, T item)
        {
            if (index > Length)
            {
                return false;
                throw new ArgumentOutOfRangeException();
            }
            if (Length == Capacity)
            {
                T[] arr = new T[Capacity + 1];

                for (int i = 0; i < arr.Length; i++)
                {
                    if (i == index)
                    {
                        for (int j = arr.Length - 1; j > index; j--)
                        {
                            arr[j] = arr[j-1];
                        }
                        arr[i] = item;
                    }
                }
            }
            return true;
        }

        //public IEnumerator GetEnumerator()
        //{
        //}

        //IEnumerator<T> IEnumerable<T>.GetEnumerator()
        //{
        //}

        public T this[int index]
        {
            get
            {
                if (index >= Length)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    return Array[index];
                }
            }

            set
            {
                if (index >= Length)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    Array[index] = value;
                }
            }
        }
    }
}
