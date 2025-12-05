namespace Luas_suki_swicth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            int nomorBangun = Int32.TryParse(txtSeleksiBangun.Text, out var n) ? n : 0;
            double radius = Double.TryParse(txtRadius.Text, out var r) ? r : 0;
            double panjang = Double.TryParse(txtPanjang.Text, out var p) ? p : 0;
            double tinggi = Double.TryParse(txtTinggi.Text, out var t) ? t : 0;
            double lebar = Double.TryParse(txtLebar.Text, out var l) ? l : 0;
            double luas = 0;

            switch (nomorBangun)
            {
                case 1:
                    txtPanjang.Clear();
                    txtTinggi.Clear();
                    txtLebar.Clear();
                    luas = 3.141593 * Math.Pow(radius, 2);
                    break;
                case 2:
                    txtRadius.Clear();
                    txtLebar.Clear();
                    luas = panjang * tinggi;
                    break;
                case 3:
                    txtRadius.Clear();
                    txtTinggi.Clear();
                    luas = panjang * lebar / 2;
                    break;
                default:
                    // Hanya gunakan if untuk MessageBox
                    if (true)
                    {
                        MessageBox.Show("Pilihan bangun tidak dikenali. Masukkan 1 (lingkaran), 2 (persegi panjang), atau 3 (segitiga).");
                        return;
                    }
            }

            // Validasi hasil perhitungan, hanya gunakan if untuk MessageBox
            if (luas == 0)
            {
                MessageBox.Show("Input tidak valid atau hasil perhitungan 0. Pastikan semua nilai sudah diisi dengan benar.");
                return;
            }

            txtLuasBangun.Text = luas.ToString("F2");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

