using System;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class ChooseTest : Form
    {
        public ChooseTest()
        {
            InitializeComponent();
        }
        public static string line;
        public static string s_item;
        public static string[] fileArray;
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Program.var = 0;
            Program.test_name = fileArray[0].Substring(6, fileArray[0].Length - 10);
            Test TestForm = new Test();
            Hide();
            TestForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.var = 1;
            Program.test_name = fileArray[1].Substring(6, fileArray[1].Length - 10);
            Test TestForm = new Test();
            Hide();
            TestForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.var = 2;
            Program.test_name = fileArray[2].Substring(6, fileArray[2].Length - 10);
            Test TestForm = new Test();
            Hide();
            TestForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.var = 3;
            Program.test_name = fileArray[3].Substring(6, fileArray[3].Length - 10);
            Test TestForm = new Test();
            Hide();
            TestForm.Show();
        }

        private void ChooseTest_Load(object sender, EventArgs e)
        {
            fileArray = Directory.GetFiles(@"тесты\", "*.txt");
            button1.Text = fileArray[0].Substring(6, fileArray[0].Length - 10);
            button2.Text = fileArray[1].Substring(6, fileArray[1].Length - 10);
            button3.Text = fileArray[2].Substring(6, fileArray[2].Length - 10);
            button4.Text = fileArray[3].Substring(6, fileArray[3].Length - 10);
        }
    }
}
