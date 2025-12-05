using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace kereta_argo_ngawi_gejes_gejes
{
    public partial class Form5 : Form
    {
        private string namaKereta;
        private string kelasTiket;
        private string tanggal;
        private string jumlah;
        private string harga;
        private string kursiDipilih;



        public Form5(string namaKereta, string kelasTiket, string tanggal, string jumlah, string harga, string kursiDipilih)
        {
            InitializeComponent();
            this.namaKereta = namaKereta;
            this.kelasTiket = kelasTiket;
            this.tanggal = tanggal;
            this.jumlah = jumlah;
            this.harga = harga;
            this.kursiDipilih = kursiDipilih;



            SetGroupDataTiketLabels();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            SetGroupDataTiketLabels();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void SetGroupDataTiketLabels()
        {
            lblNamaKereta.Text = namaKereta;
            lblKelas.Text = kelasTiket;
            lblTanggal.Text = tanggal;
            lblJumlah.Text = jumlah;
            lblKursi.Text = $"Kursi: {kursiDipilih}";
            lblHarga.Text = harga;
        }

        private void btnPesanTiket_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Silakan  lakukan pembayaran segera!.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Bayar terlebih dahulu", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // ⬇⬇⬇ Pastikan ini dipanggil di dalam event handler




            // Lanjutkan dengan validasi atau pengiriman ke Form6

        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void lblKursi_Click(object sender, EventArgs e)
        {

        }
    }
}
