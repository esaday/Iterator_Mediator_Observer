using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Lib
{
    public class Player //concrete Subject
    {
        private int _hitPoints;

        public EventHandler PlayerKilled; //Abstract OBSERVER delegate ?

        public int HitPoints
        {
            get { return _hitPoints; }
            set
            {
                _hitPoints = value;

                if (_hitPoints <= 0)
                {
                    // Notify subscribed objects when the condition is met
                    OnPlayerKilled();
                }
            }
        }

        private void OnPlayerKilled()
        {
            // Notifying method.
            PlayerKilled?.Invoke(this, EventArgs.Empty);
        }
    }
}
