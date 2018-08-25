using MediatorPattern.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator imkb = new ConcreteMediator();
            ConcreteCollig broker = new ConcreteCollig(imkb);
            ConcreteCollig2 broker2 = new ConcreteCollig2(imkb);
            ConcreteCollig3 broker3 = new ConcreteCollig3(imkb);
            Console.WriteLine("------------------------------------------------\n");

            broker.SatisTeklifi("MSFT", 100);
            broker.SatisTeklifi("GOOG", 50);

            broker2.AlisTeklifi("MSFT", 100);
            broker2.SatisTeklifi("NRG", 10);

            broker3.AlisTeklifi("NRG", 10);
            broker3.AlisTeklifi("MSFT", 100);
            broker3.SatisTeklifi("NRG", 10);

            imkb.SenetleriListele(); Console.ReadKey();

        }
    }
}
