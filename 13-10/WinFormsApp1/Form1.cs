namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ulong liczbaN = (ulong)nupLiczbaN.Value;

            ulong wynik = Fib2((uint)liczbaN);

            MessageBox.Show(wynik.ToString());
        }

        int Fib(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            return Fib(n - 1) + Fib(n - 2);
        }

        ulong Fib2(uint n)
        {
            ulong[] wyrazy = new ulong[n + 1];
            if (n == 0)
                return 0;
            wyrazy[0] = 0;
            wyrazy[1] = 1;
            for (int i = 2; i < wyrazy.Length; i++)
            {
                wyrazy[i] += wyrazy[i - 1] + wyrazy[i - 2];
            }
            return wyrazy[n];
        }

    }
}