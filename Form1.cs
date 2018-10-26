using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KortspelDemo
{
    public partial class Form1 : Form
    {

        Kortlek leken = new Kortlek();
        Kortlek kortlek = new Kortlek(true);
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Kort ettKort = leken.geKort();
            tbFarg.Text = ettKort.farg.ToString();
            tbValor.Text = ettKort.valor.ToString();

        }

        private void buEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buPicture_Click(object sender, EventArgs e)
        {
            if (kortlek.kortlekOK() == false)
                {
                return;
            }
            Kort ettKort = kortlek.geKort();
            pictureBox1.Image = ettKort.bild;

            ettKort = kortlek.geKort();
            pictureBox2.Image = ettKort.bild;

        }
    }
}
