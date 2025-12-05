namespace login_untuk_hitung_kudus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tblLogin_Click(object sender, EventArgs e)
        {
            if ((txtID.Text == "admin") && (txtPass.Text == "1234"))
            {
                Form2 form = new Form2();
                form.Show();
                this.Hide();
                MessageBox.Show("Login Berhasil");
                // Redirect to the main application form or perform other actions
            }
            else
            {
                MessageBox.Show("Username atau Password tidak ditemukan");
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
