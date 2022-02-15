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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("-30 JAJ GÜCÜ KARŞILIĞINDA JAJ CLİCKER'INIZI YÜKSELTMEK İSTER MİSİNİZ?", "JAJ CLİCKER", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secenek == DialogResult.Yes)
            {
                if (jajG >= 30)
                {
                    jajG -= 30;
                    jajT += 1;
                    MessageBox.Show("SATIN ALMA İŞLEMİ TAMAMLANDI");
                }
                else
                {
                    MessageBox.Show("JAJ GÜCÜNÜZ YETERLİ DEĞİL", ":(", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
