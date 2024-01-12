using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Grafy
{
    internal class Grafy
    {
        public List<Wezel4> listaWezlow = new List<Wezel4>();
        public List<Krawedz> listaKrawedzi = new List<Krawedz>();

        public Grafy(Krawedz k)
        {
            this.listaKrawedzi.Add(k);
            this.listaWezlow.Add(k.poczatek);
            this.listaWezlow.Add(k.koniec);
        }

        public int Sprawdz(Krawedz k)
        {
            int wynik = 0;
            if (!listaWezlow.Contains(k.poczatek)) wynik++;
            if(!listaWezlow.Contains(k.koniec)) wynik++;
            return wynik;
        }

        public void Add(Krawedz k)
        {
            this.listaKrawedzi.Add((Krawedz)k);
            if (!this.listaWezlow.Contains(k.poczatek))
                this.listaWezlow.Add(k.poczatek);
            if (!this.listaWezlow.Contains(k.koniec))
                this.listaWezlow.Add(k.koniec);
        }

        public void Join(Grafy g)
        {
            foreach (var k in g.listaKrawedzi){
                this.Add(k);
            }
        }
        //Sortowanie po wadze
        //this.listakrawedzi.OrderBy(k=>k.waga);
        //Dodać metode łaczenia grafu
    }
}
