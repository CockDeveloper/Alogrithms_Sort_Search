using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_Console_001
{
    public class ArrayShell <T> : ArrayInsert<T> where T : IComparable<T>, new()
    {

        public ArrayShell()
            : base()
        {

        }

        public void Sort()
        {
            ShellSort(ElementsCollection);
        }

        private void ShellSort(Array elementsCollection)
        {
            int h = 1;
            int lenght = elementsCollection.Length;
            FindHighLevel(ref h, ref lenght);
            DivThreeLevel(ref elementsCollection, ref h);
        }

        private void FindHighLevel(ref int h, ref int lenght)
        {
            do
            {
                h = 3 * h + 1;
            }
            while (h < lenght / 3);
        }

        private void DivThreeLevel(ref Array elementsCollection, ref int h)
        {
            do
            {
                DivOneLevel(ref elementsCollection, ref h);
                h = (h-1) / 3;
            }
            while (h > 0);
        }

        private void DivOneLevel(ref Array elementsCollection, ref int h)
        {
            int lenght = elementsCollection.Length;
            for (int i = h; i < lenght; ++i)
            {
                int indexOldOfValue = i;
                int indexNewOfValue = indexOldOfValue;
                T value = (T)elementsCollection.GetValue(indexOldOfValue);
                FindIndexForValue(ref elementsCollection, ref h, ref indexNewOfValue, ref value);
                elementsCollection.SetValue(value, indexNewOfValue);
            }
        }

        private void FindIndexForValue(ref Array elementsCollection, ref int h, ref int indexNewOfValue, ref T value)
        {
            while(indexNewOfValue > h-1
                && ((T)elementsCollection.GetValue(indexNewOfValue - h)).CompareTo(value) >= 0)
            {
                elementsCollection.SetValue(((T)elementsCollection.GetValue(indexNewOfValue - h)), indexNewOfValue);
                indexNewOfValue = indexNewOfValue - h;
            }
        }

    }
}
