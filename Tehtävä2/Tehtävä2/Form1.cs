namespace Tehtävä2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TulostaBT_Click(object sender, EventArgs e)
        {
            TulostusLB.Text = ViestiTB.Text;
            TulostusLB.Visible= true;
        }
    }
}