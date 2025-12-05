using System;
using System.Windows.Forms;

namespace hitunglagi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Add items to the ComboBox
            Operasi.Items.AddRange(new object[] { "+", "-", "/", "x" });
            Operasi.SelectedIndex = 0;

            // Set button text
            tblHitung.Text = "Hitung";

            // Attach event handler
            tblHitung.Click += tblHitung_Click;
        }

        private void tblHitung_Click(object sender, EventArgs e)
        {
            double angka1, angka2, hasil = 0;
            bool valid1 = double.TryParse(txtAngka1.Text, out angka1);
            bool valid2 = double.TryParse(txtAngka2.Text, out angka2);

            if (!valid1 || !valid2)
            {
                MessageBox.Show("Masukkan angka yang valid.");
                return;
            }

            string operasi = Operasi.SelectedItem?.ToString();

            switch (operasi)
            {
                case "+":
                    hasil = angka1 + angka2;
                    break;
                case "-":
                    hasil = angka1 - angka2;
                    break;
                case "/":
                    if (angka2 == 0)
                    {
                        MessageBox.Show("Pembagi tidak boleh nol.");
                        return;
                    }
                    hasil = angka1 / angka2;
                    break;
                case "x":
                    hasil = angka1 * angka2;
                    break;
                default:
                    MessageBox.Show("Pilih operasi yang valid.");
                    return;
            }

            txtHasil.Text = hasil.ToString();
        }

        private void tblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tblClear_Click(object sender, EventArgs e)
        {
            txtAngka1.Clear();
            txtAngka2.Clear();
            txtHasil.Clear();
        }
    }
}
