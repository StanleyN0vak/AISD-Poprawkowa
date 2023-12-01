using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafy
{
    internal class Wezel3
    {
        public int wartosc;
        public Wezel3 rodzic;
        public Wezel3 lewy;
        public Wezel3 prawy;
        public Wezel3(int liczba)
        {
            this.wartosc = liczba;
        }

       /* public Wezel3 ZnadzRodzica(int liczba)
        {

        }*/
    }
}
