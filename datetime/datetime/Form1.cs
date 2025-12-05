namespace datetime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ambil nilai dari kedua DateTimePicker
            DateTime date1 = dtp1.Value;
            DateTime date2 = dtp2.Value;

            // Hitung selisih
            TimeSpan selisih = date2 - date1;

            // Format hasil selisih (hari, jam, menit, detik)
            string hasil = $"Selisih:\r\n" +
                           $"{Math.Abs(selisih.Days)} hari, " +
                           $"{Math.Abs(selisih.Hours)} jam, " +
                           $"{Math.Abs(selisih.Minutes)} menit, " +
                           $"{Math.Abs(selisih.Seconds)} detik";

            // Tampilkan hasil di txtTampilan
            txtTampilan.Text = hasil;
        }
    }
}
