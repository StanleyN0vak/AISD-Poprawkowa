using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafy
{
    internal class DrzewoBinarne
    {
        public Wezel3 korzen;
        public int iloscWezlow;

        public DrzewoBinarne(int liczba)
        {
            this.korzen = new(liczba);
            this.iloscWezlow = 1;
        }

        /*public void Add(int liczba)
        {
            var w = this.korzen;
            for (int i = 0; i < this.iloscWezlow; i++)
            {
                if (w == null)
                    break;
                if(liczba >= w.wartosc)
                {
                    if (w.prawy != null)
                        w = w.prawy;
                    else
                    {
                        w.prawy = new Wezel3(liczba);
                        w.prawy.rodzic = w;
                        iloscWezlow++;
                        break;
                    }
                }
                else 
                {
                    if (w.lewy != null)
                        w = w.lewy;
                    else
                    {
                        w.lewy = new Wezel3(liczba);
                        w.lewy.rodzic = w;
                        iloscWezlow++;
                        break;
                    }
                }
            }
        }*/

        public void Add(int liczba)
        {
            Wezel3 rodzic = this.ZnadzRodzica(liczba);
            rodzic.DodajDziecko(liczba);
        }

        public Wezel3 ZnadzRodzica(int liczba)
        {
            var w = this.korzen;
            while (true)
            {
                if (liczba < w.wartosc)
                {
                    if (w.lewy == null)
                        return w;
                    else
                        w = w.lewy;
                }
                else
                {
                    if (w.prawy == null)
                        return w;
                    else
                        w = w.prawy;
                }
            }
        }

        public Wezel3 Znajdz(int liczba)
        {
            var w = this.korzen;
            while (true)
            {
                if (w.wartosc == liczba)
                    return w;
                else if (liczba < w.wartosc)
                {
                    if (w.lewy == null)
                        return null;
                    else
                        w = w.lewy;
                }
                else
                {
                    if (w.prawy == null)
                        return null;
                    else
                        w = w.prawy;
                }
            }
        }

        public Wezel3 ZnajdzMin(Wezel3 w)
        {
            while (true)
            {
                if (w.lewy != null)
                    w = w.lewy;
                else
                    return w;
            }
        }

        public Wezel3 ZnajdzMax(Wezel3 w)
        {
            while (true)
            {
                if (w.prawy != null)
                    w = w.prawy;
                else
                    return w;
            }
        }

        public Wezel3 Nastepnik(Wezel3 w)
        {
                if (w.prawy != null)
                {
                    return ZnajdzMin(w.prawy);
                }
                else if (w.prawy == null)
                {
                    while (w.rodzic != null)
                    {
                        if(w == w.rodzic.lewy)
                        {
                            return w.rodzic;
                        }
                        else
                        {
                            w = w.rodzic;
                        }
                    }
                }
                return null;
        }

        public Wezel3 Poprzednik(Wezel3 w)
        {
            while(true)
            {
                if (w.lewy != null)
                {
                    return ZnajdzMax(w.lewy);
                }
                else if (w.prawy == null)
                {
                    while(w.rodzic != null)
                    {
                        if (w == w.rodzic.prawy)
                        {
                            return w.rodzic;
                        }
                        else
                        {
                            w = w.rodzic;
                        }
                    }
                }
                else if (w.lewy == null && w.rodzic == null)
                {
                    return null;
                }
            }
        }

        /*public Wezel3 Usun(Wezel3 w)
        {
            //1) Nie ma dzieci, to usuwamy. Odpinamy rodzicowi odpowiednie dziecko i odpowiedniego rodzica
            if (w.lewy == null && w.prawy == null)
            {
                if (w.rodzic.lewy == w)
                {
                    w.rodzic.lewy = null;
                    return w = null;
                }
                else
                {
                    w.rodzic.prawy = null;
                    return w = null;
                }
            }
            //2) Jeżeli ma jedno dziecko, to zastępuje obecnego rodzica. Wchodzi na jego miejsce
            else if(w.lewy != null && w.prawy == null)
            {
                var left = w;
                w = w.lewy;
                w.rodzic = left.rodzic;
                if (left.rodzic.lewy == left)
                {
                    w.rodzic.lewy = w;
                    return w;
                }
                else
                {
                    w.rodzic.prawy = w;
                    return w;
                }
                
            }
            else if(w.prawy != null && w.lewy == null)
            {
                var right = w;
                w = w.prawy;
                w.rodzic = right.rodzic;
                if (right.rodzic.lewy == right)
                {
                    w.rodzic.lewy = w;
                    return w;
                }
                else
                {
                    w.rodzic.prawy = w;
                    return w;
                }
            }
            //3) Jeżeli ma dwoje dzieci. Zamieniam rodzica dzieckiem następnikiem albo poprzednikiem (to rekurencyjnie musimy poprzednikiem/nastepnikiem)
            // Idziemy głęboko w rekurencję aż dojdziemy do końca i zwracamy ostatni węzeł
            else
            {
                var poprzednik = Poprzednik(w);
                w.wartosc = poprzednik.wartosc;
                w.lewy = Usun(w.lewy);
            }
            return w;
        }*/

        Wezel3 Usun(Wezel3 w)
        {
            switch (w.GotliczbaDzieci())
            {
                case 0:
                    w = this.UsunGdy0(w);
                    break;
                case 1:
                    w = this.UsunGdy1(w);
                    break;
                case 2:
                    w = this.UsunGdy2(w);
                    break;
            }
            return w;
        }

        private Wezel3 UsunGdy2(Wezel3 w)
        {
            var zamiennik = this.Nastepnik(w);
            zamiennik = this.Usun(zamiennik);
            //przewiązywanie
            return w;
        }

        private Wezel3 UsunGdy1(Wezel3 w)
        {
            Wezel3 dziecko = null;
            if (w.lewy != null)
            {
                dziecko = w.lewy;
                w.lewy = null;
            }
            else
            {
                dziecko = w.prawy;
                w.prawy = null;
            }
            dziecko.rodzic = w.rodzic;

            if (w.rodzic == null)
                this.korzen = dziecko;
            else
            {
                if (w.rodzic.lewy == w)
                    w.rodzic.lewy = dziecko;
                else
                    w.rodzic.prawy = dziecko;
            }
            w.rodzic = null;
            return w;
        }

        private Wezel3 UsunGdy0( Wezel3 w )
        {
            if(w.rodzic == null)
            {
                this.korzen = null;
                return w;
            }
            if (w.rodzic.lewy == null)
                w.rodzic.lewy = null;
            else
                w.rodzic.prawy = null;
            w.rodzic = null;
            return w;

        }
    }    
}
