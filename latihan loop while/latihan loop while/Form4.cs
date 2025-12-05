using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace latihan_loop_while
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // Kosongkan listbox

            int jumlah;
            if (!int.TryParse(txtJumlah.Text, out jumlah) || jumlah <= 0)
            {
                MessageBox.Show("Masukkan angka bulat positif!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int a, b;
            if (!int.TryParse(txtSatu.Text, out a) || !int.TryParse(txtDua.Text, out b))
            {
                MessageBox.Show("Masukkan nilai awal (A dan B) sebagai bilangan bulat!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int i = 0;
            while (i < jumlah)
            {
                listBox1.Items.Add(a); // Tambahkan angka ke listbox

                int c = a + b; // Hitung angka berikutnya
                a = b;
                b = c;

                i++;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDua.Clear();
            txtJumlah.Clear();
            txtSatu.Clear();
            listBox1.Items.Clear();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}

