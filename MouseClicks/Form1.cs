namespace MouseClicks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_onClick(object sender, EventArgs e)
        {
            var n = int.Parse(this.clicksNumber.Text);
            this.clicksNumber.Text = Convert.ToString(++n);
        }
    }
}