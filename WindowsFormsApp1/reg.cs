using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class reg : Form
    {
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
    }
}
