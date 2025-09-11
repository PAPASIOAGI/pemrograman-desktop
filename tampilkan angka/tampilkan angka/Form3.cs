using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tampilkan_angka
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 6; i++)
            {
                CBDadu.Items.Add(i);
            }
        }

        private void btnLemparDadu_Click(object sender, EventArgs e)
        {
            int angkaAcak1, angkaAcak2;
            int doubleCounter = 0;
            string simpan;
            if (CBDadu.SelectedItem == null)
            {
                MessageBox.Show("Silakan pilih jumlah double yang diinginkan dari ComboBox");
                return;
            }
            int nilaiHenti = int.Parse(CBDadu.SelectedItem.ToString());
            Random rand = new Random();
            // Mengulangi lemparan dadu hingga mencapai jumlah double yang

            do
            {
                // Menghasilkan angka acak untuk dua dadu
                angkaAcak1 = rand.Next(1, 7);
                angkaAcak2 = rand.Next(1, 7);
                simpan = angkaAcak1.ToString() + " " + angkaAcak2.ToString();
                if (angkaAcak1 == angkaAcak2)
                {
                    simpan += " Double!";
                    doubleCounter += 1;
                }
                listBox1.Items.Add(simpan);
            } while (doubleCounter < nilaiHenti);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
