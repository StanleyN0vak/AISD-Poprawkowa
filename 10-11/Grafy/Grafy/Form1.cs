namespace Grafy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string napis;

        private void bt1_Click(object sender, EventArgs e)
        {
            var w1 = new Wezel(5);
            var w2 = new Wezel(3);
            w1.dzieci.Add(w2);
            var w3 = new Wezel(2);
            var w4 = new Wezel(7);
            w2.dzieci.Add(w3);
            w2.dzieci.Add(w4);
            var w5 = new Wezel(4);
            w1.dzieci.Add(w5);
            var w6 = new Wezel(1);
            w5.dzieci.Add(w6);
            var w7 = new Wezel(8);
            w4.dzieci.Add(w7);
            napis = "";
            BFS(w1);
            MessageBox.Show(napis);
        }

        void A(Wezel w)
        {
            napis += w.wartosc.ToString() + " ";
            foreach (var dziecko in w.dzieci)
            {
                A(dziecko);
            }
        }

        Queue<Wezel> kids = new();
        void BFS(Wezel w)
        {
            kids.Enqueue(w);
            while (kids.Count > 0)
            {
                Wezel current = kids.Dequeue();
                if (!napis.Contains(current.wartosc.ToString()))
                    napis += current.wartosc.ToString() + " ";
                foreach (var dziecko in current.dzieci)
                {
                    kids.Enqueue(dziecko);
                }
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            var w1 = new Wezel2(5);
            var w2 = new Wezel2(3);
            var w3 = new Wezel2(1);
            var w4 = new Wezel2(8);
            var w5 = new Wezel2(4);
            var w6 = new Wezel2(6);
            var w7 = new Wezel2(2);

            w1.Add(w2);
            w2.Add(w3);
            w2.Add(w5);
            w5.Add(w6);
            w3.Add(w4);
            w1.Add(w7);
            w7.Add(w4);
            napis = "";
            A(w1);
            MessageBox.Show(napis);
        }
        List<Wezel2> odwiedzony = new();
        void A(Wezel2 w)
        {
            odwiedzony.Add(w);
            napis += w.wartosc.ToString() + " ";
            foreach (var sasiad in w.sasiedzi)
            {
                if (!odwiedzony.Contains(sasiad))
                {
                    A(sasiad);
                }
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            DrzewoBinarne drzewo = new(5);
            drzewo.Add(4);
            drzewo.Add(8);
            drzewo.Add(7);
            drzewo.Add(6);
            drzewo.Add(9);
            drzewo.Add(7);
            drzewo.Add(1);
            drzewo.Add(4);
            drzewo.Add(3);
            drzewo.Add(5);
            drzewo.Add(2);
            drzewo.Add(2);
            var w = drzewo.ZnajdzMin(drzewo.korzen);
            while(w!=null)
            {
                MessageBox.Show(w.wartosc.ToString());
                w = drzewo.Nastepnik(w);
            }
            //drzewo.Usun(drzewo.korzen.prawy);

            /*var k1 = new Wezel4(0);
            k1.DodajKrawedz(1, 3);
            k1.DodajKrawedz(5, 6);
            k1.DodajKrawedz(4, 3);
            var k2 = new Wezel4(1);
            k2.DodajKrawedz(3, 4);
            k2.DodajKrawedz(2, 1);
            var g1 = new Grafy(k1);*/
        }
    }
}