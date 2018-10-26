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
    public partial class Speltest : Form
    {
        Kortlek leken = new Kortlek();
        Kortlek kortlek = new Kortlek(true);

        public Speltest()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kort ettKort = kortlek.geKort();
            pictureBox1.Image = ettKort.bild;

            Kort ettKort_två = kortlek.geKort();
            pictureBox2.Image = ettKort_två.bild;

            Kort ettKort_tre = kortlek.geKort();
            pictureBox3.Image = ettKort_tre.bild;

            if (ettKort.valor > ettKort_två.valor && ettKort.valor > ettKort_tre.valor)
            {
                MessageBox.Show("Kort 1 är störst");
            }

            if (ettKort_två.valor > ettKort_tre.valor && ettKort_två.valor > ettKort.valor)
            {
                MessageBox.Show("Kort 2 är störst");
            }
            if(ettKort_tre.valor > ettKort.valor && ettKort_tre.valor > ettKort_två.valor)
            {
                MessageBox.Show("Kort 3 är störst");
            }
        }

        private void Speltest_Load(object sender, EventArgs e)
        {

        }
    }


}
