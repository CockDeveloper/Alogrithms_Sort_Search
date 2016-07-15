using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_Console_001
{
    public class ArraySelection<T> where T : IComparable<T>, new()
    {

        public ArraySelection()
        {
            //ElementsCollection.Initialize();
        }

        private Array _a;

        public Array ElementsCollection
        {
            get { return _a; }
            set { _a = value; }
        }

        public void Sort()
        {
            SelectSort(ElementsCollection);
        }

        private void SelectSort(Array elementsCollection)
        {
            int lenght = elementsCollection.Length;
            for (int i = 0; i < (lenght - 1); ++i )
            {
                FindMin(elementsCollection, i + 1, lenght, i);
            }
        }

        private bool FindMin(Array elementsCollection, int start, int end, int min)
        {
            bool ret = true;
            int minNew = min;
            for (int i = start; i < end; ++i)
            {
                GetIndexMin(elementsCollection, i, ref minNew);
            }
            Swap(ref elementsCollection, ref min, ref  minNew);
            return ret;
        }

        protected void Swap(ref Array elementsCollection, ref  int indexOfValueA, ref  int indexOfValueB)
        {
            if (!indexOfValueA.Equals(indexOfValueB))
            {
                T temp = (T) elementsCollection.GetValue(indexOfValueA);
                elementsCollection.SetValue(elementsCollection.GetValue(indexOfValueB), indexOfValueA);
                elementsCollection.SetValue(temp, indexOfValueB);
            }
        }

        private void GetIndexMin(Array elementsCollection, int index, ref int min)
        {
            T valueIndex = (T)elementsCollection.GetValue(index);
            T valueMin = (T)elementsCollection.GetValue(min);
            if (valueIndex.CompareTo(valueMin) < 0)
            {
                min = index;
            }
        }

        public bool Add(T e)
        {
            bool ret = false;
            ElementsCollection.SetValue(e, ElementsCollection.Length);
            return ret;
        }

    }
}
