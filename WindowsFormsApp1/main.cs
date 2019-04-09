using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lection lect = new Lection();
            lect.pictureBox1.Image = Properties.Resources._2;
            lect.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lection lect = new Lection();
            lect.pictureBox1.Image = Properties.Resources.Безымянный;
            lect.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Lection lect = new Lection();
            lect.pictureBox1.Image = Properties.Resources._5;
            lect.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lection lect = new Lection();
            lect.pictureBox1.Image = Properties.Resources._31;
            lect.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Lection lect = new Lection();
            lect.pictureBox1.Image = Properties.Resources._4;
            lect.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            auth auth = new auth();
            auth.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Lection lect = new Lection();
            lect.pictureBox1.Image = Properties.Resources.pr1;
            lect.Text = "Работа N 1. Наблюдение видимого суточного вращения звездного неба";
            lect.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Lection lect = new Lection();
            lect.pictureBox1.Image = Properties.Resources.pr2;
            lect.Text = "Работа N 2. Наблюдение годичного изменения вида звездного неба";
            lect.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Lection lect = new Lection();
            lect.pictureBox1.Image = Properties.Resources.pr3;
            lect.Text = "Работа N 3. Наблюдение изменения полуденной высоты Солнца";
            lect.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Lection lect = new Lection();
            lect.pictureBox1.Image = Properties.Resources.pr4;
            lect.Text = "Работа N 4. Определение направления небесного меридиана";
            lect.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Lection lect = new Lection();
            lect.pictureBox1.Image = Properties.Resources.pr5;
            lect.Text = "Работа N 5. Наблюдение за движением планет среди звезд";
            lect.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Lection lect = new Lection();
            lect.pictureBox1.Image = Properties.Resources.l6;
            lect.Text = "Лекция 6. Яркость небесных тел. Шкала звездных величин.";
            lect.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Lection lect = new Lection();
            lect.pictureBox1.Image = Properties.Resources.l7;
            lect.Text = "Лекция 7.Адаптивная оптика в современных рефлекторах.";
            lect.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {

            Lection lect = new Lection();
            lect.pictureBox1.Image = Properties.Resources.l8;
            lect.Text = "Лекция 8.Дифракционный предел телескопа.";
            lect.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Lection lect = new Lection();
            lect.pictureBox1.Image = Properties.Resources.l9;
            lect.Text = "Лекция 9.Наблюдения в неоптическом диапазоне.";
            lect.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Lection lect = new Lection();
            lect.pictureBox1.Image = Properties.Resources.l10;
            lect.Text = "Лекция 10.Прозрачность атмосферы.";
            lect.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Lection lect = new Lection();
            lect.pictureBox1.Image = Properties.Resources.l11;
            lect.Text = "Лекция 11.Радиотелескопы.";
            lect.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Lection lect = new Lection();
            lect.pictureBox1.Image = Properties.Resources.l12;
            lect.Text = "Лекция 12.Рентгеновские и гамма-телескопы.";
            lect.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Lection lect = new Lection();
            lect.pictureBox1.Image = Properties.Resources.l13;
            lect.Text = "Лекция 13.Нейтринные обсерватории.";
            lect.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Lection lect = new Lection();
            lect.pictureBox1.Image = Properties.Resources.l14;
            lect.Text = "Лекция 14.Гравитация в классической механике.";
            lect.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Lection lect = new Lection();
            lect.pictureBox1.Image = Properties.Resources.l15;
            lect.Text = "Лекция 15. Задача двух тел. Законы Кеплера.";
            lect.Show();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            Lection lect = new Lection();
            lect.pictureBox1.Image = Properties.Resources.pr6;
            lect.Text = "Работа N 6. Работа с подвижной здведной картой.";
            lect.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Lection lect = new Lection();
            lect.pictureBox1.Image = Properties.Resources.pr7;
            lect.Text = "Работа N 7. Определение расстояний иразмеров тел в солнечной системе.";
            lect.Show();
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            reg reg = new reg();
            reg.ShowDialog();
        }
    }
}
