using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_warkop
{
    public partial class Form2 : Form
    {
        // Tambahkan field untuk menyimpan pesanan terakhir
        int hargaPastry = 0;
        int hargaKopi = 0;
        int hargaTopping = 0;
        int hargaSuhu = 0;
        string namaPastry = "";
        string namaKopi = "";
        List<string> toppingList = new List<string>();
        string namaSuhu = "";
        const int biayaKemasan = 4000;

        public Form2()
        {
            InitializeComponent();
            txtTotal.ReadOnly = true;
            txtTax.ReadOnly = true;
            txtTotal2.ReadOnly = true;
        }

        private void tblTotal_Click(object sender, EventArgs e)
        {
            // Reset field pesanan
            hargaPastry = 0;
            hargaKopi = 0;
            hargaTopping = 0;
            hargaSuhu = 0;
            namaPastry = "";
            namaKopi = "";
            toppingList = new List<string>();
            namaSuhu = "";

            // Pilihan Pastry
            if (radioButton1.Checked) { hargaPastry = 35000; namaPastry = "Bagel"; }
            if (radioButton2.Checked) { hargaPastry = 18000; namaPastry = "Brownies"; }
            else if (radioButton3.Checked) { hargaPastry = 42000; namaPastry = "Croissant"; }
            else if (radioButton13.Checked) { hargaPastry = 37500; namaPastry = "Pastry 13"; }
            else if (radioButton14.Checked) { hargaPastry = 32000; namaPastry = "Pastry 14"; }
            else if (radioButton4.Checked) { hargaPastry = 33000; namaPastry = "Pastry 4"; }

            // Pilihan Kopi
            if (radioEspresso.Checked) { hargaKopi = 20000; namaKopi = "Espresso"; }
            else if (radioCappuccino.Checked) { hargaKopi = 30000; namaKopi = "Cappuccino"; }
            else if (radioAmericano.Checked) { hargaKopi = 26000; namaKopi = "Americano"; }
            else if (radioLongblack.Checked) { hargaKopi = 25000; namaKopi = "Long Black"; }
            else if (radioMacchiato.Checked) { hargaKopi = 28000; namaKopi = "Macchiato"; }
            else if (radioLatte.Checked) { hargaKopi = 30000; namaKopi = "Latte"; }
            else if (radioMocha.Checked) { hargaKopi = 35000; namaKopi = "Mocha"; }
            else if (radioGranita.Checked) { hargaKopi = 3000; namaKopi = "Granita"; }

            // Topping
            if (checkBox1.Checked) { hargaTopping += 3000; toppingList.Add("Coklat (Rp3.000)"); }
            if (checkBox2.Checked) { hargaTopping += 4000; toppingList.Add("Macha (Rp4.000)"); }
            if (checkBox3.Checked) { hargaTopping += 4000; toppingList.Add("Topping 3 (Rp4.000)"); }
            if (checkBox4.Checked) { hargaTopping += 5000; toppingList.Add("Topping 4 (Rp5.000)"); }
            if (checkBox5.Checked) { hargaTopping += 5000; toppingList.Add("Topping 5 (Rp5.000)"); }

            // Panas/Dingin
            if (radioPanas.Checked) { hargaSuhu = 2000; namaSuhu = "Panas (Rp2.000)"; }
            else if (radioDingin.Checked) { hargaSuhu = 5000; namaSuhu = "Dingin (Rp5.000)"; }

            // Hitung total
            int total = hargaPastry + hargaKopi + hargaTopping + hargaSuhu;

            // Validasi: harus ada minimal satu menu utama (pastry atau kopi)
            if (hargaPastry == 0 && hargaKopi == 0)
            {
                MessageBox.Show("Anda harus membuat pilihan pada menu Pastry atau Kopi");
                return;
            }

            txtTotal.Text = "Rp" + total.ToString("N0");
            txtTax.Text = "Rp" + (total * 0.1).ToString("N0");
            txtTotal2.Text = "Rp" + (total + (total * 0.1)).ToString("N0");
        }

        private void tblDisini_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("======= Coffee Shop Receipt =======");
            if (!string.IsNullOrEmpty(namaPastry))
                sb.AppendLine($"Pastry : {namaPastry} (Rp{hargaPastry:N0})");
            if (!string.IsNullOrEmpty(namaKopi))
                sb.AppendLine($"Kopi   : {namaKopi} (Rp{hargaKopi:N0})");
            if (toppingList.Count > 0)
            {
                sb.AppendLine("Topping:");
                foreach (var topping in toppingList)
                    sb.AppendLine($"  - {topping}");
            }
            if (!string.IsNullOrEmpty(namaSuhu))
                sb.AppendLine($"Suhu   : {namaSuhu}");
            sb.AppendLine("---------------------------------------------");
            sb.AppendLine($"Sub Total  : {txtTotal.Text}");
            sb.AppendLine($"Tax (10%): {txtTax.Text}");
            sb.AppendLine($"Total  : {txtTotal2.Text}");
            sb.AppendLine("---------------------------------------------");
            sb.AppendLine("Terima kasih atas pesanan Anda!");

            // Tampilkan di Form3
            Form3 form3 = new Form3(sb.ToString());
            form3.Show();
            this.Hide();
        }

        private void tblTakeaway_Click(object sender, EventArgs e)
        {
            const int biayaKemasan = 4000;
            int subTotal = hargaPastry + hargaKopi + hargaTopping + hargaSuhu;
            int taxTakeaway = (int)((subTotal + biayaKemasan) * 0.1);
            int totalTakeaway = subTotal + biayaKemasan + taxTakeaway;

            // Update txtTotal, txtTax, dan txtTotal2
            txtTotal.Text = "Rp" + (subTotal + biayaKemasan).ToString("N0");
            txtTax.Text = "Rp" + taxTakeaway.ToString("N0");
            txtTotal2.Text = "Rp" + totalTakeaway.ToString("N0");

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("======= Coffee Shop Receipt =======");
            if (!string.IsNullOrEmpty(namaPastry))
                sb.AppendLine($"Pastry : {namaPastry} (Rp{hargaPastry:N0})");
            if (!string.IsNullOrEmpty(namaKopi))
                sb.AppendLine($"Kopi   : {namaKopi} (Rp{hargaKopi:N0})");
            if (toppingList.Count > 0)
            {
                sb.AppendLine("Topping:");
                foreach (var topping in toppingList)
                    sb.AppendLine($"  - {topping}");
            }
            if (!string.IsNullOrEmpty(namaSuhu))
                sb.AppendLine($"Suhu   : {namaSuhu}");
            sb.AppendLine($"Kemasan: Rp{biayaKemasan:N0}");
            sb.AppendLine("---------------------------------------------");
            sb.AppendLine($"Sub Total  : Rp{subTotal:N0}");
            sb.AppendLine($"Kemasan    : Rp{biayaKemasan:N0}");
            sb.AppendLine($"Tax (10%): {txtTax.Text}");
            sb.AppendLine($"Total  : {txtTotal2.Text}");
            sb.AppendLine("---------------------------------------------");
            sb.AppendLine("Terima kasih atas pesanan Anda!");

            // Tampilkan di Form3
            Form3 form3 = new Form3(sb.ToString());
            form3.Show();
            this.Hide();
        }

        private void tblCLose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tblClear_Click(object sender, EventArgs e)
        {
            // Reset semua pilihan
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton13.Checked = false;
            radioButton14.Checked = false;
            radioEspresso.Checked = false;
            radioCappuccino.Checked = false;
            radioAmericano.Checked = false;
            radioLongblack.Checked = false;
            radioMacchiato.Checked = false;
            radioLatte.Checked = false;
            radioMocha.Checked = false;
            radioGranita.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            radioPanas.Checked = false;
            radioDingin.Checked = false;
            txtTotal.Text = "";
            txtTax.Text = "";
        }

        private void grouppestry_Enter(object sender, EventArgs e)
        {

        }
    }
}
