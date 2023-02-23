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
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public Label l1;
        public Label l2;
        
        public Label l4;
        public TextBox t1;
        


        public Form2()
        {
            InitializeComponent();
            instance = this;
            l1 = label5;
            l2 = label7;
            
            l4 = label14;
            t1 = textBox1;
        }
        public string Form2ye_Gidecek_Veri = "";
        public string Form2ye_Gidecek_Veri2 = "";
        public string Form2ye_Gidecek_Veri3 = "";
        public string Form2ye_Gidecek_Veri4 = "";
        public string Form2ye_Gidecek_Veri5 = "";



        private void Form2_Load(object sender, EventArgs e)
        {
            
            label5.Text = Form2ye_Gidecek_Veri;
            label7.Text = Form2ye_Gidecek_Veri2;
            label8.Text = Form2ye_Gidecek_Veri3;
            label3.Text= Form2ye_Gidecek_Veri4;
            label14.Text = Form2ye_Gidecek_Veri5;





        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ""|| textBox1.Text == "Ad Soyad")
            {
                MessageBox.Show("Lütfen Ad Soyadınızı Giriniz.");
                return;
            }
            if (textBox2.Text == ""|| textBox2.Text == "T.C. Kimlik No")
            {
                MessageBox.Show("Lütfen T.C. Kimlik Nonuzu Giriniz.");
                return;
            }
            if (textBox3.Text == "" || textBox3.Text == "HES Kodu (Örn. A1B2-3456-78)")
            {
                MessageBox.Show("Lütfen HES Kodunuzu Giriniz.");
                return;
            }
            if (textBox4.Text == "" || textBox4.Text == "Cep Telefonu Giriniz")
            {
                MessageBox.Show("Cep Telefonunuzu Giriniz.");
                return;
            }
            
            if (textBox2.TextLength < 11)
            {
                MessageBox.Show("Tc Kimlik Numarası hatalı.");
                return;

            }
            if (textBox2.TextLength > 11)
            {
                MessageBox.Show("Tc Kimlik Numarası hatalı.");
                return;

            }
            if (textBox3.TextLength < 12)
            {
                MessageBox.Show("Hes Kodu Hatalı.");
                return;

            }
            if (textBox3.TextLength > 12)
            {
                MessageBox.Show("Hes Kodu Hatalı.");
                return;

            }
            if (textBox4.TextLength < 11)
            {
                MessageBox.Show("Cep Telefonunuzu Eksik Tuşladınız.Lütfen Cep Telefonunuzu Giriniz");
                return;

            }
            if (textBox4.TextLength > 11)
            {
                MessageBox.Show("Cep Telefonunuzu Fazla Tuşladınız.Lütfen Cep Telefonunuzu Giriniz");
                return;

            }

            if (checkBox1.Checked == true)
            {
                Form2.ActiveForm.Hide();
                Form9 fr = new Form9();
                fr.ShowDialog();
            }
            Form2.ActiveForm.Hide();
            Form4 f = new Form4();
            f.ShowDialog();
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
