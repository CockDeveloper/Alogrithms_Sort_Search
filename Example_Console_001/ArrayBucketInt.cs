using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_Console_001
{
    public class ArrayBucketInt<T> : ArraySelection<T> where T : IComparable<T>, new()
    {
        public ArrayBucketInt()
        {

        }

        public void Sort()
        {
            BucketSort(ElementsCollection);
        }

        private void BucketSort(Array elementsCollection)
        {
            Array[] bucketArr = new Array[10];
            int length = elementsCollection.Length;

            for (int i = 0; i < length; ++i)
            {
                int key = ((int)elementsCollection.GetValue(i)) % 10;
                if (bucketArr[key].Length > 0)
                {
                    //1. Search index to insert elementsCollection[i] on bucket[key]
                    //2. Insert into bucket[key].insert(valueOfi, index);
                    bucketArr[key].SetValue(((T)elementsCollection.GetValue(i)), bucketArr.Length);
                }
            }
        }

        //private Array bucketArr;
    }
}
