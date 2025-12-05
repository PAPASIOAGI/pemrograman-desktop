using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kereta_argo_ngawi_gejes_gejes
{
    public partial class Form4 : Form
    {
        private int jumlahDewasa;
        private int jumlahInfant;
        private int totalHarga;
        private string namaKereta;
        private string kelasTiket;
        private DateTime tanggalBerangkat;

        private GroupBox groupKursiLayout;
        private List<CheckBox> kursiCheckBoxes = new List<CheckBox>();

        public Form4(int jumlahDewasa, int jumlahInfant, int totalHarga, string namaKereta, string kelasTiket, DateTime tanggal)
        {
            InitializeComponent();
            this.jumlahDewasa = jumlahDewasa;
            this.jumlahInfant = jumlahInfant;
            this.totalHarga = totalHarga;
            this.namaKereta = namaKereta;
            this.kelasTiket = kelasTiket;
            this.tanggalBerangkat = tanggal;

            // Ambil groupKursiLayout dari designer
            groupKursiLayout = this.Controls.Find("groupKursiLayout", true).FirstOrDefault() as GroupBox;

            // Ambil semua CheckBox kursi dari groupKursiLayout
            kursiCheckBoxes = groupKursiLayout.Controls
                .OfType<CheckBox>()
                .ToList();

            // Pasang event handler
            foreach (var cb in kursiCheckBoxes)
            {
                cb.CheckedChanged += KursiCheckBox_CheckedChanged;
            }

            SetGroupTiketLabels();
        }

        private void KursiCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int jumlahPenumpang = jumlahDewasa + jumlahInfant;
            int checkedCount = kursiCheckBoxes.Count(cb => cb.Checked);

            foreach (var cb in kursiCheckBoxes)
                cb.Enabled = cb.Checked || checkedCount < jumlahPenumpang;

            btnPembayaran.Enabled = (checkedCount == jumlahPenumpang);
            if (kursiCheckBoxes.Any(cb => cb.Checked))
            {
                MessageBox.Show("Salah satu checkbox dicentang!");
            }

        }

        private void SetGroupTiketLabels()
        {
            lblNamaKereta.Text = $"Kereta: {namaKereta}";
            lblKelas.Text = $"Kelas: {kelasTiket}";
            lblTanggal.Text = $"Tanggal: {tanggalBerangkat:dddd, dd MMMM yyyy}";
            lblJumlah.Text = $"Jumlah Pemesan: {jumlahDewasa + jumlahInfant}";
            lblHarga.Text = $"Total Harga: Rp {totalHarga:N0}";
        }

        private void BtnTiket_Click(object sender, EventArgs e)
        {
            // Ambil kursi yang dipilih
            var kursiTerpilih = kursiCheckBoxes
                .Where(cb => cb.Checked)
                .Select(cb => cb.Text)
                .ToList();

            string kursiDipilih = string.Join(", ", kursiTerpilih);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupkursi_Enter(object sender, EventArgs e)
        {

        }

        private void btnPembayaran_Click(object sender, EventArgs e)
        {
            if (!btnPembayaran.Enabled)
            {
                MessageBox.Show("Pilih kursi sesuai jumlah penumpang!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string namaKereta = lblNamaKereta.Text;
            string kelasTiket = lblKelas.Text;
            string tanggal = lblTanggal.Text;
            string jumlah = lblJumlah.Text;
            string harga = lblHarga.Text;

            var kursiTerpilih = groupKursiLayout.Controls
                .OfType<CheckBox>()
                .Where(cb => cb.Checked)
                .Select(cb => cb.Text)
                .ToList();

            string kursiDipilih = string.Join(", ", kursiTerpilih);

            Form5 form5 = new Form5(
                namaKereta,
                kelasTiket,
                tanggal,
                jumlah,
                harga,
                kursiDipilih
            );
            form5.Show();
            this.Hide();
        }

        private void btnPembayaran_Click_1(object sender, EventArgs e)
        {
            int jumlahPenumpang = jumlahDewasa + jumlahInfant;
            var kursiTerpilih = kursiCheckBoxes
                .Where(cb => cb.Checked)
                .Select(cb => cb.Text)
                .ToList();

            if (kursiTerpilih.Count != jumlahPenumpang)
            {
                MessageBox.Show($"Pilih {jumlahPenumpang} kursi terlebih dahulu!", "Validasi Kursi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string kursiDipilih = string.Join(", ", kursiTerpilih);

            Form5 form5 = new Form5(
                namaKereta,
                kelasTiket,
                tanggalBerangkat.ToString("dddd, dd MMMM yyyy"),
                (jumlahDewasa + jumlahInfant).ToString(),
                $"Rp {totalHarga:N0}",
                kursiDipilih
            );
            form5.Show();
            this.Hide();
        }
    }
}
