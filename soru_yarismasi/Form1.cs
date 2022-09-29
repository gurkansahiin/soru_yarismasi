using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soru_yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soru = 0, dogru = 0, yanlis = 0;

        private void btnA_Click(object sender, EventArgs e)
        {

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnsonraki.Enabled = true;
            label3.Text = btnA.Text;
            if (label3.Text==label2.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;

            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnsonraki.Enabled = true;

            label3.Text = btnB.Text;
            if (label3.Text == label2.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;

            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnsonraki.Enabled = true;

            label3.Text = btnC.Text;
            if (label3.Text == label2.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;

            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            btnsonraki.Enabled = true;

            label3.Text = btnD.Text;
            if (label3.Text == label2.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
                


            }
                
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
               

            }
            
        }

        private void btnsonraki_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false; 
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnsonraki.Enabled = false;
            soru++;
            lblsorusayisi.Text = soru.ToString();

            if (soru==1)
            {
                richTextBox1.Text = "İstanbul kaç yılında fethedilmiştir?";
                btnA.Text = "1457";
                btnB.Text = "1462";
                btnC.Text = "1453";
                btnD.Text = "1449";
                label2.Text = "1453";

            }
            if (soru==2)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
                btnA.Text = "1927";
                btnB.Text = "1923";
                btnC.Text = "1933";
                btnD.Text = "1922";
                label2.Text = "1923";
            }

            if (soru==3)
            {
                richTextBox1.Text = "Kaldırımlar şiiri hangi şaire attir?";
                btnA.Text = "Necip Fazıl";
                btnB.Text = "Nazım Hikmet";
                btnC.Text = "Cemal Süreyya";
                btnD.Text = "Orhan Veli";
                label2.Text = "Necip Fazıl";
            }
            if (soru == 4)
            {
                richTextBox1.Text = "2000 yılında Avrupa Ligi şampiyonu olan kulüp hangisidir?";
                btnA.Text = "Real Madrid";
                btnB.Text = "Juventus";
                btnC.Text = "Milan";
                btnD.Text = "Galatasaray";
                label2.Text = "Galatasaray";
            }
            if (soru == 5)
            {
                richTextBox1.Text = "2.Dünya Savaşında hangi devlet yer almamıştır?";
                btnA.Text = "ABD";
                btnB.Text = "Fransa";
                btnC.Text = "Türkiye";
                btnD.Text = "Almanya";
                label2.Text = "Türkiye";
            }
            if (soru==6)
            {
                btnsonraki.Enabled = false;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;

                MessageBox.Show("doğru= " + dogru.ToString() + "\n" + "yanlis= " + yanlis.ToString());


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

       
    }
}
