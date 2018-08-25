using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Lib
{
    class ArrayIterator : IEnumerator //Concrete iterator
    {
        string[] ogrenciler;
        int number;
        public ArrayIterator(string[] ogrenciler)
        {
            this.ogrenciler = ogrenciler;
            number = -1;
        }
        public object Current
        {
            get
            {
                return ogrenciler[number];
            }
        }

        public bool MoveNext()
        {
            if (number < ogrenciler.Length - 1)
            {
                number++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }

        public void Reset()
        {
            number = 0;
        }
    }
}
