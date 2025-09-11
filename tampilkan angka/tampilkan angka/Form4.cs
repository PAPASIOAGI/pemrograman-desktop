using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tampilkan_angka
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public int periodeBunga = 1;

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            periodeBunga = 1;
        }

        private void txtBunga_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void rdbPerHari_CheckedChanged(object sender, EventArgs e)
        {
            periodeBunga = 365;
        }

        private void rdbPerMinggu_CheckedChanged(object sender, EventArgs e)
        {
            periodeBunga = 52;
        }

        private void rdbPerBulan_CheckedChanged(object sender, EventArgs e)
        {
            periodeBunga = 12;
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            double investasi = double.Parse(txtInvestasi.Text);
            double sukuBunga = double.Parse(txtBunga.Text);
            int jumlahTahun = int.Parse(txtJumlahTahun.Text);
            int periodePembayaran = jumlahTahun * periodeBunga;
            double sukuBungaPerPeriode = (sukuBunga / 100) / periodeBunga;
            double nilaiSekarang;
            for (int i = 1; i <= periodePembayaran; i++)
            {
                nilaiSekarang = investasi * sukuBungaPerPeriode;
                investasi = investasi + nilaiSekarang;
                listBox1.Items.Add(i + ": " + investasi.ToString("N0"));
            }
            txtHasil.Text = "Anda mendapatkan Rp. " + investasi.ToString("N0");
        }
    }
}
