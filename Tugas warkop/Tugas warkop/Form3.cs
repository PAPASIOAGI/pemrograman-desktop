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
    public partial class Form3 : Form
    {
        public Form3(string receiptText)
        {
            InitializeComponent();
            richTextBox1.Text = receiptText;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Font = new Font("Courier New", 10);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_Load_1(object sender, EventArgs e)
        {

        }

        private void Form3_Load_2(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tblPrint_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
