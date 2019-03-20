using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApp1
{
    public partial class Resultat : Form
    {
        public Resultat()
        {
            InitializeComponent();
        }
        public static string line;
        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Text = auth.name + ", " + Program.test_name;
            if (Program.ended)
            {
                label1.Text = "РЕЗУЛЬТАТ:";
                label4.Text = "ОЦЕНКА:";
                label3.ForeColor = Color.Red;
                StreamReader sr = new StreamReader(@"результаты\" + auth.name + ", " + Program.test_name + ".txt");
                    line = sr.ReadLine();
                    if (int.Parse(line.Substring(0, 2)) >= 5)
                    {
                        label2.ForeColor = Color.Orange;
                        label3.ForeColor = Color.Orange;
                    }
                    if (int.Parse(line.Substring(0, 2)) >= 10)
                    {
                        label2.ForeColor = Color.Yellow;
                        label3.ForeColor = Color.Yellow;
                    }
                    if (int.Parse(line.Substring(0, 2)) >= 15)
                    {
                        label2.ForeColor = Color.Green;
                        label3.ForeColor = Color.Green;
                    }
                    label3.Text = label3.Text + line;
                    line = sr.ReadLine();
                    label2.Text = label2.Text + line.Substring(8, 1);
            }
            else
            {
                label1.Text = "РЕЗУЛЬТАТ:";
                label4.Text = "ОЦЕНКА:";
                if (Program.ocenka == 2)
                {
                    label2.ForeColor = Color.Red;
                    label3.ForeColor = Color.Red;
                }
                if (Program.ocenka == 3)
                {
                    label2.ForeColor = Color.Orange;
                    label3.ForeColor = Color.Orange;
                }
                if (Program.ocenka == 4)
                {
                    label2.ForeColor = Color.Yellow;
                    label3.ForeColor = Color.Yellow;
                }
                if (Program.ocenka == 5)
                {
                    label2.ForeColor = Color.Green;
                    label3.ForeColor = Color.Green;
                }
                label2.Text = Program.ocenka.ToString();
                label3.Text = Program.good + " правильных вопросов из 20";
            }
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
