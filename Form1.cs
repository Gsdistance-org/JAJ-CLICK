using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Eeeeeeee.rntm;

namespace Eeeeeeee
{
    public partial class Form1 : Form
    {
        Random rng = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                jajG += 5;
                MessageBox.Show("+5 JAJ GÜCÜ KAZANDINIZ", "100 TIK ÖDÜLÜ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (rng.Next(1, 10) == 7)
            {
                jajG += 1;
            }
            jajP += jajG;
            label1.Text = "JAJ POİNT:" + jajP.ToString();
            label2.Text = "JAJ POWER:" + jajG.ToString();
            progressBar1.Value += 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ekrandaki JAJ'a tıklayarak puan topla.\nJAJ PUANI'n Skorunu Gösterir.\nJAJ GÜCÜ'n Her Tıklamada Artış Miktarını Gösterir.", "Nasıl Oynanır?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2();
            f2.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            jajP += 25 * jajT;
            label1.Text = "JAJ POİNT:" + jajP.ToString();
            label2.Text = "JAJ POWER:" + jajG.ToString();
        }
    }
}
