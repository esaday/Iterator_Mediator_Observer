using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Lib
{
    class ConcreteCollig : Collig
    {
        public ConcreteCollig(Mediator m) : base(m)
        {
            
            Console.WriteLine("Ahmedinejad borsaya girdi üstad.");
        }
    }

    class ConcreteCollig2 : Collig
    {
        public ConcreteCollig2(Mediator m) : base(m)
        {
            Console.WriteLine("Talabarzani borsaya kafa atıyor, dikkat.");
        }
    }

    class ConcreteCollig3 : Collig
    {
        public ConcreteCollig3(Mediator m) : base(m)
        {
            Console.WriteLine("Kambersiz dügün olmaz.");
        }
    }
}
