using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace volume_kududs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtPanjang_TextChanged(object sender, EventArgs e)
        {

        }

        private void tblHitung_Click(object sender, EventArgs e)
        {
            
            Double panjang = 0.0;
            Double lebar = 0.0;
            Double tinggi = 0.0;
            Double volume = 0.0;
            
            panjang = Double.Parse(txtPanjang.Text);
            lebar = Double.Parse(txtLebar.Text);
            tinggi = Double.Parse(txtTinggi.Text);
           
            volume = (panjang * lebar * tinggi);
            
            txtVolume.Text = volume.ToString("n0");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPanjang.Text = "";
            txtLebar.Text = "";
            txtTinggi.Text = "";
            txtVolume.Text = "";

        }

        private void tblClose_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
