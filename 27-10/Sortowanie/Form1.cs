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
    }
}