using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Visible = true;
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.Visible = true;
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.Visible = true;
        }

        private void button6_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox4.Visible = true;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
        }
        private void button5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
        }
        private void button6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
        }
        public static int one = 0;
        public static int two = 1;
        public static int three = 2;
        public static int four = 3;
        public void check()
        {
            if (Program.curr_answ == Program.good_ans[Program.qust_counter - 1])
            {
                Program.good++;
            }
        }
        public void work()
        {
            label1.Text = Program.qsts[Program.qust_counter];
            button3.Text = Program.ans[Program.qust_counter + one];
            button4.Text = Program.ans[Program.qust_counter + two];
            button5.Text = Program.ans[Program.qust_counter + three];
            button6.Text = Program.ans[Program.qust_counter + four];
            label2.Text = (Program.qust_counter + 1).ToString() + " Вопрос из 20";
            label3.Text = "Правильных ответов из 20";
            label5.Text = Program.good.ToString();
            if (Program.good >= 5)
            {
                label5.ForeColor = Color.Orange;
            }
            if (Program.good >= 10)
            {
                label5.ForeColor = Color.Yellow;
            }
            if (Program.good >= 15)
            {
                label5.ForeColor = Color.Green;
            }
            one = one + 3;
            two = two + 3;
            three = three + 3;
            four = four + 3;
        }
        public void disable_button()
        {
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Text = auth.name + ", " + Program.test_name;
            int q = 0;
            int y = 1;
            int x = 0;
            int z = 5;
            StreamReader sr = new StreamReader(ChooseTest.fileArray[Program.var]);
            for (int i = 0; i < 20; i++)
            {
                Program.qsts[i] = File.ReadLines(ChooseTest.fileArray[Program.var]).Skip(q).First();
                Program.good_ans[i] = File.ReadLines(ChooseTest.fileArray[Program.var]).Skip(z).First();
                for (int p = 0; p < 4; p++)
                {
                    Program.ans[x] = File.ReadLines(ChooseTest.fileArray[Program.var]).Skip(y).First();
                    y++;
                    x++;
                }
                z = z + 6;
                q = q + 6;
                y = y + 2;
            }
            label4.Text = "Осталось " + Program.timer + " минут";
            work();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.qust_counter += 1;
            Program.curr_answ = button3.Text;
            if (Program.qust_counter >= 20)
            {
                check();
                label5.Text = Program.good.ToString();
                disable_button();
            }
            else
            {
                check();
                work();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.qust_counter += 1;
            Program.curr_answ = button4.Text;
            if (Program.qust_counter >= 20)
            {
                check();
                label5.Text = Program.good.ToString();
                disable_button();
            }
            else
            {
                check();
                work();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.qust_counter += 1;
            Program.curr_answ = button5.Text;
            if (Program.qust_counter >= 20)
            {
                check();
                label5.Text = Program.good.ToString();
                disable_button();
            }
            else
            {
                check();
                work();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Program.qust_counter += 1;
            Program.curr_answ = button6.Text;
            if (Program.qust_counter >= 20)
            {
                check();
                label5.Text = Program.good.ToString();
                disable_button();
            }
            else
            {
                check();
                work();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Program.good > 5)
            {
                Program.ocenka = 3;
            }
            if (Program.good > 10)
            {
                Program.ocenka = 4;
            }
            if (Program.good > 15)
            {
                Program.ocenka = 5;
            }
            FileStream sr = new FileStream(@"результаты\" + auth.name + ", " + Program.test_name + ".txt", FileMode.OpenOrCreate);
            byte[] array = Encoding.UTF8.GetBytes(Program.good + " правильных ответов из 20 \n" + "Оценка: " + Program.ocenka + "\n Пройдено: " + DateTime.Now.ToString("MM/dd/yy H:mm:ss"));
            sr.Write(array, 0, array.Length);
            Resultat TestResult = new Resultat();
            Hide();
            Close();
            TestResult.ShowDialog();
        }

        private void Form3_Shown(object sender, EventArgs e)
        {
            if (File.Exists(@"результаты\" + auth.name + ", " + Program.test_name + ".txt"))
            {
                Program.ended = true;
                Resultat TestResult = new Resultat();
                Hide();
                Close();
                TestResult.ShowDialog();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Program.timer--;
            label4.Text = "Осталось " + Program.timer + " минут";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
