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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtJari.Text, out double Jari))
            {
                double volume = (4.0 / 3.0) * Math.PI * Math.Pow(Jari, 3);
                txtHasil.Text = volume.ToString("n1");
            }
            else
            {
                txtHasil.Text = "Input tidak valid";
            }
        }

        private void tblBack_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
            MessageBox.Show("Menghitung volume Lingkaran");
        }

        private void tblClear_Click(object sender, EventArgs e)
        {
            txtJari.Text = "";
            txtHasil.Text = "";
        }
    }
}
