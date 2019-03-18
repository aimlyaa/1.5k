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
            if (Program.ended)
            {
                StreamReader sr = new StreamReader(@"результаты\" + auth.name + ", " + Program.test_name + ".txt");
                for (int i = 0; i < File.ReadAllLines(@"результаты\" + auth.name + ", " + Program.test_name + ".txt").Length; i++)
                {
                    line = sr.ReadLine();
                    label1.Text = label1.Text + line;
                }
            }
            else
            {
                label1.Text =
                @"Результат " + Program.good + " правильных вопросов из 20 \n\n\n" +
                "Оценка: ";
                if (Program.ocenka == 2)
                {
                    label2.ForeColor = Color.Red;
                }
                if (Program.ocenka == 3)
                {
                    label2.ForeColor = Color.Orange;
                }
                if (Program.ocenka == 4)
                {
                    label2.ForeColor = Color.Yellow;
                }
                if (Program.ocenka == 5)
                {
                    label2.ForeColor = Color.Green;
                }
                label2.Text = Program.ocenka.ToString();
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
