using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_Console_001
{
    public class ArrayMerge<T> : ArraySelection<T> where T : IComparable<T>, new()
    {
        public ArrayMerge()
        {

        }

        public void Sort()
        {
            Array ec = ElementsCollection;
            MergeSort(ref ec);
        }

        private void MergeSort(ref Array ec)
        {
            MergeSort(ref ec, 0, ec.Length - 1);
        }

        private void MergeSort(ref Array elementsCollection, int indexStart, int indexEnd)
        {
            bool isContinue = true;
            if (indexStart.CompareTo(indexEnd) >= 0)
            {
                isContinue = false;
            }

            if (isContinue)
            {
                int indexStartOfAfter = indexStart;
                int indexEndOfAfter = (indexStartOfAfter + (indexEnd - indexStartOfAfter) / 2);
                int indexStartOfBefore = (indexEndOfAfter + 1);
                int indexEndOfBefore = indexEnd;
                MergeSort(ref elementsCollection, indexStartOfAfter, indexEndOfAfter);
                MergeSort(ref elementsCollection, indexStartOfBefore, indexEndOfBefore);

                if (!(indexStartOfAfter > indexEndOfAfter || indexStartOfBefore > indexEndOfBefore))
                {

                    T valueEndAffter = (T)elementsCollection.GetValue(indexEndOfAfter);
                    T valueStartBefore = (T)elementsCollection.GetValue(indexStartOfBefore);
                    if (valueEndAffter.CompareTo(valueStartBefore) > 0)
                    {
                        int indexAffter = indexStartOfAfter;
                        int indexBefore = indexStartOfBefore;
                        int lengthAffter = (indexEndOfAfter - indexStartOfAfter) + 1;
                        int lengthBefore = (indexEndOfBefore - indexStartOfBefore) + 1;
                        T[] arrAfter = new T[lengthAffter];
                        T[] arrBefore = new T[lengthBefore];
                        for (int i = 0; i < lengthAffter; ++i)
                        {
                            arrAfter[i] = (T)elementsCollection.GetValue(indexStartOfAfter + i);
                        }
                        for (int i = 0; i < lengthBefore; ++i)
                        {
                            arrBefore[i] = (T)elementsCollection.GetValue(indexStartOfBefore + i);
                        }
                        indexAffter = 0;
                        indexBefore = 0;
                        while (true)
                        {
                            if (indexAffter < lengthAffter && indexBefore < lengthBefore)
                            {
                                if (arrAfter[indexAffter].CompareTo(arrBefore[indexBefore]) < 0)
                                {
                                    elementsCollection.SetValue(arrAfter[indexAffter], indexStartOfAfter + indexAffter + indexBefore);
                                    ++indexAffter;
                                }
                                else
                                {
                                    elementsCollection.SetValue(arrBefore[indexBefore], indexStartOfAfter + indexAffter + indexBefore);
                                    ++indexBefore;
                                }
                            }
                            else if (!(indexAffter < lengthAffter) && indexBefore < lengthBefore)
                            {
                                elementsCollection.SetValue(arrBefore[indexBefore], indexStartOfAfter + indexAffter + indexBefore);
                                ++indexBefore;
                            }
                            else if (indexAffter < lengthAffter && !(indexBefore < lengthBefore))
                            {
                                elementsCollection.SetValue(arrAfter[indexAffter], indexStartOfAfter + indexAffter + indexBefore);
                                ++indexAffter;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }

        }
    }
}
