using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Lib
{
    public interface Mediator
    {
        void SatisTeklifi(string hisseAdi, int hisseAdedi, int collCode);
        void AlisTeklifi(string hisseAdi, int hisseAdedi, int collCode);
        void ColligEkle(Collig colleague);
    }

}
