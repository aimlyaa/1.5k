using System;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class auth : Form
    {
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
                Авторизация.Visible = false;
                StreamReader sr = new StreamReader(@"группы\"+group+".txt");

                for (int i = 0; i < File.ReadAllLines(@"группы\" + group + ".txt").Length; i++)
                {
                    line = sr.ReadLine();
                    if (name == line)
                    {
                        ChooseTest GetTestForm = new ChooseTest();
                        Hide();
                        GetTestForm.Show();
                        break;
                    }
                    else
                    {
                        Авторизация.Text = "Пользователь не найден";
                        Авторизация.Visible = true;
                    }
                }
            }
            catch
            {
                Авторизация.Text = "Пользователь не найден";
                Авторизация.Visible = true;
            }
        }

        private void auth_Load(object sender, EventArgs e)
        {

        }
    }
}
