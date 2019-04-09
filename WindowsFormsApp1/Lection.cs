using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Lection : Form
    {
        private static bool resized = true;
        private void resize_button()
        {
            if (resized)
            {
                button1.Size = new Size(352, 155);
                button1.Location = new Point(button1.Location.X - 290, button1.Location.Y - 123);
            }
            else
            {
                button1.Size = new Size(97, 40);
                button1.Location = new Point(1155, 773);
            }
            resized = !resized;
        }
        public Lection()
        {
            InitializeComponent();
        }
        private void Lection_FormClosed(object sender, FormClosedEventArgs e)
        {
            resized = true;
        }
        private void Lection_Resize(object sender, System.EventArgs e)
        {
            resize_button();
        }
        private void Button1_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void Lection_Load(object sender, System.EventArgs e)
        {
            //flowLayoutPanel1.Width = pictureBox1.Image.Width;
            pictureBox1.Width = Properties.Resources.pr1.Width;
        }
    }
}
