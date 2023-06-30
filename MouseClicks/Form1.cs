using System.Windows.Forms;

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

        private String CoordinatesToString(MouseEventArgs e)
        {
            return "Mouse Coordinates: (x: " + e.X.ToString() + "; y: " + e.Y.ToString()+ ")";
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.mouseCoordinatesText.Text = CoordinatesToString(e);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            String message = "";

            if (e.Button == MouseButtons.Right)
            {
                message = "Right Click!";
            }

            if (e.Button == MouseButtons.Left)
            {
                message = "Left Click!";
            }

            message += "\n" + CoordinatesToString(e);

            String caption = "Mouse Click Detected";

            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}