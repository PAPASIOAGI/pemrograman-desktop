namespace Tugas_warkop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Set form size to fit the PictureBox exactly, including its position
            this.ClientSize = new Size(
                pictureBox1.Location.X + pictureBox1.Size.Width,
                pictureBox1.Location.Y + pictureBox1.Size.Height
            );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
