using System;
using System.Collections;
using System.Collections.Generic;

namespace Dynamic_ARRAY
{
    public class MyArrayList<T> : IEnumerable, IEnumerable<T>
    {
        public T[] Array { get; set; }

        private int length;

        private int capacity;

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
            get => capacity;

            set
            {
                if (capacity < length)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (capacity > length && Length != 0)
                {
                    T[] array = new T[capacity];

                    Array.CopyTo(array, 0);
                }
            }
        }

        public MyArrayList() 
        {
            Array = new T[8];
            capacity = 8;
            length = 0;
        }

        public MyArrayList(int x)
        {
            Array = new T[x];
            capacity = x;
            length = 0;
        }

        public MyArrayList(IEnumerable<T> collection)
        {
            capacity = 0;

            int index = 0;

            foreach (var item in collection)
            {
                capacity++;
            }

            T [] arr = new T[capacity];

            length = capacity;

            foreach (var item in collection)
            {
                arr[index] = item;
                index++;
            }
        }

        public void Add(T item)
        {
            if (capacity == length)
            {
                T[] arr = new T[capacity * 2];

                Array.CopyTo(arr, 0);

                arr[length] = item;

                Array = arr;

                capacity *= 2;
            }
            else if(capacity > length)
            {
                Array[length] = item;
            }
            length++;
        }

        public void AddRange(IEnumerable<T> collection)
        {
            int countCollection = 0;

            int oldLength = length;

            if (collection is null)
            {
                throw new ArgumentNullException();
            }

            foreach (var item in collection)
            {
                countCollection++;
            }

            if (length + countCollection > capacity)
            {
                T[] arr = new T[length + countCollection + 1];

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
                    length++;
                }
            }
        }

        public bool Remove(int index)
        {
            if (index >= length || index < 0)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    if (i == index && index != length - 1)
                    {
                        for (int j = i; j < length; j++)
                        {
                            Array[j] = Array[j + 1];
                        }
                    }
                    if(i == index && index == length - 1)
                    {
                        i = 0;
                        length--;
                    }
                }
                return true;
            }
        }

        public bool Insert(int index, T item)
        {
            if (index > length)
            {
                return false;
                throw new ArgumentOutOfRangeException();
            }
            if (length == capacity)
            {
                T[] arr = new T[capacity * 2];

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

        public virtual IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Length; i++)
            {
                yield return Array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public T this[int index]
        {
            get
            {
                if (index >= length)
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
                if (index >= length)
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
