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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "Gider Gösteren Bilgisi")
            {
                MessageBox.Show("Lütfen Gider Gösteren Bilgisini Giriniz.");
                return;
            }
            if (textBox2.Text == "" || textBox2.Text == "Vergi Dairesi")
            {
                MessageBox.Show("Lütfen Vergi Dairenizi Giriniz.");
                return;
            }
            if (textBox3.Text == "" || textBox3.Text == "Vergi/TCKN No")
            {
                MessageBox.Show("Lütfen Vergi/TCKN Nonuzu Giriniz.");
                return;
            }
            if (textBox3.TextLength < 11)
            {
                MessageBox.Show("Vergi/TCKN Nonuzu Eksik Tuşladınız.Lütfen Vergi/TCKN Nonuzu Giriniz.");
                return;

            }
            if (textBox3.TextLength > 11)
            {
                MessageBox.Show("Vergi/TCKN Nonuzu Fazla Tuşladınız.Lütfen Vergi/TCKN Nonuzu Giriniz.");
                return;

            }
            Form5.ActiveForm.Hide();
            Form4 f = new Form4();
            f.ShowDialog();

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
        }
    }
}
