using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_kudus_lagi
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void tblClear_Click(object sender, EventArgs e)
        {
            txtLuasalas.Text = "";
            txtTinggi.Text = "";
            txtHasil.Text = "";
        }

        private void tblHitung_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtLuasalas.Text, out double luasAlas) &&
                double.TryParse(txtTinggi.Text, out double tinggi))
            {
                double volume = (1.0 / 3.0) * luasAlas * tinggi;
                txtHasil.Text = volume.ToString();
            }
            else
            {
                txtHasil.Text = "Input tidak valid";
            }
        }
    }
}
