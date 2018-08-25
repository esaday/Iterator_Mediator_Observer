using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Lib
{
    class ElekMuh : IEnumerable //Concrete Aggregate
    {
        List<string> ogrenciler;

        public ElekMuh()
        {
            ogrenciler = new List<string>();
            ogrenciler.Add("a");
            ogrenciler.Add("b");
            ogrenciler.Add("c");
            ogrenciler.Add("d");
            ogrenciler.Add("e");

        }

        public IEnumerator GetEnumerator()
        {
            return new ListIterator(ogrenciler);
        }
    }
}

