using System;
using System.Collections.Generic;
using System.Text;

namespace GenericList
{
    class GenericList<T> where T : IComparable
    {
        // fields
        private T[] elements;
        private int index;

        // indexing
        public T this[int index]
        {
            get
            {
                return elements[index];
            }

            set
            {
                elements[index] = value;
            }
        }

        // constructor
        public GenericList(int size)
        {
            elements = new T[size];
        }

        // adding element
        public void Add(T element)
        {
            if (index >= elements.Length)
            {
                // double the size
                T[] newElements = new T[elements.Length * 2];

                // copy
                for (int i = 0; i < elements.Length; i++)
                {
                    newElements[i] = elements[i];
                }

                index++;
                newElements[elements.Length] = element;
                elements = newElements;
            }
            else
            {
                elements[index] = element;
                index++;
            }
        }

        // removing element at index
        public void RemoveAt(int index)
        {
            if (index < elements.Length)
            {
                T[] newElements = new T[elements.Length - 1];

                for (int i = 0, j = 0; i < elements.Length - 1; i++, j++)
                {
                    if (i == index)
                    {
                        j++;
                    }

                    newElements[i] = elements[j];
                }

                elements = newElements;
            }
            else
            {
                throw new IndexOutOfRangeException("Element not found!");
            }
        }

        // insert element at index
        public void InsertAt(int index, T element)
        {
            if (index < elements.Length)
            {
                T[] newElements = new T[elements.Length + 1];

                for (int i = 0, j = 0; i < elements.Length - 1; i++, j++)
                {
                    if (i == index)
                    {
                        newElements[i] = element;
                        j++;
                    }

                    newElements[j] = elements[i];
                }

                elements = newElements;
            }
            else
            {
                throw new IndexOutOfRangeException("Element not found!");
            }
        }

        // clear
        public void Clear()
        {
            elements = new T[elements.Length];
        }

        // find by value
        public int IndexOf(T value)
        {
            int index = -1;

            for (int i = 0; i < elements.Length; i++)
            {

                if (elements[i].Equals(value))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        // override ToString()
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            foreach (var item in elements)
            {
                result.AppendFormat("{0} ", item);
            }
            return result.ToString();
        }

        // max
        public T Max()
        {
            dynamic max = elements[0];
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i].CompareTo(max) == 1)
                {
                    max = elements[i];
                }
            }
            return max;
        }

        // min
        public T Min()
        {
            dynamic min = elements[0];
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i].CompareTo(min) == -1)
                {
                    min = elements[i];
                }
            }
            return min;
        }
    }
}
