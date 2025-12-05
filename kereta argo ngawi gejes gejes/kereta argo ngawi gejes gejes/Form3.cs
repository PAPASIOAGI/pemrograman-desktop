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
    public partial class Form3 : Form
    {
        private int jumlahDewasa;
        private int jumlahInfant;
        private int totalHarga;

        private TextBox txtEmailPemesan;
        private TextBox txtTelpPemesan;

        private string namaKereta;
        private string kelasTiket;
        private DateTime tanggalBerangkat;

        public class Penumpang
        {
            public string Nama { get; set; }
            public string NIK { get; set; }

            public Penumpang(string nama, string nik)
            {
                Nama = nama;
                NIK = nik;
            }
        }


        public Form3(int jumlahDewasa, int jumlahInfant, int totalHarga, string namaKereta, string kelasTiket, DateTime tanggal)
        {
            InitializeComponent();
            this.jumlahDewasa = jumlahDewasa;
            this.jumlahInfant = jumlahInfant;
            this.totalHarga = totalHarga;
            this.namaKereta = namaKereta;
            this.kelasTiket = kelasTiket;
            this.tanggalBerangkat = tanggal;



            GenerateFormPenumpang();
            TampilkanTotalHarga();
            TampilkanInfoTiket();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void GenerateFormPenumpang()
        {
            int jumlahPenumpang = jumlahDewasa + jumlahInfant;
            int currentTop = 60; // Mulai dari bawah label total harga
            int spacing = 10;

            switch (jumlahPenumpang)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    for (int i = 0; i < jumlahPenumpang; i++)
                    {
                        int groupHeight = (i == 0) ? 150 : 90;
                        BuatInputPenumpang(i, currentTop, groupHeight);
                        currentTop += groupHeight + spacing;
                    }
                    break;

                default:
                    MessageBox.Show("Maksimal 6 penumpang.");
                    break;
            }
        }

        // Ubah signature BuatInputPenumpang
        private void BuatInputPenumpang(int index, int top, int groupHeight)
        {
            GroupBox group = new GroupBox();
            group.Width = 350;
            group.Height = groupHeight;
            group.Left = 20;
            group.Top = top;
            group.Text = (index == 0) ? "Data Pemesan" : $"Penumpang {index}";

            // Label Nama
            Label lblNama = new Label();
            lblNama.Text = "Nama:";
            lblNama.Left = 15;
            lblNama.Top = 25;
            lblNama.Width = 50;
            group.Controls.Add(lblNama);

            // TextBox Nama
            TextBox txtNama = new TextBox();
            txtNama.Name = $"txtNama{index}";
            txtNama.Left = 70;
            txtNama.Top = 22;
            txtNama.Width = 250;
            group.Controls.Add(txtNama);

            // Label NIK
            Label lblNIK = new Label();
            lblNIK.Text = "NIK:";
            lblNIK.Left = 15;
            lblNIK.Top = 55;
            lblNIK.Width = 50;
            group.Controls.Add(lblNIK);

            // TextBox NIK
            TextBox txtNIK = new TextBox();
            txtNIK.Name = $"txtNIK{index}";
            txtNIK.Left = 70;
            txtNIK.Top = 52;
            txtNIK.Width = 250;
            group.Controls.Add(txtNIK);

            if (index == 0)
            {
                // Label Email
                Label lblEmail = new Label();
                lblEmail.Text = "Email:";
                lblEmail.Left = 15;
                lblEmail.Top = 85;
                lblEmail.Width = 50;
                group.Controls.Add(lblEmail);

                // TextBox Email
                txtEmailPemesan = new TextBox();
                txtEmailPemesan.Name = "txtEmailPemesan";
                txtEmailPemesan.Left = 70;
                txtEmailPemesan.Top = 82;
                txtEmailPemesan.Width = 250;
                group.Controls.Add(txtEmailPemesan);

                // Label Telp
                Label lblTelp = new Label();
                lblTelp.Text = "Telepon:";
                lblTelp.Left = 15;
                lblTelp.Top = 115;
                lblTelp.Width = 50;
                group.Controls.Add(lblTelp);

                // TextBox Telp
                txtTelpPemesan = new TextBox();
                txtTelpPemesan.Name = "txtTelpPemesan";
                txtTelpPemesan.Left = 70;
                txtTelpPemesan.Top = 112;
                txtTelpPemesan.Width = 250;
                group.Controls.Add(txtTelpPemesan);
            }

            this.Controls.Add(group);
        }

        private void TampilkanTotalHarga()
        {
            Label lblTotal = new Label();
            lblTotal.Text = $"Total Harga: Rp {totalHarga:N0}";
            lblTotal.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(20, 20); // Atur posisi sesuai kebutuhan
            this.Controls.Add(lblTotal);
        }

        // Tambahkan tombol simpan dan validasi email
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Tambahkan tombol Kursi di bawah form
            Button btnKursi = new Button();
            btnKursi.Text = "Kursi";
            btnKursi.Width = 100;
            btnKursi.Left = 20;
            btnKursi.Top = this.Controls.OfType<GroupBox>().Max(g => g.Bottom) + 20;
            btnKursi.Click += BtnKursi_Click;
            this.Controls.Add(btnKursi);
        }

        private void BtnKursi_Click(object sender, EventArgs e)
        {
            List<Penumpang> penumpangList = AmbilDataPenumpang();

            // Optional: Validasi sebelum lanjut
            if (penumpangList.Any(p => string.IsNullOrWhiteSpace(p.Nama) || string.IsNullOrWhiteSpace(p.NIK)))
            {
                MessageBox.Show("Semua nama dan NIK harus diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Kirim data ke Form4
            Form4 form4 = new Form4(
                jumlahDewasa,
                jumlahInfant,
                totalHarga,
                namaKereta,
                kelasTiket,
                tanggalBerangkat
            );
            form4.Show();
            this.Hide();
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (txtEmailPemesan != null)
            {
                string email = txtEmailPemesan.Text.Trim();
                if (string.IsNullOrEmpty(email) || !email.Contains("@"))
                {
                    MessageBox.Show("Email pemesan harus diisi dan mengandung tanda @.", "Validasi Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmailPemesan.Focus();
                    return;
                }
            }
            MessageBox.Show("Data berhasil disimpan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TampilkanInfoTiket()
        {
            groupTiket.Controls.Clear();

            Label lblNamaKereta = new Label();
            lblNamaKereta.Text = $"Kereta: {namaKereta}";
            lblNamaKereta.AutoSize = true;
            lblNamaKereta.Location = new Point(20, 30);
            groupTiket.Controls.Add(lblNamaKereta);

            Label lblKelas = new Label();
            lblKelas.Text = $"Kelas: {kelasTiket}";
            lblKelas.AutoSize = true;
            lblKelas.Location = new Point(20, 60);
            groupTiket.Controls.Add(lblKelas);

            Label lblTanggal = new Label();
            lblTanggal.Text = $"Tanggal: {tanggalBerangkat:dddd, dd MMMM yyyy}";
            lblTanggal.AutoSize = true;
            lblTanggal.Location = new Point(20, 90);
            groupTiket.Controls.Add(lblTanggal);

            Label lblJumlah = new Label();
            lblJumlah.Text = $"Jumlah Pemesan: {jumlahDewasa + jumlahInfant}";
            lblJumlah.AutoSize = true;
            lblJumlah.Location = new Point(20, 120);
            groupTiket.Controls.Add(lblJumlah);

            Label lblHarga = new Label();
            lblHarga.Text = $"Total Harga: Rp {totalHarga:N0}";
            lblHarga.AutoSize = true;
            lblHarga.Location = new Point(20, 150);
            groupTiket.Controls.Add(lblHarga);
        }

        public List<Penumpang> AmbilDataPenumpang()
        {
            List<Penumpang> penumpangList = new List<Penumpang>();
            int jumlahPenumpang = jumlahDewasa + jumlahInfant;

            for (int i = 0; i < jumlahPenumpang; i++)
            {
                TextBox txtNama = this.Controls.Find($"txtNama{i}", true).FirstOrDefault() as TextBox;
                TextBox txtNIK = this.Controls.Find($"txtNIK{i}", true).FirstOrDefault() as TextBox;

                if (txtNama != null && txtNIK != null)
                {
                    string nama = txtNama.Text.Trim();
                    string nik = txtNIK.Text.Trim();

                    penumpangList.Add(new Penumpang(nama, nik));
                }
            }

            return penumpangList;
        }

    }
}
