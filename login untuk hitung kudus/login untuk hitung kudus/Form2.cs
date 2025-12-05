using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_untuk_hitung_kudus
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Bangun.Items.AddRange(new object[] { "Limas", "Kubus", "Balok", "Tabung", "Bola" });
            Bangun.SelectedIndex = 0;
            Bangun.SelectedIndexChanged += Bangun_SelectedIndexChanged;
        }

        private void Bangun_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Jika item yang dipilih adalah "kubus", tampilkan gambar
            if (Bangun.SelectedItem != null && Bangun.SelectedItem.ToString().ToLower() == "kubus")
            {
                pictKubus.Visible = true;
            }
            else
            {
                pictKubus.Visible = false;
            }
        }

        private void tblKubus_Click(object sender, EventArgs e)
        {
            Kubus kubusForm = new Kubus();
            kubusForm.Show();
            this.Hide();
        }
    }
}
