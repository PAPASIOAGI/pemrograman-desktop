namespace hitunf
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtangka1 = new TextBox();
            txthasil = new TextBox();
            txtangka2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tblJumlah = new Button();
            tblKurang = new Button();
            tblClear = new Button();
            tblBagi = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // txtangka1
            // 
            txtangka1.Location = new Point(384, 75);
            txtangka1.Name = "txtangka1";
            txtangka1.Size = new Size(100, 23);
            txtangka1.TabIndex = 0;
            txtangka1.TextChanged += textBox1_TextChanged;
            // 
            // txthasil
            // 
            txthasil.Location = new Point(384, 164);
            txthasil.Name = "txthasil";
            txthasil.Size = new Size(100, 23);
            txthasil.TabIndex = 1;
            // 
            // txtangka2
            // 
            txtangka2.Location = new Point(384, 114);
            txtangka2.Name = "txtangka2";
            txtangka2.Size = new Size(100, 23);
            txtangka2.TabIndex = 2;
            txtangka2.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(347, 117);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 3;
            label1.Text = "2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(347, 75);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 4;
            label2.Text = "1";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(347, 172);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 5;
            label3.Text = "hasil";
            // 
            // tblJumlah
            // 
            tblJumlah.Location = new Point(266, 214);
            tblJumlah.Name = "tblJumlah";
            tblJumlah.Size = new Size(75, 23);
            tblJumlah.TabIndex = 6;
            tblJumlah.Text = "+";
            tblJumlah.UseVisualStyleBackColor = true;
            tblJumlah.Click += button1_Click;
            // 
            // tblKurang
            // 
            tblKurang.Location = new Point(347, 214);
            tblKurang.Name = "tblKurang";
            tblKurang.Size = new Size(75, 23);
            tblKurang.TabIndex = 7;
            tblKurang.Text = "-";
            tblKurang.UseVisualStyleBackColor = true;
            tblKurang.Click += tblKurang_Click;
            // 
            // tblClear
            // 
            tblClear.Location = new Point(522, 214);
            tblClear.Name = "tblClear";
            tblClear.Size = new Size(75, 23);
            tblClear.TabIndex = 8;
            tblClear.Text = "C";
            tblClear.UseVisualStyleBackColor = true;
            tblClear.Click += tblClear_Click;
            // 
            // tblBagi
            // 
            tblBagi.Location = new Point(428, 214);
            tblBagi.Name = "tblBagi";
            tblBagi.Size = new Size(75, 23);
            tblBagi.TabIndex = 9;
            tblBagi.Text = "/";
            tblBagi.UseVisualStyleBackColor = true;
            tblBagi.Click += tblBagi_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(349, 71);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(8, 8);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tblBagi);
            Controls.Add(tblClear);
            Controls.Add(tblKurang);
            Controls.Add(tblJumlah);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtangka2);
            Controls.Add(txthasil);
            Controls.Add(txtangka1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtangka1;
        private TextBox txthasil;
        private TextBox txtangka2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button tblJumlah;
        private Button tblKurang;
        private Button tblClear;
        private Button tblBagi;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
