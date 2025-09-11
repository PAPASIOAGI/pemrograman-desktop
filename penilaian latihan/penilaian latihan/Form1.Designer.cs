namespace penilaian_latihan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            txtKategori = new TextBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            txtKompeten = new TextBox();
            tblClear = new Button();
            pictureBox1 = new PictureBox();
            tblHitung = new Button();
            txtHasil = new TextBox();
            txtAkhir = new TextBox();
            label3 = new Label();
            txtTengah = new TextBox();
            label2 = new Label();
            txtHarian = new TextBox();
            label1 = new Label();
            tblSimpan = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.Controls.Add(tblSimpan);
            groupBox1.Controls.Add(txtKategori);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtKompeten);
            groupBox1.Controls.Add(tblClear);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(tblHitung);
            groupBox1.Controls.Add(txtHasil);
            groupBox1.Controls.Add(txtAkhir);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTengah);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtHarian);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(540, 289);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "academic ability scores of students redbull junior academy";
            // 
            // txtKategori
            // 
            txtKategori.Location = new Point(457, 149);
            txtKategori.Name = "txtKategori";
            txtKategori.Size = new Size(83, 23);
            txtKategori.TabIndex = 9;
            txtKategori.TextChanged += txtKategori_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(376, 178);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(164, 111);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(257, 209);
            button1.Name = "button1";
            button1.Size = new Size(35, 33);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtKompeten
            // 
            txtKompeten.Location = new Point(376, 149);
            txtKompeten.Multiline = true;
            txtKompeten.Name = "txtKompeten";
            txtKompeten.Size = new Size(75, 23);
            txtKompeten.TabIndex = 1;
            txtKompeten.TextChanged += txtKompeten_TextChanged;
            // 
            // tblClear
            // 
            tblClear.BackgroundImage = (Image)resources.GetObject("tblClear.BackgroundImage");
            tblClear.BackgroundImageLayout = ImageLayout.Stretch;
            tblClear.Location = new Point(191, 206);
            tblClear.Name = "tblClear";
            tblClear.Size = new Size(49, 36);
            tblClear.TabIndex = 1;
            tblClear.UseVisualStyleBackColor = true;
            tblClear.Click += tblClear_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(376, 178);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // tblHitung
            // 
            tblHitung.BackColor = SystemColors.Control;
            tblHitung.Location = new Point(307, 206);
            tblHitung.Name = "tblHitung";
            tblHitung.Size = new Size(48, 36);
            tblHitung.TabIndex = 7;
            tblHitung.Text = "Check";
            tblHitung.UseVisualStyleBackColor = false;
            tblHitung.Click += tblHitung_Click;
            // 
            // txtHasil
            // 
            txtHasil.BorderStyle = BorderStyle.None;
            txtHasil.Font = new Font("Segoe UI", 20F);
            txtHasil.Location = new Point(235, 149);
            txtHasil.Multiline = true;
            txtHasil.Name = "txtHasil";
            txtHasil.Size = new Size(73, 37);
            txtHasil.TabIndex = 1;
            txtHasil.TextChanged += txtHasil_TextChanged;
            // 
            // txtAkhir
            // 
            txtAkhir.Location = new Point(418, 68);
            txtAkhir.Name = "txtAkhir";
            txtAkhir.Size = new Size(63, 23);
            txtAkhir.TabIndex = 3;
            txtAkhir.TextChanged += txtAkhir_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(418, 35);
            label3.Name = "label3";
            label3.Size = new Size(63, 30);
            label3.TabIndex = 6;
            label3.Text = "Nilai akhir \r\nSemester";
            // 
            // txtTengah
            // 
            txtTengah.Location = new Point(235, 68);
            txtTengah.Name = "txtTengah";
            txtTengah.Size = new Size(73, 23);
            txtTengah.TabIndex = 2;
            txtTengah.TextChanged += txtTengah_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 35);
            label2.Name = "label2";
            label2.Size = new Size(73, 30);
            label2.TabIndex = 5;
            label2.Text = "Nilai Tengah\r\nSemester";
            label2.Click += label2_Click;
            // 
            // txtHarian
            // 
            txtHarian.Location = new Point(63, 68);
            txtHarian.Name = "txtHarian";
            txtHarian.Size = new Size(40, 23);
            txtHarian.TabIndex = 1;
            txtHarian.TextChanged += txtHarian_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.MenuBar;
            label1.Location = new Point(63, 35);
            label1.Name = "label1";
            label1.Size = new Size(40, 30);
            label1.TabIndex = 4;
            label1.Text = "Nilai \r\nharian";
            label1.Click += label1_Click;
            // 
            // tblSimpan
            // 
            tblSimpan.BackgroundImage = (Image)resources.GetObject("tblSimpan.BackgroundImage");
            tblSimpan.BackgroundImageLayout = ImageLayout.Stretch;
            tblSimpan.Location = new Point(0, 242);
            tblSimpan.Name = "tblSimpan";
            tblSimpan.Size = new Size(49, 47);
            tblSimpan.TabIndex = 10;
            tblSimpan.UseVisualStyleBackColor = true;
            tblSimpan.Click += tblSimpan_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(737, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtHarian;
        private TextBox txtTengah;
        private TextBox txtAkhir;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox txtHasil;
        private Button tblHitung;
        private PictureBox pictureBox1;
        private Button tblClear;
        private TextBox txtKompeten;
        private Button button1;
        private PictureBox pictureBox2;
        private TextBox txtKategori;
        private Button tblSimpan;
    }
}
