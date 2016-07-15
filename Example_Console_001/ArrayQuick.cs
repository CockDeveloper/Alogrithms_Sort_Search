using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_Console_001
{
    public class ArrayQuick<T> : ArraySelection<T> where T : IComparable<T>, new()
    {
        public ArrayQuick()
        {

        }

        public void Sort()
        {
            int indexLeft = 0;
            int indexRight = ElementsCollection.Length - 1;
            QuickSort(ElementsCollection, ref indexLeft, ref indexRight);
        }

        private void QuickSort(Array elementsCollection, ref int indexLeft, ref int indexRight)
        {
            if (indexRight.CompareTo(indexLeft) > 0)
            {
                int indexMid = indexRight + 1;
                FindMid(elementsCollection, ref indexLeft, ref indexRight, ref indexMid);
                Swap(ref elementsCollection, ref indexLeft, ref indexMid);
                int indexRightFront = indexMid - 1;
                QuickSort(elementsCollection, ref indexLeft, ref indexRightFront);
                int indexLeftBack = indexMid + 1;
                QuickSort(elementsCollection, ref indexLeftBack, ref indexRight);

            }
        }

        private void FindMid(Array elementsCollection, ref int indexLeft, ref int indexRight, ref int indexMid)
        {
            int index = indexLeft;
            T valueLeft = (T)elementsCollection.GetValue(indexLeft);
            T valueIndex;
            T valueMid;
            do
            {
                do
                {
                    if (index + 1 > indexRight) break;
                    ++index;
                    valueIndex = (T)elementsCollection.GetValue(index);
                }
                while (valueIndex.CompareTo(valueLeft) < 0
                    );
                do
                {
                    if (indexMid - 1 < indexLeft) break;
                    --indexMid;
                    valueMid = (T)elementsCollection.GetValue(indexMid);
                }
                while (valueMid.CompareTo(valueLeft) > 0
                    );
                if (index.CompareTo(indexMid) < 0)
                {
                    Swap(ref elementsCollection, ref index, ref indexMid);
                }
            }
            while (index < indexMid);
        }
    }
}
