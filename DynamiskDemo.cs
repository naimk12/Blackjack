using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace KortspelDemo
{
    public partial class DynamiskDemo : Form
    {
        Spelare spelare1 = new Spelare("Naim");
        Spelare spelare2 = new Spelare("Guest");
        Spelare spelare3 = new Spelare("Guest 2");
        public bool badaTjocka = false;
       


        Kortlek leken = new Kortlek(true);
        int counter = 0;
        int counter2 = 0;
       

        public DynamiskDemo()
        {
            InitializeComponent();
        }
                         

        private void DynamiskDemo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;

            counter++;
            if(counter == 1)
            {
                Kort ettKort = leken.geKort();
                this.Text = ettKort.valor.ToString();
                pictureBox1.Image = ettKort.bild;
                spelare1.poang += ettKort.valor;
                textBox1.Text = spelare1.poang.ToString();
            }
           if(counter == 2)
            {
                Kort ettKort_två = leken.geKort();
                pictureBox2.Image = ettKort_två.bild;
                spelare1.poang += ettKort_två.valor;
                textBox1.Text = spelare1.poang.ToString();
                if (spelare1.poang > 21)
                {
                    MessageBox.Show("You lose!");
                    button1.Enabled = false;
                    button4.Enabled = false;
                }
                if (spelare1.poang > 21)
                {
                    button2.Enabled = true;
                    button5.Enabled = true;

                }


            }
           if(counter == 3)
            {
                Kort ettKort_tre = leken.geKort();
                pictureBox3.Image = ettKort_tre.bild;
                spelare1.poang += ettKort_tre.valor;
                textBox1.Text = spelare1.poang.ToString();
                if (spelare1.poang > 21)
                {
                    MessageBox.Show("You lose!");
                    button1.Enabled = false;
                    button4.Enabled = false;
                }
                if (spelare1.poang > 21)
                {
                    button2.Enabled = true;
                    button5.Enabled = true;

                }
            }

            if (counter == 4)
            {
                Kort ettKort_fyra = leken.geKort();
                pictureBox4.Image = ettKort_fyra.bild;
                spelare1.poang += ettKort_fyra.valor;
                textBox1.Text = spelare1.poang.ToString();
                if (spelare1.poang > 21)
                {
                    MessageBox.Show("You lose!");
                    button1.Enabled = false;
                    button4.Enabled = false;
                }
                if (spelare1.poang > 21)
                {
                    button2.Enabled = true;
                    button5.Enabled = true;

                }
            }

            if (counter == 5)
            {
                Kort ettKort_fem = leken.geKort();
                pictureBox5.Image = ettKort_fem.bild;
                MessageBox.Show("Show your cards gentlemen");
                spelare1.poang += ettKort_fem.valor;
                textBox1.Text = spelare1.poang.ToString();
                if (spelare1.poang > 21)
                {
                    MessageBox.Show("You lose!");
                    button1.Enabled = false;
                    button4.Enabled = false;
                }
                if (spelare1.poang > 21)
                {
                    button2.Enabled = true;
                    button5.Enabled = true;

                }
            }
                  
                                            

        }
                     
        
        private void button2_Click(object sender, EventArgs e)
        {

            button1.Enabled = false;
            button4.Enabled = false;
            button6.Enabled = false;

            counter2++;
            if (counter2 == 1)
            {
                Kort ettKort_sex = leken.geKort();
                this.Text = ettKort_sex.valor.ToString();
                pictureBox6.Image = ettKort_sex.bild;
                spelare2.poang += ettKort_sex.valor;
                textBox2.Text = spelare2.poang.ToString();
            }
            if (counter2 == 2)
            {
                Kort ettKort_sju = leken.geKort();
                pictureBox7.Image = ettKort_sju.bild;
                spelare2.poang += ettKort_sju.valor;
                textBox2.Text = spelare2.poang.ToString();
                if (spelare2.poang > 21)
                {
                    MessageBox.Show("You lose!");
                    button2.Enabled = false;
                    button5.Enabled = false; 
                }
                if (spelare2.poang > 21)
                {
                    button6.Enabled = true;
                  
                }

            }
            if (counter2 == 3)
            {
                Kort ettKort_åtta = leken.geKort();
                pictureBox8.Image = ettKort_åtta.bild;
                spelare2.poang += ettKort_åtta.valor;
                textBox2.Text = spelare2.poang.ToString();
                if (spelare2.poang > 21)
                {
                    MessageBox.Show("You lose!");
                    button2.Enabled = false;
                    button5.Enabled = false;
                }
                if (spelare2.poang > 21)
                {
                    button6.Enabled = true;

                }
            }

            if (counter2 == 4)
            {
                Kort ettKort_nio = leken.geKort();
                pictureBox9.Image = ettKort_nio.bild;
                spelare2.poang += ettKort_nio.valor;
                textBox2.Text = spelare2.poang.ToString();
                if (spelare2.poang > 21)
                {
                    MessageBox.Show("You lose!");
                    button2.Enabled = false;
                    button5.Enabled = false;
                }

                if (spelare2.poang > 21)
                {
                    button6.Enabled = true;

                }
            }

            if (counter2 == 5)
            {
                Kort ettKort_tio = leken.geKort();
                pictureBox10.Image = ettKort_tio.bild;
                MessageBox.Show("Show your cards gentlemen");
                spelare2.poang += ettKort_tio.valor;
                textBox2.Text = spelare2.poang.ToString();
                if (spelare2.poang > 21)
                {
                    MessageBox.Show("You lose!");
                    button2.Enabled = false;
                    button5.Enabled = false;
                }
                if(spelare2.poang > 21)
                {
                    button6.Enabled = true;

                }
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = true;
            button5.Enabled = true;
            MessageBox.Show("Player 2 begin");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = false;
            button4.Enabled = false;
            button6.Enabled = true;

            MessageBox.Show("Player 1 begin");
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (spelare1.poang < 22 && spelare2.poang < 22)
            {

                if (spelare1.poang > spelare2.poang)
                {
                    MessageBox.Show("Spelare 1 wins!");
                }
                if (spelare2.poang > spelare1.poang)
                {
                    MessageBox.Show("Spelare 2 wins!");
                }
                
            }

            if (spelare1.poang > 21 && spelare2.poang > 21)
            {

                MessageBox.Show("Båda tjocka");

            }

            if(spelare1.poang < 22 && spelare2.poang > 21)
            {
                MessageBox.Show("spelare 1 är vinner!");
            }

            if (spelare2.poang < 22 && spelare1.poang > 21)
            {
                MessageBox.Show("spelare 2 vinner!");
            }



        }
    }
    
  
}
