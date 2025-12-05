using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace member_suki
{
    public partial class FormMenuUtama : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        Koneksi Konn = new Koneksi();

        public FormMenuUtama()
        {
            InitializeComponent();


            //member
            groupmember.Visible = false;
            dataGridUser.Visible = false;
            groupbtnmember.Visible = false;


            //stok
            groupstok.Visible = false;
            dataGridView1.Visible = false;
            groupbtnstok.Visible = false;
        }

        private void mEMBERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void sTOKGUDANGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            groupstok.Visible = true;
            groupbtnstok.Visible = true;

            //member visibilitas
            groupmember.Visible = false;
            dataGridUser.Visible = false;
            groupbtnmember.Visible = false;

            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM TBEL_BARANG", conn);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "TBEL_BARANG");
                dataGridView1.DataSource = ds.Tables["TBEL_BARANG"];
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void FormMenuUtama_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void tblTambah_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim() == "" || txtPW.Text.Trim() == "" || txtNama.Text.Trim() == "" || cbKategori.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum Lengkap !");
            }
            else
            {
                SqlConnection conn = Konn.GetConn();
                cmd = new SqlCommand("insert into tbluser values('" + txtID.Text + "','" + txtPW.Text + "','" + txtNama.Text + "','" + cbKategori.Text + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tambah Data Berhasil");

            }
        }

        private void mASTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //stok visibilitas
            dataGridView1.Visible = false;
            groupstok.Visible = false;

            groupmember.Visible = true;
            groupbtnmember.Visible = true;



            dataGridUser.Visible = true;
            SqlConnection conn = Konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("Select * from TBL_USER", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "TBL_USER");
            dataGridUser.DataSource = ds;
            dataGridUser.DataMember = "TBL_USER";
            dataGridUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void groupmember_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
