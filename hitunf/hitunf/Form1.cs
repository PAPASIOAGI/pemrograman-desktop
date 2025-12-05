using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace hitunf
{
    public partial class Form1 : Form
    {
        Double dblangka1 = 0.0;
        Double dblangka2 = 0.0;
        Double dblhasil = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dblangka1 = Double.Parse(txtangka1.Text);
            dblangka2 = Double.Parse(txtangka2.Text);
            dblhasil = (dblangka1 + dblangka2);
            txthasil.Text = dblhasil.ToString("n0");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tblKurang_Click(object sender, EventArgs e)
        {
            dblangka1 = Double.Parse(txtangka1.Text);
            dblangka2 = Double.Parse(txtangka2.Text);
            dblhasil = (dblangka1 - dblangka2);
            txthasil.Text = dblhasil.ToString("n0");
        }

        private void tblBagi_Click(object sender, EventArgs e)
        {
            dblangka1 = Double.Parse(txtangka1.Text);
            dblangka2 = Double.Parse(txtangka2.Text);
            dblhasil = (dblangka1 / dblangka2);
            txthasil.Text = dblhasil.ToString("n0");
        }

        private void tblClear_Click(object sender, EventArgs e)
        {
            txtangka1.Text = "0";
            txtangka2.Text = "0";
            txthasil.Text = "0";
        }
    }
}
