using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen T.C. Kimlik Numaranızı Giriniz.");
                return;

            }
            if(textBox1.TextLength < 11)
            {
                MessageBox.Show("Tc Kimlik Numarası hatalı.");
                return;

            }
            if (textBox1.TextLength > 11)
            {
                MessageBox.Show("Tc Kimlik Numarası hatalı.");
                return;

            }
            

                Form10.ActiveForm.Hide();
            Form4 f = new Form4();
            f.ShowDialog();

        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }
    }
}
