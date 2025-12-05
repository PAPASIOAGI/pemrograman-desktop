using System.Windows.Forms;

namespace kereta_argo_ngawi_gejes_gejes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupCek.Visible = false;

            timer1.Start();
            timer1.Interval = 20;
        }

        private void tblPemesanan_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void tblBooking_Click(object sender, EventArgs e)
        {
            groupCek.Visible = true;
        }

        private void tblCek_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureKereta1.Left = -pictureKereta1.Width; // Mulai dari luar kiri form
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Geser ke kanan
            pictureKereta1.Left += 3; // kecepatan gerak ke kanan

            // Jika sudah di luar kanan, kembalikan ke kiri
            if (pictureKereta1.Left > this.Width)
            {
                pictureKereta1.Left = -pictureKereta1.Width;
            }
        }

        private void groupCek_Enter(object sender, EventArgs e)
        {

        }

        private void pictureKereta1_Click(object sender, EventArgs e)
        {

        }
    }
}
