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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "Kart Sahibi Ad  Soyad")
            {
                MessageBox.Show("Lütfen Kart Sahibi Adı Soyadını Giriniz.");
                return;
            }
            if (textBox2.Text == "" || textBox1.Text == "Kart Numarası")
            {
                MessageBox.Show("Lütfen Kart Numarasını Giriniz.");
                return;
            }
            if (textBox3.Text == "" || textBox1.Text == "AA")
            {
                MessageBox.Show("Lütfen Kartın Son Kullanım Tarihini Giriniz.");
                return;
            }
            if (textBox4.Text == "" || textBox1.Text == "YY")
            {
                MessageBox.Show("Lütfen Kartın Son Kullanım Tarihini Giriniz.");
                return;
            }
            if (textBox5.Text == "" || textBox1.Text == "CVV")
            {
                MessageBox.Show("Lütfen Kartın CVV Kodunu Giriniz.");
                return;
            }
            if (textBox2.TextLength < 16)
            {
                MessageBox.Show("Kart Numarasını Eksik Tuşladınız.Lütfen Kart Numarasını Giriniz.");
                return;

            }
            if (textBox2.TextLength > 16)
            {
                MessageBox.Show("Kart Numarasını Fazla Tuşladınız.Lütfen Kart Numarasını Giriniz.");
                return;

            }
            if (textBox3.TextLength < 2)
            {
                MessageBox.Show("Kartın Son Kullanım Tarihini Eksik Tuşladınız.Lütfen Kartın Son Kullanım Tarihini Giriniz.");
                return;

            }
            if (textBox3.TextLength > 2)
            {
                MessageBox.Show("Kartın Son Kullanım Tarihini Fazla Tuşladınız.Lütfen Kartın Son Kullanım Tarihini Giriniz.");
                return;

            }
            if (textBox4.TextLength < 2)
            {
                MessageBox.Show("Kartın Son Kullanım Tarihini Eksik Tuşladınız.Lütfen Kartın Son Kullanım Tarihini Giriniz.");
                return;

            }
            if (textBox4.TextLength > 2)
            {
                MessageBox.Show("Kartın Son Kullanım Tarihini Fazla Tuşladınız.Lütfen Kartın Son Kullanım Tarihini Giriniz.");
                return;

            }
            if (textBox5.TextLength < 3)
            {
                MessageBox.Show("Kartın CVV Kodunu Eksik Tuşladınız.Lütfen Kartın CVV Kodunu Giriniz.");
                return;

            }
            if (textBox5.TextLength > 3)
            {
                MessageBox.Show("Kartın CVV Kodunu Fazla Tuşladınız.Lütfen Kartın CVV Kodunu Giriniz.");
                return;

            }
            if (checkBox1.Checked == true && linkLabel1.LinkVisited == true)
            {
                Form4.ActiveForm.Hide();
                Form6 f = new Form6();
                Form6.instance.gelecekyolcuadisoyadi.Text = Form2.instance.t1.Text;
                Form6.instance.gelecekkalkış.Text = Form2.instance.l1.Text;
                Form6.instance.gelecekvarış.Text = Form2.instance.l2.Text;
                Form6.instance.gelecekcinsiyet.Text = Form2.instance.l4.Text;
                
                Form6.instance.gelecekyolcuadisoyadi1.Text = Form2.instance.t1.Text;
                f.ShowDialog();
            }
            else if(checkBox1.Checked == false && linkLabel1.LinkVisited == true)
            {
                MessageBox.Show("Lütfen Satış Sözleşmesini Onaylayınız.");
                return;
            }
            else if (checkBox1.Checked == true && linkLabel1.LinkVisited == false)
            {
                MessageBox.Show("Lütfen Satış Sözleşmesini Okuyunuz.");
                return;
            }
            else
            {
                MessageBox.Show("Lütfen Satış Sözleşmesini Okuyunuz ve Onaylayınız.");
                return;
            }


        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited =true;
            Form7 fw = new Form7();
            fw.ShowDialog();
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
