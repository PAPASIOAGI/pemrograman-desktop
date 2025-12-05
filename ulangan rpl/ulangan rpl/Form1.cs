using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace ulangan_rpl
{
    public partial class Form1 : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Database=ulangan;Username=postgres;Password=g2nATNJcYEI5gxXJ1bLC";

        public Form1()
        {
            InitializeComponent();

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        public void LoadData(string katakunci = "")
        {
            DataTable dt = new DataTable();

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT ID, NAMA, JABATAN, WAKTU KERJA, LEMBUR, GAJI";


                    var parameters = new List<NpgsqlParameter>();

                    if (!string.IsNullOrWhiteSpace(katakunci))

                    {
                        sql += " Where NAMA ILIKE @katakunci OR CAST(GAJI AS TEXT) ILIKE @katakunci";
                        parameters.Add(new NpgsqlParameter("katakunci", "%" + katakunci + "%"));
                    }

                    {
                        sql += " ORDER BY ID";


                        using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                        {
                            foreach (var p in parameters)
                            {
                                cmd.Parameters.Add(p);

                            }

                            using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                            {
                                adapter.Fill(dt);
                            }

                            dataview.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat data: " + ex.Message);
                }
            }

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnTAMBAH_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {

        }

        private void btnHAPUS_Click(object sender, EventArgs e)
        {

        }

        private void dataview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();
        }
    }
}
