using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class ChooseTest : Form
    {
        public Point mouseLocation;
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
            for (var i = 0; i < fileArray.Length; i++)
            {
                checkedListBox1.Items.Add(fileArray[i].Substring(6, fileArray[i].Length - 10));
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count >= 1 && e.CurrentValue != CheckState.Checked)

            {

                e.NewValue = e.CurrentValue;

                MessageBox.Show("Можно выбрать только один вариант");

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedIndex == 0)
            {
                Program.var = 0;
                Program.test_name = fileArray[0].Substring(6, fileArray[0].Length - 10);
                Test TestForm = new Test();
                Close();
                TestForm.ShowDialog();
            }
            if (checkedListBox1.SelectedIndex == 1)
            {
                Program.var = 1;
                Program.test_name = fileArray[1].Substring(6, fileArray[1].Length - 10);
                Test TestForm = new Test();
                Close();
                TestForm.ShowDialog();
            }
            if (checkedListBox1.SelectedIndex == 2)
            {
                Program.var = 2;
                Program.test_name = fileArray[2].Substring(6, fileArray[2].Length - 10);
                Test TestForm = new Test();
                Close();
                TestForm.ShowDialog();
            }
            if (checkedListBox1.SelectedIndex == 3)
            {
                Program.var = 3;
                Program.test_name = fileArray[3].Substring(6, fileArray[3].Length - 10);
                Test TestForm = new Test();
                Hide();
                Close();
                TestForm.ShowDialog();
            }
            if (checkedListBox1.SelectedItem == null)
            {
                MessageBox.Show("Сначала нужно выбрать тест");
            }
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void ChooseTest_MouseMove(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void ChooseTest_MouseDown(object sender, MouseEventArgs e)
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
