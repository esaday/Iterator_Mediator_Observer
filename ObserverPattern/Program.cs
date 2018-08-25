using ObserverPattern.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            GameSession gs = new GameSession();

            Console.WriteLine("Player took 2 dmg.");
            gs.MonsterAttackPlayer(2);


            Console.WriteLine("Player took 8 dmg.");
            gs.MonsterAttackPlayer(8);
            Console.ReadKey();
        }
    }
}
