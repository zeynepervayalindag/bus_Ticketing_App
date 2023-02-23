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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] koltuk = { "04", "03", "08", "07", "12", "11", "16", "15", "20", "19", "24", "23", "28", "27", "34", "33", "38", "37", "42", "41", "46", "45", "50", "49" };
            string[] koltuk3 = { "01", "05", "09", "13", "17", "21", "25", "29", "31", "35", "39", "43", "47" };
            for (int k = 0; k < koltuk.Length;)
            {
                for (int l = 0; l < koltuk3.Length;)
                {
                    for (int i = 1; i <= 13; i++)
                    {
                        for (int j = 1; j <= 4; j++)
                        {
                            if (j != 3)
                            {
                                if (j != 4 && i != 8)
                                {
                                    Button koltuk2 = new Button();
                                    koltuk2.Text = koltuk[k];
                                    koltuk2.Name = koltuk[k];
                                    koltuk2.Size = new Size(30, 30);
                                    koltuk2.Location = new Point(70 * i, 70 * j);
                                    koltuk2.ContextMenuStrip = contextMenuStrip1;
                                    this.Controls.Add(koltuk2);
                                    k++;
                                }
                            }
                            if (j == 4)
                            {
                                Button koltuk2 = new Button();
                                koltuk2.Text = koltuk3[l];
                                koltuk2.Name = koltuk3[l];
                                koltuk2.Size = new Size(30, 30);
                                koltuk2.Location = new Point(70 * i, 70 * j);
                                koltuk2.ContextMenuStrip = contextMenuStrip1;
                                this.Controls.Add(koltuk2);
                                l++;
                            }
                        }
                    }
                }
            }
            

        }

        private void kADINToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form2 f = new Form2();
            string mesaj = comboBox1.Text;
            string mesaj2 = comboBox2.Text;
            string mesaj3 = dateTimePicker1.Text;
            
            f.Form2ye_Gidecek_Veri = mesaj;
            f.Form2ye_Gidecek_Veri2 = mesaj2;
            f.Form2ye_Gidecek_Veri3 = mesaj3;
            f.ShowDialog();




        }

        private void eRKEKToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form2 f = new Form2();
            string mesaj = comboBox1.Text;
            string mesaj2 = comboBox2.Text;
            string mesaj3 = dateTimePicker1.Text;
            
            f.Form2ye_Gidecek_Veri = mesaj;
            f.Form2ye_Gidecek_Veri2 = mesaj2;
            f.Form2ye_Gidecek_Veri3 = mesaj3;
            f.ShowDialog();

           

            
        }
        
    }
}


