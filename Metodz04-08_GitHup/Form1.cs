using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodz04_08_GitHup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int exp = int.Parse(textBox2.Text);

            MessageBox.Show("Mocnina je " + CelaCisla.Mocnina(x, exp));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox3.Text);
            MessageBox.Show("Faktorial je " + CelaCisla.Faktorial(x));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox4.Text);
            MessageBox.Show("Soucet lich cifer je " + CelaCisla.CifSoucet(x));

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox5.Text);
            if (CelaCisla.JePrvocislo(x)) MessageBox.Show("Cislo " + x + "je prvocislo");
            else MessageBox.Show("Neni to prvocislo");

           


        }

        private void button5_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox6.Text);
            MessageBox.Show("Pocet sud delitelu je " + CelaCisla.PocetSudDelitelu(x));




        }
    }
}
