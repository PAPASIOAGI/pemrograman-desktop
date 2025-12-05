using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace kereta_argo_ngawi_gejes_gejes
{
    public partial class Form2 : Form
    {
        private int jumlahDewasa = 0;
        private int jumlahInfant = 0;

        // Harga Papandayan
        private const int HargaPapandaEkonomi = 130000;
        private const int HargaPapandaEksekutif1 = 250000;
        private const int HargaPapandaEksekutif2 = 290000;

        // Harga Argo Bromo Anggrek
        private const int HargaArgoEkonomi = 180000;
        private const int HargaArgoEksekutif1 = 400000;
        private const int HargaArgoEksekutif2 = 450000;

        // Harga Bangunkarta
        private const int HargaBangunEkonomi = 160000;
        private const int HargaBangunEksekutif1 = 320000;
        private const int HargaBangunEksekutif2 = 370000;

        // Harga Bogowonto
        private const int HargaBogoEkonomi = 140000;
        private const int HargaBogoEksekutif1 = 270000;
        private const int HargaBogoEksekutif2 = 310000;

        // Harga infant tetap
        private const int HargaInfant = 5000;

        public Form2()
        {
            InitializeComponent();
            txtDewasa.Text = jumlahDewasa.ToString();
            txtInfrant.Text = jumlahInfant.ToString();

            Thread.CurrentThread.CurrentCulture = new CultureInfo("id-ID");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("id-ID");

            // Sembunyikan semua group kereta di awal
            SembunyikanSemuaGroupKereta();
        }

        private void SembunyikanSemuaGroupKereta()
        {
            groupPAPANDA.Visible = false;
            groupArgobromo.Visible = false;
            groupBangunkarta.Visible = false;
            groupBogowonto.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // stasiun asal
            StasiunAsal.Items.Add("Stasiun Jakarta (GAMBIR)");
            StasiunAsal.Items.Add("Stasiun Jakarta (PASAR SENEN)");
            StasiunAsal.Items.Add("Stasiun Madiun");

            // stasiun tujuan
            StasiunTujuan.Items.Add("Stasiun Garut");
            StasiunTujuan.Items.Add("Stasiun Cirebon");
            StasiunTujuan.Items.Add("Stasiun Surabaya");
            StasiunTujuan.Items.Add("Stasiun Semarang");
            StasiunTujuan.Items.Add("Stasiun Ngawi");
            StasiunTujuan.Items.Add("Stasiun Lempuyangan");
            StasiunTujuan.Items.Add("Stasiun Yogyakarta");

            // date time
            dateTimePicker1.MinDate = DateTime.Today;
        }

        private void TampilkanGroupKereta()
        {
            SembunyikanSemuaGroupKereta();

            string asal = StasiunAsal.SelectedItem?.ToString();
            string tujuan = StasiunTujuan.SelectedItem?.ToString();

            if (asal == null || tujuan == null)
                return;

            switch (asal)
            {
                case "Stasiun Jakarta (GAMBIR)":
                    switch (tujuan)
                    {
                        case "Stasiun Cirebon":
                        case "Stasiun Surabaya":
                        case "Stasiun Semarang":
                        case "Stasiun Garut":
                            groupArgobromo.Visible = true;
                            break;
                    }
                    break;

                case "Stasiun Jakarta (PASAR SENEN)":
                    switch (tujuan)
                    {
                        case "Stasiun Ngawi":
                        case "Stasiun Lempuyangan":
                            groupBangunkarta.Visible = true;
                            break;
                    }
                    break;

                case "Stasiun Madiun":
                    switch (tujuan)
                    {
                        case "Stasiun Yogyakarta":
                        case "Stasiun Ngawi":
                            groupBogowonto.Visible = true;
                            break;
                    }
                    break;
            }

        }

        private void StasiunAsal_SelectedIndexChanged(object sender, EventArgs e)
        {
            TampilkanGroupKereta();
        }

        private void StasiunTujuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            TampilkanGroupKereta();
        }

        private bool IsKeretaTersedia(string asal, string tujuan)
        {
            switch (asal)
            {
                case "Stasiun Jakarta (GAMBIR)":
                    switch (tujuan)
                    {
                        case "Stasiun Cirebon":
                        case "Stasiun Surabaya":
                        case "Stasiun Semarang":
                        case "Stasiun Garut":
                            return true;
                    }
                    break;
                case "Stasiun Jakarta (PASAR SENEN)":
                    switch (tujuan)
                    {
                        case "Stasiun Ngawi":
                        case "Stasiun Lempuyangan":
                            return true;
                    }
                    break;
                case "Stasiun Madiun":
                    switch (tujuan)
                    {
                        case "Stasiun Yogyakarta":
                        case "Stasiun Ngawi":
                            return true;
                    }
                    break;
            }
            return false;
        }

        private void btnCarikereta_Click(object sender, EventArgs e)
        {
            string asal = StasiunAsal.SelectedItem?.ToString();
            string tujuan = StasiunTujuan.SelectedItem?.ToString();

            SembunyikanSemuaGroupKereta();

            if (asal == null || tujuan == null)
                return;

            if (IsKeretaTersedia(asal, tujuan))
            {
                // Tampilkan groupbox sesuai logika sebelumnya
                switch (asal)
                {
                    case "Stasiun Jakarta (GAMBIR)":
                        switch (tujuan)
                        {
                            case "Stasiun Cirebon":
                            case "Stasiun Surabaya":
                            case "Stasiun Semarang":
                                groupArgobromo.Visible = true;
                                break;
                            case "Stasiun Garut":
                                groupPAPANDA.Visible = true;
                                break;
                        }
                        break;
                    case "Stasiun Jakarta (PASAR SENEN)":
                        switch (tujuan)
                        {
                            case "Stasiun Ngawi":
                            case "Stasiun Lempuyangan":
                                groupBangunkarta.Visible = true;
                                break;
                        }
                        break;
                    case "Stasiun Madiun":
                        switch (tujuan)
                        {
                            case "Stasiun Yogyakarta":
                            case "Stasiun Ngawi":
                                groupBogowonto.Visible = true;
                                break;
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Tidak ada kereta yang tersedia untuk rute ini.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tblTambah_Click(object sender, EventArgs e)
        {
            jumlahDewasa++;
            txtDewasa.Text = jumlahDewasa.ToString();

            // Jika infant lebih banyak dari dewasa, sesuaikan
            if (jumlahInfant > jumlahDewasa)
            {
                jumlahInfant = jumlahDewasa;
                txtInfrant.Text = jumlahInfant.ToString();
            }
        }

        private void tblKurang_Click(object sender, EventArgs e)
        {
            if (jumlahDewasa > 0)
            {
                jumlahDewasa--;
                txtDewasa.Text = jumlahDewasa.ToString();

                // Jika infant lebih banyak dari dewasa, sesuaikan
                if (jumlahInfant > jumlahDewasa)
                {
                    jumlahInfant = jumlahDewasa;
                    txtInfrant.Text = jumlahInfant.ToString();
                }
            }
            else
            {
                MessageBox.Show("Jumlah penumpang dewasa sudah 0!");
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (jumlahInfant < jumlahDewasa)
            {
                jumlahInfant++;
                txtInfrant.Text = jumlahInfant.ToString();
            }
            else
            {
                MessageBox.Show("Jumlah infant tidak boleh melebihi jumlah dewasa!");
            }
        }

        private void btnKurang_Click(object sender, EventArgs e)
        {
            if (jumlahInfant > 0)
            {
                jumlahInfant--;
                txtInfrant.Text = jumlahInfant.ToString();
            }
            else
            {
                MessageBox.Show("Jumlah infant sudah 0!");
            }
        }

        private void btnEkonomipapa_Click(object sender, EventArgs e)
        {
            PesanTiket(HargaPapandaEkonomi, "Papandayan", "Ekonomi");
        }

        private void btnEksekutifpapa1_Click(object sender, EventArgs e)
        {
            PesanTiket(HargaPapandaEksekutif1, "Papandayan", "Eksekutif 1");
        }

        private void btnEksekutifpapa2_Click(object sender, EventArgs e)
        {
            PesanTiket(HargaPapandaEksekutif2, "Papandayan", "Eksekutif 2");
        }

        private void btnEkonomiargo_Click(object sender, EventArgs e)
        {
            PesanTiket(HargaArgoEkonomi, "Argo Bromo Anggrek", "Ekonomi");
        }

        private void btnEksekutifargo1_Click(object sender, EventArgs e)
        {
            PesanTiket(HargaArgoEksekutif1, "Argo Bromo Anggrek", "Eksekutif 1");
        }

        private void btnEksekutifargo2_Click(object sender, EventArgs e)
        {
            PesanTiket(HargaArgoEksekutif2, "Argo Bromo Anggrek", "Eksekutif 2");
        }

        private void btnEkonomibangun_Click(object sender, EventArgs e)
        {
            PesanTiket(HargaBangunEkonomi, "Bangunkarta", "Ekonomi");
        }

        private void btnEksekutifbangun1_Click(object sender, EventArgs e)
        {
            PesanTiket(HargaBangunEksekutif1, "Bangunkarta", "Eksekutif 1");
        }

        private void btnEksekutifbangun2_Click(object sender, EventArgs e)
        {
            PesanTiket(HargaBangunEksekutif2, "Bangunkarta", "Eksekutif 2");
        }

        private void btnEkonomibogowonto2_Click(object sender, EventArgs e)
        {
            PesanTiket(HargaBogoEkonomi, "Bogowonto", "Ekonomi");
        }

        private void btnEksekutifbogowonto1_Click(object sender, EventArgs e)
        {
            PesanTiket(HargaBogoEksekutif1, "Bogowonto", "Eksekutif 1");
        }

        private void btnEksekutifbogowonto2_Click(object sender, EventArgs e)
        {
            PesanTiket(HargaBogoEksekutif2, "Bogowonto", "Eksekutif 2");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void PesanTiket(int hargaDewasa, string namaKereta, string kelas)
        {
            int jumlahDewasa = int.Parse(txtDewasa.Text);
            int jumlahInfant = int.Parse(txtInfrant.Text);
            int totalHarga = (jumlahDewasa * hargaDewasa) + (jumlahInfant * HargaInfant);

            Form3 form3 = new Form3(jumlahDewasa, jumlahInfant, totalHarga, namaKereta, kelas, dateTimePicker1.Value);
            form3.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}