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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            int hargaBarang, uangDibayar, uangKembalian;
            int seratusRibu = 0;
            int limaPuluhRibu = 0;
            int duaPuluhRibu = 0;
            int sepuluhRibu = 0;
            int limaRibu = 0;
            int duaRibu = 0;
            int seribu = 0;
            int limaRatus = 0;
            int seratus = 0;
            hargaBarang = int.Parse(txtHargaBarang.Text);
            uangDibayar = int.Parse(txtPembeliMembayar.Text);
            uangKembalian = uangDibayar - hargaBarang;

            if (uangKembalian < 0)
            {
                MessageBox.Show("Uang yang dibayar tidak cukup");
            }
            while (uangKembalian > 99)
            {
                if (uangKembalian >= 100000)
                {
                    seratusRibu += 1;
                    uangKembalian = uangKembalian - 100000;
                }
                else if (uangKembalian >= 50000)
                {
                    limaPuluhRibu += 1;
                    uangKembalian = uangKembalian - 50000;
                }
                else if (uangKembalian >= 20000)
                {
                    duaPuluhRibu += 1;
                    uangKembalian = uangKembalian - 20000;
                }
                else if (uangKembalian >= 10000)
                {
                    sepuluhRibu += 1;
                    uangKembalian = uangKembalian - 10000;
                }
                else if (uangKembalian >= 5000)
                {
                    limaRibu += 1;
                    uangKembalian = uangKembalian - 5000;
                }
                else if (uangKembalian >= 2000)
                {
                    duaRibu += 1;
                    uangKembalian = uangKembalian - 2000;
                }
                else if (uangKembalian >= 1000)
                {
                    seribu += 1;
                    uangKembalian = uangKembalian - 1000;
                }
                else if (uangKembalian >= 500)
                {
                    limaRatus += 1;
                    uangKembalian = uangKembalian - 500;
                }
                else if (uangKembalian >= 100)
                {
                    seratus += 1;
                }
                uangKembalian = uangKembalian - 100;

                txtSeratusRibuan.Text = seratusRibu.ToString();
                txtLimaPuluhRibuan.Text = limaPuluhRibu.ToString();
                txtDuaPuluhRibuan.Text = duaPuluhRibu.ToString();
                txtCeban.Text = sepuluhRibu.ToString();
                txtGoceng.Text = limaRibu.ToString();
                txtDuaRibuan.Text = duaRibu.ToString();
                txtSeRibuan.Text = seribu.ToString();
                Gopek.Text = limaRatus.ToString();
                txtRatusan.Text = seratus.ToString();
                txtSisa.Text = uangKembalian.ToString();
            }
        }

        private void txtSisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHargaBarang.Clear();
            txtPembeliMembayar.Clear();
            txtSeratusRibuan.Clear();
            txtLimaPuluhRibuan.Clear();
            txtDuaPuluhRibuan.Clear();
            txtCeban.Clear();
            txtGoceng.Clear();
            txtDuaRibuan.Clear();
            txtSeRibuan.Clear();
            Gopek.Clear();
            txtRatusan.Clear();
            txtSisa.Clear();

        }
    }
}
