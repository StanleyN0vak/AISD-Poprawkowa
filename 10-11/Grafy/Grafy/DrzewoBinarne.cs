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
            while (true) 
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
                else if (w.prawy == null && w.rodzic == null)
                {
                    return null;
                }
            }
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
    }    
}
