namespace Formsy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SB_Click(object sender, EventArgs e)
        {
            ulong liczbaN = (ulong)nupLiczbaN.Value;

            ulong wynik = (uint)liczbaN);

            MessageBox.Show(wynik.ToString());
        }

        private void LiczbyN_TextChanged(object sender, EventArgs e)
        {

        }

        private void gen_Click(object sender, EventArgs e)
        {

        }

        private void SS_Click(object sender, EventArgs e)
        {

        }

        private void SI_Click(object sender, EventArgs e)
        {

        }

        private void SM_Click(object sender, EventArgs e)
        {

        }
    }
}