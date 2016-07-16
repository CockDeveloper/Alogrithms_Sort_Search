using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_Console_001
{
    public class ArrayBubble<T> : ArraySelection<T> where T : IComparable<T>, new()
    {
        public ArrayBubble()
            : base()
        {

        }

        public void Sort()
        {
            BubleSort(ElementsCollection);
        }

        private void BubleSort(Array elementsCollection)
        {
            int lenght = elementsCollection.Length;
            for (int i = 0; i < lenght - 1; ++i)
            {
                CheckValues(elementsCollection, i + 1, lenght);
            }
        }

        private void CheckValues(Array elementsCollection, int start, int lenght)
        {
            for (int i = lenght - 1; i >= start; --i)
            {
                int indexA = i;
                int indexB = i - 1;
                T valueAtIndexA = (T)elementsCollection.GetValue(indexA);
                T valueAtIndexB = (T)elementsCollection.GetValue(indexB);
                if (valueAtIndexA.CompareTo(valueAtIndexB) < 0)
                {
                    Swap(ref elementsCollection, ref indexA, ref indexB);
                }
            }
        }
    }
}
