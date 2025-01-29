namespace Tehtävä1
{
    public partial class Harjoitus1 : Form
    {
        public Harjoitus1()
        {
            InitializeComponent();
        }

        private void VaihtoBT_Click(object sender, EventArgs e)
        {
            if(TextLB.Text == "Heippa maailma!")
            {
                TextLB.Text = "Jotain uutta tekstiä";
            }
            else
            {
                TextLB.Text = "Heippa maailma!";
            }
            
        }
    }
}