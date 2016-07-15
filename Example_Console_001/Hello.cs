//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
using System;

namespace Example_Console_001
{
    public interface ITransactions
    {
        // interface members
        void showTransaction();
        double getAmount();
    }

    public class Transaction : ITransactions
    {
        private string tCode;
        private string date;
        private double amount;
        public Transaction()
        {
            tCode = " ";
            date = " ";
            amount = 0.0;
        }

        public Transaction(string c, string d, double a)
        {
            tCode = c;
            date = d;
            amount = a;
        }

        public double getAmount()
        {
            return amount;
        }

        public void showTransaction()
        {
            Console.WriteLine("Transaction: {0}", tCode);
            Console.WriteLine("Date: {0}", date);
            Console.WriteLine("Amount: {0}", getAmount());
        }
    }
    class Tester
    {
        static void Main(string[] args)
        {
            Transaction t1 = new Transaction("001", "8/10/2012", 78900.00);
            Transaction t2 = new Transaction("002", "9/10/2012", 451900.00);
            t1.showTransaction();
            t2.showTransaction();
            Console.ReadKey();

            Int32[] arrInt = new Int32[] { 7, 6, 9, 65, 8, 3, 5, 4 };

            Int32[] arrIntCopy = new Int32[arrInt.Length];
            //arrInt.CopyTo(arrIntCopy, 0);
            ArraySelection<Int32> arrIntSel = new ArraySelection<Int32>();
            arrInt.CopyTo(arrIntCopy, 0);
            arrIntSel.ElementsCollection = arrIntCopy;
            arrIntSel.Sort();
            Console.Write("array selection sort:\n");
            for (int i = 0; i < arrIntSel.ElementsCollection.Length; ++i)
            {
                Console.Write("{0} ", arrIntSel.ElementsCollection.GetValue(i).ToString());
            }
            Console.WriteLine();
            Console.ReadKey();

            ArrayInsert<Int32> arrIntIns = new ArrayInsert<Int32>();
            arrInt.CopyTo(arrIntCopy, 0);
            arrIntIns.ElementsCollection = arrIntCopy;
            arrIntIns.Sort();
            Console.Write("array Insert sort:\n");
            for (int i = 0; i < arrIntIns.ElementsCollection.Length; ++i)
            {
                Console.Write("{0} ", arrIntIns.ElementsCollection.GetValue(i).ToString());
            }
            Console.WriteLine();
            Console.ReadKey();

            ArrayBuble<Int32> arrIntBub = new ArrayBuble<Int32>();
            arrInt.CopyTo(arrIntCopy, 0);
            arrIntBub.ElementsCollection = arrIntCopy;
            arrIntBub.Sort();
            Console.Write("array Buble sort:\n");
            for (int i = 0; i < arrIntBub.ElementsCollection.Length; ++i)
            {
                Console.Write("{0} ", arrIntBub.ElementsCollection.GetValue(i).ToString());
            }
            Console.WriteLine();
            Console.ReadKey();

            ArrayShell<Int32> arrIntShe = new ArrayShell<Int32>();
            arrInt.CopyTo(arrIntCopy, 0);
            arrIntShe.ElementsCollection = arrIntCopy;
            arrIntShe.Sort();
            Console.Write("array Shell sort:\n");
            for (int i = 0; i < arrIntShe.ElementsCollection.Length; ++i)
            {
                Console.Write("{0} ", arrIntShe.ElementsCollection.GetValue(i).ToString());
            }
            Console.WriteLine();
            Console.ReadKey();

            ArrayMerge<Int32> arrIntMer = new ArrayMerge<Int32>();
            arrInt.CopyTo(arrIntCopy, 0);
            arrIntMer.ElementsCollection = arrIntCopy;
            arrIntMer.Sort();
            Console.Write("array Merge sort:\n");
            for (int i = 0; i < arrIntMer.ElementsCollection.Length; ++i)
            {
                Console.Write("{0} ", arrIntMer.ElementsCollection.GetValue(i).ToString());
            }
            Console.WriteLine();
            Console.ReadKey();

            ArrayQuick<Int32> arrIntQui = new ArrayQuick<Int32>();
            arrInt.CopyTo(arrIntCopy, 0);
            arrIntQui.ElementsCollection = arrIntCopy;
            arrIntQui.Sort();
            Console.Write("array Quick sort:\n");
            for (int i = 0; i < arrIntQui.ElementsCollection.Length; ++i)
            {
                Console.Write("{0} ", arrIntQui.ElementsCollection.GetValue(i).ToString());
            }
            Console.WriteLine();
            Console.ReadKey();

            ArrayHeap<Int32> arrIntHea = new ArrayHeap<Int32>();
            arrInt.CopyTo(arrIntCopy, 0);
            arrIntHea.ElementsCollection = arrIntCopy;
            arrIntHea.Sort();
            Console.Write("array Heap sort:\n");
            for (int i = 0; i < arrIntHea.ElementsCollection.Length; ++i)
            {
                Console.Write("{0} ", arrIntHea.ElementsCollection.GetValue(i).ToString());
            }
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}