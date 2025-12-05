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

namespace mdi
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Konn.GetConn())
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("SELECT * FROM TBL_USER WHERE KodeUser=@user AND PasswordUser=@pass", conn);
                    cmd.Parameters.AddWithValue("@user", textBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", textBox2.Text.Trim());

                    rd = cmd.ExecuteReader();

                }
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
                conn.Close();
            }
            else
            {
                MessageBox.Show("User Tidak Terdaftar ");
            }
        }
    }
}
