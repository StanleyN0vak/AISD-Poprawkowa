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
            w1.dzieci.Add(w6);
            napis = "";
            A(w1);
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
    }
}