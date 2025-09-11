namespace tampilkan_angka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int angkaAnda, pengali, jumBerjalan = 0;
            angkaAnda = int.Parse(textBox1.Text);
            pengali = int.Parse(textBox2.Text);

            for (int i = 1; i <= pengali; i++)
            {
                jumBerjalan = angkaAnda * i;
                listBox1.Items.Add(angkaAnda + " x " + i + " = " + jumBerjalan);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}