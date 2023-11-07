using System.Diagnostics;

namespace Sortowanie
{
    public partial class Form1 : Form
    {
        private int[] ints;
        public Form1()
        {
            InitializeComponent();
        }

        private void SelectBubble_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                string tekst = Dane.Text;
                int[] tab = new int[tekst.Length];
                tab = Convert(tekst);
                tab = SortB(tab);
                string score = string.Join(" ", tab);
                Wynik.Text = score;
            }
            else
            {
                int[] tab = new int[ints.Length];
                Array.Copy(ints, tab, ints.Length);
                Stopwatch watch = new Stopwatch();
                watch.Start();
                SortB(tab);
                watch.Stop();
                time.Text = watch.ElapsedMilliseconds.ToString();
            }
            
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
            if (!checkBox1.Checked)
            {
                string tekst = Dane.Text;
                int[] tab = new int[tekst.Length];
                tab = Convert(tekst);
                tab = SortS(tab);
                string score = string.Join(" ", tab);
                Wynik.Text = score;
            }
            else
            {
                int[] tab = new int[ints.Length];
                Array.Copy(ints, tab, ints.Length);
                Stopwatch watch = new Stopwatch();
                watch.Start();
                SortS(tab);
                watch.Stop();
                time.Text = watch.ElapsedMilliseconds.ToString();
            }

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

        private void SelectInsert_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                string tekst = Dane.Text;
                int[] tab = new int[tekst.Length];
                tab = Convert(tekst);
                tab = SortI(tab);
                string score = string.Join(" ", tab);
                Wynik.Text = score;
            }
            else
            {
                int[] tab = new int[ints.Length];
                Array.Copy(ints, tab, ints.Length);
                Stopwatch watch = new Stopwatch();
                watch.Start();
                SortI(tab);
                watch.Stop();
                time.Text = watch.ElapsedMilliseconds.ToString();
            }

        }

        int[] SortI(int[] tablica)
        {
            int temp = 0, j = 0, x = 0;
            for (int i = 1; i < tablica.Length; i++)
            {
                j = i - 1;
                x = i;
                while (j >=0 && tablica[x] < tablica[j])
                {
                    temp = tablica[x];
                    tablica[x] = tablica[j];
                    tablica[j] = temp;
                    j--; x--;
                }
            }
            return tablica;
        }

        private void SelectMerch_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                string tekst = Dane.Text;
                int[] tab = new int[tekst.Length];
                tab = Convert(tekst);
                SortM(tab);
                string score = string.Join(" ", tab);
                Wynik.Text = score;
            }
            else
            {
                int[] tab = new int[ints.Length];
                Array.Copy(ints, tab, ints.Length);
                Stopwatch watch = new Stopwatch();
                watch.Start();
                SortM(tab);
                watch.Stop();
                time.Text = watch.ElapsedMilliseconds.ToString();
            }

        }

        public static void SortM(int[] tablica)
        {
            if (tablica.Length <= 1) return;

            int half = tablica.Length / 2;
            int[] left = new int[half];
            int[] right = new int[tablica.Length - half];

            for (int i = 0; i < half; i++)
            {
                left[i] = tablica[i];
            }

            for (int i = half; i < tablica.Length; i++)
            {
                right[i - half] = tablica[i];
            }

            SortM(left);
            SortM(right);
            Merge(tablica, left, right);
        }

        private static void Merge(int[] result, int[] left, int[] right)
        {
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] < right[j])
                {
                    result[k++] = left[i++];
                }
                else
                {
                    result[k++] = right[j++];
                }
            }

            while (i < left.Length)
            {
                result[k++] = left[i++];
            }

            while (j < right.Length)
            {
                result[k++] = right[j++];
            }
        }

        private void SelectQuick_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                string tekst = Dane.Text;
                int[] tab = new int[tekst.Length];
                tab = Convert(tekst);
                SortQ(tab, 0, tab.Length);
                string score = string.Join(" ", tab);
                Wynik.Text = score;
            }
            else
            {
                int[] tab = new int[ints.Length];
                Array.Copy(ints, tab, ints.Length);
                Stopwatch watch = new Stopwatch();
                watch.Start();
                SortQ(tab, 0, tab.Length);
                watch.Stop();
                time.Text = watch.ElapsedMilliseconds.ToString();
            }
        }

        public static void SortQ(int[] table, int low, int high)
        {
            if (low < high)
            {
                int pi = partition(table, low, high - 1);
                SortQ(table, low, pi);
                SortQ(table, pi + 1, high);
            }
        }

        private static int partition(int[] table, int low, int high)
        {
            int pivot = table[low];
            int i = low, j = high, temp = 0;

            while (true)
            {
                while (table[i] < pivot)
                {
                    i++;
                }
                while (table[j] > pivot)
                {
                    j--;
                }
                if (i < j)
                {
                    temp = table[i];
                    table[i] = table[j];
                    table[j] = temp;
                    i++;
                    j--;
                }
                else
                {
                    return j;
                }
            }
        }

        int[] Convert(string napis)
        {
            var liczbyS = napis.Trim().Split(' ');                
            var wynik = new int[liczbyS.Length];
            if (string.IsNullOrEmpty(napis))
                return wynik;

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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Dane.Enabled = !checkBox1.Checked;
            Wynik.Enabled = !checkBox1.Checked;

            nud.Enabled = checkBox1.Checked;
            generuj.Enabled = checkBox1.Checked;
        }

        private void nud_ValueChanged(object sender, EventArgs e)
        {

        }

        private void generuj_Click(object sender, EventArgs e)
        {
            int ile = (int)nud.Value;
            ints = create(ile);
        }

        int[] create(int ile)
        {
            int[] wynik = new int[ile];
            Random random = new Random();
            for (int i = 0; i < ile; i++)
            {
                wynik[i] = random.Next();
            }
            return wynik;
        }

        private void time_Click(object sender, EventArgs e)
        {

        }
    }
}