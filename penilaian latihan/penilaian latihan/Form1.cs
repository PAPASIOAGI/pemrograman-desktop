using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace penilaian_latihan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tblHitung_Click(object sender, EventArgs e)
        {
            // Ambil nilai dari masing-masing TextBox
            double nilaiHarian = 0, nilaiTengah = 0, nilaiAkhir = 0;

            // Validasi dan parsing input
            bool validHarian = double.TryParse(txtHarian.Text, out nilaiHarian);
            bool validTengah = double.TryParse(txtTengah.Text, out nilaiTengah);
            bool validAkhir = double.TryParse(txtAkhir.Text, out nilaiAkhir);

            // Jika semua input tidak valid, tampilkan MessageBox dan hentikan proses
            if (!validHarian && !validTengah && !validAkhir)
            {
                MessageBox.Show("Masukkan nilai yang valid pada minimal satu kolom!", "Input Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHasil.Text = string.Empty;
                txtKompeten.Text = string.Empty;
                txtKategori.Text = string.Empty;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                return;
            }

            // Hitung hasil akhir dengan presentasi yang ditentukan
            double hasil = (nilaiHarian * 0.5) + (nilaiTengah * 0.3) + (nilaiAkhir * 0.2);

            // Tampilkan hasil ke txtHasil
            txtHasil.Text = hasil.ToString("F0");
            txtKompeten.Text = hasil >= 78 ? "Kompeten" : "Tidak Kompeten";



            // Kategori nilai
            if (hasil > 90)
            {
                txtKategori.Text = "A";
            }
            else if (hasil > 80)
            {
                txtKategori.Text = "B";
            }
            else if (hasil > 70)
            {
                txtKategori.Text = "C";
            }
            else
            {
                txtKategori.Text = "D";
            }

            // Tampilkan PictureBox sesuai hasil
            pictureBox1.Visible = hasil >= 80;
            pictureBox2.Visible = hasil <= 80;
        }

        private void txtHarian_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTengah_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAkhir_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHasil_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tblClear_Click(object sender, EventArgs e)
        {
            txtHarian.Text = string.Empty;
            txtTengah.Text = string.Empty;
            txtAkhir.Text = string.Empty;
            txtHasil.Text = string.Empty;
            pictureBox1.Visible = false;
        }

        private void txtKompeten_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtKategori_TextChanged(object sender, EventArgs e)
        {

        }

        private void tblSimpan_Click(object sender, EventArgs e)
        {
            form2 form2 = new form2();
            Form.show();
            this.Hide();
        }
    }
}
