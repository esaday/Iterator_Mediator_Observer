using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Lib
{
    public abstract class Collig
    {
        private Mediator mediator;
        private int colligCode;

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

        public Collig(Mediator newMediator)
        {
            mediator = newMediator;
            mediator.ColligEkle(this);
            Console.WriteLine("Bu arkadasin collig kodu :"+ColligCode);
        }

        public void SatisTeklifi(string hisseAdi, int hisseAdedi)
        {
            mediator.SatisTeklifi(hisseAdi, hisseAdedi, this.ColligCode);
        }

        public void AlisTeklifi(string hisseAdi, int hisseAdedi)
        {
            mediator.AlisTeklifi(hisseAdi, hisseAdedi, this.ColligCode);
        }

    }
}
