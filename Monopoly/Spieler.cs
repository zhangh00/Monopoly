using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Spieler
    {
        private int coins = 2000;
        private int spielerstatus;
        private int schritte = 0;
        private int lebensstatus;
        public Spieler(int zahl)
        {
            spielerstatus = zahl;
        }
        public int getcoin()
        {
            return coins;
        }
        public int pedometer(int zahl)
        {
            schritte += zahl;
            return schritte;
        }
        public void coinsub()
        {
            coins -= 20;
        }
    }
}
