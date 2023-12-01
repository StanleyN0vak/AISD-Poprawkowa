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

        public void Add(int liczba)
        {
            var w = this.korzen;
            for (int i = 0; i < this.iloscWezlow; i++)
            {
                if (w == null)
                    break;
                if(liczba > w.wartosc)
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
        }
    }
}
