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
    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();
        }

        private void txtDesimal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBiner_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOktal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHeksa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConversi_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear(); // Bersihkan list sebelumnya

            int angka;
            if (!int.TryParse(txtDesimal.Text, out angka) || angka < 0)
            {
                MessageBox.Show("Masukkan bilangan desimal yang valid (>= 0).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ========================
            // Proses Konversi Biner
            // ========================
            int tempBiner = angka;
            string hasilBiner = "";
            int langkahBiner = 0;

            listBox1.Items.Add("=== Konversi ke Biner ===");
            if (tempBiner == 0)
            {
                listBox1.Items.Add("0");
                txtBiner.Text = "0";
            }
            else
            {
                while (tempBiner > 0)
                {
                    int sisa = tempBiner % 2;
                    hasilBiner = sisa + hasilBiner;
                    listBox1.Items.Add($"Langkah {++langkahBiner}: {tempBiner} ÷ 2, Sisa = {sisa}, Hasil = {hasilBiner}");
                    tempBiner /= 2;
                }
                txtBiner.Text = hasilBiner;
            }

            // ========================
            // Proses Konversi Oktal
            // ========================
            int tempOktal = angka;
            string hasilOktal = "";
            int langkahOktal = 0;

            listBox1.Items.Add("=== Konversi ke Oktal ===");
            if (tempOktal == 0)
            {
                listBox1.Items.Add("0");
                txtOktal.Text = "0";
            }
            else
            {
                while (tempOktal > 0)
                {
                    int sisa = tempOktal % 8;
                    hasilOktal = sisa + hasilOktal;
                    listBox1.Items.Add($"Langkah {++langkahOktal}: {tempOktal} ÷ 8, Sisa = {sisa}, Hasil = {hasilOktal}");
                    tempOktal /= 8;
                }
                txtOktal.Text = hasilOktal;
            }

            // ========================
            // Proses Konversi Heksadesimal
            // ========================
            int tempHeksa = angka;
            string hasilHeksa = "";
            int langkahHeksa = 0;
            string digitHeksa = "0123456789ABCDEF";

            listBox1.Items.Add("=== Konversi ke Heksadesimal ===");
            if (tempHeksa == 0)
            {
                listBox1.Items.Add("0");
                txtHeksa.Text = "0";
            }
            else
            {
                while (tempHeksa > 0)
                {
                    int sisa = tempHeksa % 16;
                    hasilHeksa = digitHeksa[sisa] + hasilHeksa;
                    listBox1.Items.Add($"Langkah {++langkahHeksa}: {tempHeksa} ÷ 16, Sisa = {digitHeksa[sisa]}, Hasil = {hasilHeksa}");
                    tempHeksa /= 16;
                }
                txtHeksa.Text = hasilHeksa;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDesimal.Clear();
            txtBiner.Clear();
            txtOktal.Clear();
            txtHeksa.Clear();
            listBox1.Items.Clear();
            txtDesimal.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}

