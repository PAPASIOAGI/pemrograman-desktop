namespace ppdb_smk
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
            cbrMinat.Items.Add("Teknologi");
            cbrMinat.Items.Add("Bisnis");
            cbrMinat.Items.Add("Seni");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTentukan_Click(object sender, EventArgs e)
        {

            string minat = cbrMinat.SelectedItem.ToString();
            int nilaiMatematika = Convert.ToInt32(txtMatematika.Text);
            int nilaiIPA = Convert.ToInt32(txtIPA.Text);
            int nilaiBahasaInggris = Convert.ToInt32(txtBahasaInggris.Text);
            string jurusan = "";
            double persentase = 0.0;
            switch (minat)
            {
                case "Teknologi":
                    persentase = (nilaiMatematika + nilaiIPA) / 2.0;

                    if (nilaiMatematika >= 80 && nilaiIPA >= 80)
                    {
                        jurusan = "RPL (Rekayasa Perangkat Lunak)";
                    }
                    else if (nilaiMatematika < 80 && nilaiIPA >= 70)
                    {
                        jurusan = "TKJ (Teknik Komputer dan Jaringan)";
                    }
                    else
                    {
                        jurusan = "Jurusan tidak cocok karena nilai kurang.";
                    }
                    break;

                case "Bisnis":
                    persentase = (nilaiMatematika + nilaiBahasaInggris) / 2.0;

                    if (nilaiMatematika >= 75 && nilaiBahasaInggris >= 75)
                    {
                        jurusan = "AKL (Akuntansi dan Keuangan Lembaga)";
                    }
                    else if (nilaiMatematika < 75 && nilaiBahasaInggris >= 70)
                    {
                        jurusan = "OTKP (Otomatisasi dan Tata Kelola Perkantoran)";
                    }
                    else
                    {
                        jurusan = "Jurusan tidak cocok karena nilai kurang.";
                    }
                    break;
                case "Seni":
                    persentase = (nilaiBahasaInggris + nilaiIPA) / 2.0;

                    if (nilaiBahasaInggris >= 80 && nilaiIPA >= 70)
                    {
                        jurusan = "DKV (Desain Komunikasi Visual)";
                    }
                    else if (nilaiBahasaInggris < 80 && nilaiIPA < 70)
                    {
                        jurusan = "BDP (Bisnis Daring dan Pemasaran)";
                    }
                    else
                    {
                        jurusan = "Jurusan tidak cocok karena nilai kurang.";
                    }
                    break;
                default:
                    MessageBox.Show("Minat tidak dikenali!");
                    break;
            }
            lblJurusanCocok.Text = "Jurusan yang Cocok: \n" + jurusan +
                       "\nPersentase Kecocokan: " + persentase.ToString("0.00") + " %";
        }

        private void btnCLear_Click(object sender, EventArgs e)
        {
            cbrMinat.Items.Clear();
            txtMatematika.Clear();
            txtIPA.Clear();
            txtBahasaInggris.Clear();
            lblJurusanCocok.Text = "Jurusan yang Cocok";
        }
    }
}

