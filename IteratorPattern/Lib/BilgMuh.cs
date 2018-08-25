using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Lib
{
    class BilgMuh : IEnumerable //Concrete Aggregate
    {
        string[] ogrenciler;

        public BilgMuh()
        {
            ogrenciler = new string[6];
            ogrenciler[0] = "1";
            ogrenciler[1] = "2";
            ogrenciler[2] = "3";
            ogrenciler[3] = "4";
            ogrenciler[4] = "5";
            ogrenciler[5] = "6";
        }

        public IEnumerator GetEnumerator()
        {
            return new ArrayIterator(ogrenciler);
        }
    }
}
