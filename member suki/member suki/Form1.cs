using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace member_suki
{
    public partial class Form1 : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;
        Koneksi Konn = new Koneksi();

        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("Select * from TBL_USER where KodeUser='" +
            textBox1.Text + "' and PasswordUser='" + textBox2.Text + "'", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                FormMenuUtama frmUtama = new FormMenuUtama();
                frmUtama.Show();
                this.Hide();
                conn.Close();
            }
            else
            {
                MessageBox.Show("User Tidak Terdaftar ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
