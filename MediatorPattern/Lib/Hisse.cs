using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Lib
{
    class SatilikHisse
    {
        private int hisseSayisi = 0;
        private string hisseSembolu = "";
        private int colligCode = 0;

        #region Props
        public int HisseSayisi
        {
            get
            {
                return hisseSayisi;
            }

            set
            {
                hisseSayisi = value;
            }
        }

        public string HisseSembolu
        {
            get
            {
                return hisseSembolu;
            }

            set
            {
                hisseSembolu = value;
            }
        }

        public int ColligCode
        {
            get
            {
                return colligCode;
            }

            set
            {
                colligCode = value;
            }
        }
        #endregion

        public SatilikHisse(int hisseSay, string hisseAdi, int collCode)
        {
            HisseSayisi = hisseSay;
            HisseSembolu = hisseAdi;
            ColligCode = collCode;
        }

    }
}
