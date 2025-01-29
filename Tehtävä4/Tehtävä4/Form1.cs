namespace Tehtävä4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            DateTime d1 = DateTime.Now;
            DateTime d2 = synttariDT.Value;

            TimeSpan t = d1 - d2;
            double erotus = t.TotalDays;

            VuosissaLB.Text = Math.Floor(erotus / 365.25) + " vuotta";
            KuukausissaLB.Text = Math.Ceiling(erotus * 12 / 365.25) + " kuukautta";
            Paivissa.Text = Math.Floor(erotus) + " päivää";
            TunneissaLB.Text = Math.Floor(erotus) * 24 + " tuntia";
            MinuuteissaLB.Text = Math.Floor(erotus) * 24 * 60 + " minuuttia";
            SekunneissaLB.Text = Math.Floor(erotus) * 24 * 60 * 60 + " sekuntia";
            VuosissaLB.Visible = true;
            KuukausissaLB.Visible = true;
            Paivissa.Visible = true;
            TunneissaLB.Visible = true;
            MinuuteissaLB.Visible = true;
            SekunneissaLB.Visible = true;

        }
    }
}