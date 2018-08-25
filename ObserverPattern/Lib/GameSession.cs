using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Lib
{
    public class GameSession
    {
       
        public Player CurrentPlayer { get; set; }
        
        public GameSession()
        {
            CurrentPlayer = new Player { HitPoints = 10 };

            // Subscribing to subject
            CurrentPlayer.PlayerKilled += HandlePlayerKilled;
        }

        public void MonsterAttackPlayer(int amountOfDamage)
        {
            CurrentPlayer.HitPoints -= amountOfDamage;
        }

        private void HandlePlayerKilled(object sender, EventArgs eventArgs) //implementing a update method
        {
            Console.WriteLine("Player killed");
        }
    }
}
