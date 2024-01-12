using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafy
{
    internal class Wezel4
    {
        public int wartosc;
        List<Krawedz>? ListaKrawedzi = new List<Krawedz>();

        public Wezel4(int liczba)
        {
            this.wartosc = liczba;
        }

        /*public void DodajKrawedz(int liczba, int waga)
        {
            var temp = new Krawedz(this.wartosc, liczba, waga);
            this.ListaKrawedzi.Add(temp);
        }

        public Krawedz SprawdzKrawedz()
        {
            Krawedz temp;
            for (int i = 0; i < this.ListaKrawedzi?.Count; i++)
            {
                temp = new Krawedz(ListaKrawedzi[i].poczatek, ListaKrawedzi[i].koniec, ListaKrawedzi[i].waga);
                return temp;
            }
            return null;
        }*/
    }
}
