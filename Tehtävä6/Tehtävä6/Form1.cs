namespace Tehtävä6
{
    public partial class SalasanaFM : Form
    {
        public SalasanaFM()
        {
            InitializeComponent();
        }

        private void tarkistaBT_Click(object sender, EventArgs e)
        {
            if(kayttajatunnusTB.Text == "Jyri" && salasanaTB.Text == "Ja@kk0ku1ta")
            {
                SalasanaPL.Visible = false;
                salasanaOikeinPL.Visible = true;
            }
            else
            {
                virheViestiLB.Text = "Käyttäjätunnus tai \nsalasana virheellinen";
                virheViestiLB.Visible = true;
            }
        }
    }
}