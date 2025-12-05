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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void tblHitung_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtPanjang.Text, out double panjang) &&
                        double.TryParse(txtLebar.Text, out double lebar) &&
                        double.TryParse(txtTinggi.Text, out double tinggi))
            {
                double volume = panjang * lebar * tinggi;
                txtHasil.Text = volume.ToString();
            }
            else
            {
                txtHasil.Text = "Input tidak valid";
            }
        }

        private void tblClear_Click(object sender, EventArgs e)
        {
            txtPanjang.Text = "";
            txtLebar.Text = "";
            txtTinggi.Text = "";
            txtHasil.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }
    }
}
