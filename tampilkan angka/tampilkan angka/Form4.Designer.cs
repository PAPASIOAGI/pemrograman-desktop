namespace tampilkan_angka
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtInvestasi = new TextBox();
            txtBunga = new TextBox();
            txtJumlahTahun = new TextBox();
            groupBox1 = new GroupBox();
            rdbPerTahun = new RadioButton();
            rdbPerMinggu = new RadioButton();
            rdbPerBulan = new RadioButton();
            rdbPerHari = new RadioButton();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnHitung = new Button();
            btnClear = new Button();
            button3 = new Button();
            txtHasil = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtInvestasi
            // 
            txtInvestasi.Location = new Point(213, 65);
            txtInvestasi.Name = "txtInvestasi";
            txtInvestasi.Size = new Size(100, 23);
            txtInvestasi.TabIndex = 0;
            // 
            // txtBunga
            // 
            txtBunga.Location = new Point(213, 113);
            txtBunga.Name = "txtBunga";
            txtBunga.Size = new Size(100, 23);
            txtBunga.TabIndex = 1;
            txtBunga.TextChanged += txtBunga_TextChanged;
            // 
            // txtJumlahTahun
            // 
            txtJumlahTahun.Location = new Point(213, 153);
            txtJumlahTahun.Name = "txtJumlahTahun";
            txtJumlahTahun.Size = new Size(100, 23);
            txtJumlahTahun.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbPerTahun);
            groupBox1.Controls.Add(rdbPerMinggu);
            groupBox1.Controls.Add(rdbPerBulan);
            groupBox1.Controls.Add(rdbPerHari);
            groupBox1.Location = new Point(213, 182);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // rdbPerTahun
            // 
            rdbPerTahun.AutoSize = true;
            rdbPerTahun.Location = new Point(100, 42);
            rdbPerTahun.Name = "rdbPerTahun";
            rdbPerTahun.Size = new Size(82, 19);
            rdbPerTahun.TabIndex = 3;
            rdbPerTahun.TabStop = true;
            rdbPerTahun.Text = "TAHUNAN";
            rdbPerTahun.UseVisualStyleBackColor = true;
            rdbPerTahun.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // rdbPerMinggu
            // 
            rdbPerMinggu.AutoSize = true;
            rdbPerMinggu.Location = new Point(100, 17);
            rdbPerMinggu.Name = "rdbPerMinggu";
            rdbPerMinggu.Size = new Size(72, 19);
            rdbPerMinggu.TabIndex = 2;
            rdbPerMinggu.TabStop = true;
            rdbPerMinggu.Text = "MINGGU";
            rdbPerMinggu.UseVisualStyleBackColor = true;
            rdbPerMinggu.CheckedChanged += rdbPerMinggu_CheckedChanged;
            // 
            // rdbPerBulan
            // 
            rdbPerBulan.AutoSize = true;
            rdbPerBulan.Location = new Point(13, 41);
            rdbPerBulan.Name = "rdbPerBulan";
            rdbPerBulan.Size = new Size(63, 19);
            rdbPerBulan.TabIndex = 1;
            rdbPerBulan.TabStop = true;
            rdbPerBulan.Text = "BULAN";
            rdbPerBulan.UseVisualStyleBackColor = true;
            rdbPerBulan.CheckedChanged += rdbPerBulan_CheckedChanged;
            // 
            // rdbPerHari
            // 
            rdbPerHari.AutoSize = true;
            rdbPerHari.Location = new Point(13, 17);
            rdbPerHari.Name = "rdbPerHari";
            rdbPerHari.Size = new Size(52, 19);
            rdbPerHari.TabIndex = 0;
            rdbPerHari.TabStop = true;
            rdbPerHari.Text = "HARI";
            rdbPerHari.UseVisualStyleBackColor = true;
            rdbPerHari.CheckedChanged += rdbPerHari_CheckedChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(446, 65);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 244);
            listBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(213, 38);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 5;
            label1.Text = "INVEST";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 95);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 6;
            label2.Text = "INTEREST";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(213, 139);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 7;
            label3.Text = "BERAPA TAHUN";
            // 
            // btnHitung
            // 
            btnHitung.Location = new Point(213, 288);
            btnHitung.Name = "btnHitung";
            btnHitung.Size = new Size(75, 23);
            btnHitung.TabIndex = 8;
            btnHitung.Text = "HITUNG!";
            btnHitung.UseVisualStyleBackColor = true;
            btnHitung.Click += btnHitung_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(291, 288);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 9;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(365, 286);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 10;
            button3.Text = "BACK";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtHasil
            // 
            txtHasil.Location = new Point(291, 30);
            txtHasil.Name = "txtHasil";
            txtHasil.Size = new Size(275, 23);
            txtHasil.TabIndex = 11;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtHasil);
            Controls.Add(button3);
            Controls.Add(btnClear);
            Controls.Add(btnHitung);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Controls.Add(txtJumlahTahun);
            Controls.Add(txtBunga);
            Controls.Add(txtInvestasi);
            Name = "Form4";
            Text = "Form4";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInvestasi;
        private TextBox txtBunga;
        private TextBox txtJumlahTahun;
        private GroupBox groupBox1;
        private RadioButton rdbPerTahun;
        private RadioButton rdbPerMinggu;
        private RadioButton rdbPerBulan;
        private RadioButton rdbPerHari;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnHitung;
        private Button btnClear;
        private Button button3;
        private TextBox txtHasil;
    }
}