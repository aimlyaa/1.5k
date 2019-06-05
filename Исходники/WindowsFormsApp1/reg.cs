using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class reg : Form
    {
        public Point mouseLocation;
        public reg()
        {
            InitializeComponent();
        }

        private void Reg_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(@"группы\"+ textBox2.Text +".txt", true, System.Text.Encoding.UTF8))
            {
                sw.WriteLine("");
                sw.WriteLine(textBox1.Text);
                succes suc = new succes();
                suc.ShowDialog();
                Hide();
                Close();
            }
        }

        private void Button2_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void Button26_Click(object sender, System.EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Reg_MouseMove(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void Reg_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }
    }
}
