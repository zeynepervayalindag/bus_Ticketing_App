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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)

            {
                Form9.ActiveForm.Hide();
                Form10 fb = new Form10();
                fb.ShowDialog();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)

            {
                Form9.ActiveForm.Hide();
                Form5 fa = new Form5();
                fa.ShowDialog();
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
    }
}
