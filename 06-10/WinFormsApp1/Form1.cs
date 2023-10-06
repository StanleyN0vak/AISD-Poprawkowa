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
            int liczbaN = (int)nupLiczbaN.Value;

            int wynik = Fib(liczbaN);

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

    }
}