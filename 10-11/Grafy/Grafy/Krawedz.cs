using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafy
{
    internal class Krawedz
    {
        public int waga;
        public Wezel4 poczatek, koniec;

        public Krawedz(int waga, Wezel4 poczatek, Wezel4 koniec)
        {
            this.waga = waga;
            this.poczatek = poczatek;
            this.koniec = koniec;
        }
    }

    
}
