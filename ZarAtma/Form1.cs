using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarAtma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
                 
        }

        int sayac = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {

            Random rnd = new Random();

            int zar1;
            int zar2;

            zar1 = rnd.Next(0, 6);
            zar2 = rnd.Next(0, 6);

            pictureBox1.Image = imageList1.Images[zar1];
            pictureBox2.Image = imageList1.Images[zar2];


            sayac++;

            if(sayac == 20)
            {
                timer1.Stop();
                sayac = 0;
            }

        }
    }
}
