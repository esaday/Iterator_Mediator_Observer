using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Lib
{
    class ConcreteMediator : Mediator
    {
        private List<Collig> colleagues;
        private List<SatilikHisse> hisseAlisTeklifleri;
        private List<SatilikHisse> hisseSatisTeklifleri;

        private int colligCodes = 0;

        public ConcreteMediator()
        {
            colleagues = new List<Collig>();
            hisseAlisTeklifleri = new List<SatilikHisse>();
            hisseSatisTeklifleri = new List<SatilikHisse>();
        }

        public void ColligEkle(Collig colleague)
        {
            colleagues.Add(colleague);
            colleague.ColligCode = colligCodes++;
        }

        public void AlisTeklifi(string hisseAdi, int hisseAdedi, int collCode)
        {
            bool hisseAlindi = false;
            foreach (SatilikHisse hisse in hisseSatisTeklifleri)
            {
                if ((hisse.HisseSembolu == hisseAdi) && (hisse.HisseSayisi == hisseAdedi))
                {
                    Console.WriteLine(hisseAdedi + "adet " + hisseAdi + " hissesi " + hisse.ColligCode + " nolu kollig tarafından alındı.\n");
                    hisseSatisTeklifleri.Remove(hisse);
                    hisseAlindi = true;
                }

                if (hisseAlindi) { break; }
            }
            if (!hisseAlindi)
            {
                Console.WriteLine(hisseAdedi + " adet " + hisseAdi + " hissesi satilik envanterine eklendi.\n");

                hisseAlisTeklifleri.Add(new SatilikHisse(hisseAdedi, hisseAdi, collCode));
            }
        }

        public void SatisTeklifi(string hisseAdi, int hisseAdedi, int collCode)
        {
            bool hisseSatildi = false;
            foreach (SatilikHisse hisse in hisseAlisTeklifleri)
            {
                if ((hisse.HisseSembolu == hisseAdi) && (hisse.HisseSayisi == hisseAdedi))
                {
                    Console.WriteLine(hisseAdedi + "adet " + hisseAdi + " hissesi " + hisse.ColligCode + " nolu kollig tarafından satildi.\n");
                    hisseAlisTeklifleri.Remove(hisse);
                    hisseSatildi = true;
                }

                if (hisseSatildi) { break; }
            }
            if (!hisseSatildi)
            {
                Console.WriteLine(hisseAdedi + "adet " + hisseAdi + " hissesi satilik envanterine eklendi.\n");

                hisseSatisTeklifleri.Add(new SatilikHisse(hisseAdedi, hisseAdi, collCode));
            }

        }

        public void SenetleriListele()
        {
            Console.WriteLine("Marketteki Alim Teklifleri:");
            foreach (var item in hisseAlisTeklifleri)
            {
                Console.WriteLine(item.HisseSembolu +"isimli hisseden "+ item.HisseSayisi+ " adet alim teklifi mevcttur.");
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Marketteki Satis Teklifleri:");
            foreach (var item in hisseAlisTeklifleri)
            {
                Console.WriteLine(item.HisseSembolu + "isimli hisseden " + item.HisseSayisi + " adet satis teklifi mevcttur.");
            }
        }

    }
}