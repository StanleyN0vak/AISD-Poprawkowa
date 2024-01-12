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

        internal void DodajDziecko(int liczba)
        {
            if (liczba < this.wartosc)
            {
                this.lewy = new Wezel3(liczba);
                this.lewy.rodzic = this;
            }
            else
            {
                this.prawy = new Wezel3(liczba);
                this.prawy.rodzic = this;
            }
        }

        internal int GotliczbaDzieci()
        {
            int wynik = 0;
            if (this.lewy != null)
                wynik++;
            if(this.prawy != null)
                wynik++;
            return wynik;
        }
    }
}
