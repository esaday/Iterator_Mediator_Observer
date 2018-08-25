using IteratorPattern.Lib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable bilg = new BilgMuh();
            IEnumerable elek = new ElekMuh();

            IEnumerator iterator = bilg.GetEnumerator();
            IEnumerator iterator2 = elek.GetEnumerator();
            Print(iterator);
            Print(iterator2);
            Console.ReadKey();
        }

       static void Print(IEnumerator a)
        {
            while (a.MoveNext())
            {
                Console.WriteLine(a.Current.ToString());
            }
        }
    }
}
