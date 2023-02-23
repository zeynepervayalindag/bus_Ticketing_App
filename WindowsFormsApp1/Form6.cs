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
    public partial class Form6 : Form
    {
        public static Form6 instance;
        public Label gelecekyolcuadisoyadi;
        public Label gelecekkalkış;
        public Label gelecekvarış;
        public Label gelecekcinsiyet;
        public Label gelecekkoltuk;
        public Label gelecekyolcuadisoyadi1;



        public Form6()
        {
            InitializeComponent();
            instance= this;
            gelecekyolcuadisoyadi1 = id1;
            
            gelecekyolcuadisoyadi = label23;
            gelecekkalkış = id2;
            gelecekvarış = id3; 
            
            gelecekcinsiyet = label22;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Random rnd=new Random();
            string toplam = "";
            for (int y = 1; y <= 7; y++)
            {
                int x = rnd.Next(48, 58);
                char a =Convert.ToChar(x);
                toplam=toplam+a;    
            }
            label9.Text = toplam;

            string toplam1 = "";

            for (int y = 1; y <= 11; y++)
            {
                int c = rnd.Next(0, 2);
                if (c == 0)
                {
                    int z = rnd.Next(48, 58);
                    char b = Convert.ToChar(z);
                    toplam1 = toplam1 + b;
                }
                if (c == 1)
                {
                    int z = rnd.Next(65, 91);
                    char b = Convert.ToChar(z);
                    toplam1 = toplam1 + b;
                }

            }
            label4.Text = toplam1;
            gelecekyolcuadisoyadi1.Text= gelecekyolcuadisoyadi1.Text.ToUpper();




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
