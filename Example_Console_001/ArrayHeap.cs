using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_Console_001
{
    public class ArrayHeap<T> : ArraySelection<T> where T : IComparable<T>, new()
    {
        public ArrayHeap()
        {

        }

        public void Sort()
        {
            HeapSort(ElementsCollection);
        }

        private void HeapSort(Array elementsCollection)
        {
            buildHeap(elementsCollection);
            for (int i = elementsCollection.Length - 1; i > 0; --i)
            {
                int n = 0;
                Swap(ref elementsCollection, ref n, ref i);
                Heapify(elementsCollection, i, 0);
            }
        }

        private void buildHeap(Array elementsCollection)
        {
            int lenght = elementsCollection.Length;
            for (int i = lenght / 2 - 1; i >= 0; --i )
            {
                Heapify(elementsCollection, lenght, i);
            }
        }

        private void Heapify(Array elementsCollection, int lenght, int indexOfValue)
        {
            int indexSubLeft = 2*(indexOfValue + 1) - 1;
            int indexSubRight = 2*(indexOfValue + 1);
            int indexOfLagest;

            if (indexSubLeft < lenght && ((T)elementsCollection.GetValue(indexSubLeft)).CompareTo(((T)elementsCollection.GetValue(indexOfValue))) > 0)
            {
                indexOfLagest = indexSubLeft;
            }
            else
            {
                indexOfLagest = indexOfValue;
            }

            if (indexSubRight < lenght && ((T)elementsCollection.GetValue(indexSubRight)).CompareTo(((T)elementsCollection.GetValue(indexOfLagest))) > 0)
            {
                indexOfLagest = indexSubRight;
            }

            if (!indexOfValue.Equals(indexOfLagest))
            {
                Swap(ref elementsCollection,ref indexOfValue,ref indexOfLagest);
                Heapify(elementsCollection, lenght, indexOfLagest);
            }
        }

    }
}
