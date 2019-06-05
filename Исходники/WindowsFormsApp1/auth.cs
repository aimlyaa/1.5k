using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class auth : Form
    {
        public Point mouseLocation;
        public auth()
        {
            InitializeComponent();
        }
        public static string name;
        public static string group;
        public static string line;

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            group = textBox2.Text;

            try
            {
                label3.Visible = false;
                StreamReader sr = new StreamReader(@"группы\"+group+".txt");

                for (int i = 0; i < File.ReadAllLines(@"группы\" + group + ".txt").Length; i++)
                {
                    line = sr.ReadLine();
                    if (name == line)
                    {
                        ChooseTest GetTestForm = new ChooseTest();
                        Hide();
                        Close();
                        GetTestForm.ShowDialog();
                        break;
                    }
                    else
                    {
                        label3.Text = "Пользователь не найден";
                        label3.Visible = true;
                    }
                }
            }
            catch
            {
                label3.Text = "Пользователь не найден";
                label3.Visible = true;
            }
        }

        private void auth_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void auth_Load(object sender, EventArgs e)
        {

        }

        private void Button26_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Auth_MouseMove(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void Auth_MouseDown(object sender, MouseEventArgs e)
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
