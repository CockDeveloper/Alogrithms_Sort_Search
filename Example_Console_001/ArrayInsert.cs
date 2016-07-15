using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_Console_001
{
    public class ArrayInsert<T> : ArraySelection<T> where T : IComparable<T>, new()
    {
        public ArrayInsert()
            : base()
        {

        }

        public void Sort()
        {
            InsertionSort(ElementsCollection);
        }

        private void InsertionSort(Array elementsCollection)
        {
            int lenght = elementsCollection.Length;
            for (int i = 1; i < lenght; ++i)
            {
                FindTemp(elementsCollection, i);
            }
        }

        private void FindTemp(Array elementsCollection, int index)
        {
            T temp = (T)elementsCollection.GetValue(index);
            int i = index - 1;
            FindIndexMaxValue(elementsCollection, ref i, ref temp);
            elementsCollection.SetValue(temp, i + 1);
        }

        private void FindIndexMaxValue(Array elementsCollection, ref int index, ref T tempValue)
        {
            while ( index >= 0
                    && tempValue.CompareTo((T)elementsCollection.GetValue(index)) < 0)
            {
                elementsCollection.SetValue(elementsCollection.GetValue(index), index + 1);
                --index;
            }
        }

    }
}
