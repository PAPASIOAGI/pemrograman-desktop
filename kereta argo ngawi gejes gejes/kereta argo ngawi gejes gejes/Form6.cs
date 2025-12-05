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
    public partial class Form6 : Form
    {
        private List<Penumpang> penumpangList;

        public Form6(List<Penumpang> penumpangList)
        {
            InitializeComponent();
            this.penumpangList = penumpangList;
            TampilkanDataPenumpang();
        }




        private void TampilkanDataPenumpang()
        {
            int top = 30;
            foreach (var p in penumpangList)
            {
                GroupBox gb = new GroupBox();
                gb.Text = "Boarding Pass";
                gb.Left = 20;
                gb.Top = top;
                gb.Width = 400;
                gb.Height = 120;

                Label lblNama = new Label();
                lblNama.Text = $"Nama: {p.Nama}";
                lblNama.Left = 20;
                lblNama.Top = 30;
                gb.Controls.Add(lblNama);

                // Tambahkan label lain sesuai kebutuhan, misal NIK, Kursi, dsb

                this.Controls.Add(gb);
                top += gb.Height + 10;
            }
        }
    }

    public class BoardingData
    {
        public string Nama { get; set; }
        public string Kereta { get; set; }
        public string NoKursi { get; set; }
        public string Kelas { get; set; }
        public string NamaKereta { get; set; }
        public DateTime Tanggal { get; set; }
    }

    public class Penumpang
    {
        public string Nama { get; set; }
        // Tambahkan properti lain sesuai kebutuhan
    }
}
