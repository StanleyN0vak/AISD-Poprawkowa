namespace Sortowanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SelectBubble_Click(object sender, EventArgs e)
        {
            string tekst = Dane.Text;
            int[] tab = new int[tekst.Length];
            tab = Convert(tekst);
            tab = SortB(tab);
            string score = string.Join(" ", tab);
            Wynik.Text = score;
        }

        int[] SortB(int[] tablica)
        {
            bool cbz;
            int temp;
            do
            {
                cbz = false;
                for (int i = 0; i < tablica.Length - 1; i++)
                {
                    if (tablica[i] > tablica[i + 1])
                    {
                        temp = tablica[i + 1];
                        tablica[i + 1] = tablica[i];
                        tablica[i] = temp;
                        cbz = true;
                    }
                }
            } while (cbz);
            return tablica;
        }

        private void SelectSort_Click(object sender, EventArgs e)
        {
            string tekst = Dane.Text;
            int[] tab = new int[tekst.Length];
            tab = Convert(tekst);
            tab = SortS(tab);
            string score = string.Join(" ", tab);
            Wynik.Text = score;
        }

        int[] SortS(int[] tablica)
        {
            bool cbz = false;
            int temp1 = 0, temp2 = 0;
            do
            {
                cbz = false;
                for (int i = 0; i < tablica.Length; i++)
                {
                    temp1 = tablica[i];
                    for (int j = i; j < tablica.Length; j++)
                    {
                        if (temp1 > tablica[j])
                        {
                            temp2 = j;
                            cbz = true;
                            break;
                        }
                    }
                    if (cbz)
                    {
                        tablica[i] = tablica[temp2];
                        tablica[temp2] = temp1;
                    }
                }
            } while (cbz);
            return tablica;
        }

        int[] Convert(string napis)
        {
            var liczbyS = napis.Trim().Split(' ');
            var wynik = new int[liczbyS.Length];

            for (int i = 0; i < liczbyS.Length; i++)
            {
                wynik[i] = int.Parse(liczbyS[i]);
            }

            return wynik;
        }

        private void Dane_TextChanged(object sender, EventArgs e)
        {

        }

        private void Wynik_TextChanged(object sender, EventArgs e)
        {

        }
    }
}