using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radiohead
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void tblHitung_Click(object sender, EventArgs e)
        {
            int jum = 0;
            if (checkBox1.Checked)
                jum += 350000;
            if (checkBox2.Checked)
                jum += 450000;
            if (checkBox3.Checked)
                jum += 550000;
            if (checkBox4.Checked)
                jum += 250000;
            txtHarga.Text = "Rp" + jum.ToString("N");
        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            Form1 form1= new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
