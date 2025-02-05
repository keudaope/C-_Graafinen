namespace Tehtävä5
{
    public partial class LukujenJarjestysFM : Form
    {
        List<int> jono = new List<int>();
        public LukujenJarjestysFM()
        {
            InitializeComponent();
        }

        private void uusiLukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Enter)
            {
                if(uusiLukuTB.Text == "-999")
                {
                    vastausLB.Text = "";
                    int[] taulukko = jono.ToArray();
                    Array.Sort(taulukko);
                    foreach(var jasen in taulukko)
                    {
                        vastausLB.Text += jasen.ToString() + " ";
                        
                    }
                    vastausLB.Visible = true;
                }
                else
                {
                    jono.Add(Int32.Parse(uusiLukuTB.Text));
                    uusiLukuTB.Text = "";
                }
            }
            if(e.KeyChar == (char)Keys.Escape) 
            {
                TyhjaaLomake();
            }
        }
        private void TyhjaaLomake()
        {
            uusiLukuTB.Text = "";
            vastausLB.Visible = false;
        }
    }

}