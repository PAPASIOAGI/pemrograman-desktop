
namespace radiohead
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tblHitung_Click(object sender, EventArgs e)
        {
            if (radio1.Checked)
                txtPendaftaran.Text = "Rp" + (0).ToString("N");
            else if (radio2.Checked)
                txtPendaftaran.Text = "Rp" + (50000).ToString("N");
            else if (radio3.Checked)
                txtPendaftaran.Text = "Rp" + (100000).ToString("N");
            else if (radio4.Checked)
                txtPendaftaran.Text = "Rp" + (150000).ToString("N");
            else
                MessageBox.Show("Anda harus membuat pilihan");
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }
    }
}
