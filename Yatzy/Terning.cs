using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzy
{
    class Terning
    {
        private int terningVærdi { get; set; }
        private bool terningLock { get; set; }

        private static Random rnd = new Random(); 
        public Terning()
        {
            this.terningVærdi = rnd.Next(1, 7);
            this.terningLock = false;
        }

        public void RoolDice ()
        {
            this.terningVærdi = rnd.Next(1, 7);

        }

        public void ChangeLockStatus(bool state = true)
        {
            if (state == false)
                this.terningLock = false;
            else
            {
                if (this.terningLock == true)
                    this.terningLock = false;
                else
                    this.terningLock = true;
            }
        }

        public bool IsLock()
        {
            return this.terningLock;
        }

        public int GetDiceValue()
        {
            return this.terningVærdi;

        }
    }
}
