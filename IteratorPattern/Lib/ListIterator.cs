using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Lib
{
    class ListIterator : IEnumerator //concrete iterator
    {
        private List<string> ogrenciler;
        int number;
        public ListIterator(List<string> ogrenciler)
        {
            this.ogrenciler = ogrenciler;
            number = -1;
        }

        public object Current
        {
            get
            {
                return ogrenciler.ElementAt(number);
            }
        }

        public bool MoveNext()
        {
            if (number < ogrenciler.Count - 1)
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
