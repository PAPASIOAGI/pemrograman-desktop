namespace kereta_argo_ngawi_gejes_gejes
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            GroupDataTiket = new GroupBox();
            label1 = new Label();
            lblHarga = new Label();
            lblKursi = new Label();
            lblJumlah = new Label();
            lblTanggal = new Label();
            lblKelas = new Label();
            lblNamaKereta = new Label();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            pictureBox2 = new PictureBox();
            btnPesanTiket = new Button();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            GroupDataTiket.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // GroupDataTiket
            // 
            GroupDataTiket.BackColor = Color.Transparent;
            GroupDataTiket.Controls.Add(label1);
            GroupDataTiket.Controls.Add(lblHarga);
            GroupDataTiket.Controls.Add(lblKursi);
            GroupDataTiket.Controls.Add(lblJumlah);
            GroupDataTiket.Controls.Add(lblTanggal);
            GroupDataTiket.Controls.Add(lblKelas);
            GroupDataTiket.Controls.Add(lblNamaKereta);
            GroupDataTiket.Location = new Point(12, 3);
            GroupDataTiket.Name = "GroupDataTiket";
            GroupDataTiket.Size = new Size(401, 236);
            GroupDataTiket.TabIndex = 0;
            GroupDataTiket.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(78, 11);
            label1.Name = "label1";
            label1.Size = new Size(188, 25);
            label1.TabIndex = 6;
            label1.Text = "DATA PENUMPANG";
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Bold);
            lblHarga.Location = new Point(39, 172);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(75, 21);
            lblHarga.TabIndex = 5;
            lblHarga.Text = "lblHarga";
            // 
            // lblKursi
            // 
            lblKursi.AutoSize = true;
            lblKursi.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Bold);
            lblKursi.Location = new Point(39, 112);
            lblKursi.Name = "lblKursi";
            lblKursi.Size = new Size(66, 21);
            lblKursi.TabIndex = 4;
            lblKursi.Text = "lblKursi";
            lblKursi.Click += lblKursi_Click;
            // 
            // lblJumlah
            // 
            lblJumlah.AutoSize = true;
            lblJumlah.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Bold);
            lblJumlah.Location = new Point(39, 151);
            lblJumlah.Name = "lblJumlah";
            lblJumlah.Size = new Size(56, 21);
            lblJumlah.TabIndex = 3;
            lblJumlah.Text = "label4";
            // 
            // lblTanggal
            // 
            lblTanggal.AutoSize = true;
            lblTanggal.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Bold);
            lblTanggal.Location = new Point(39, 91);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(89, 21);
            lblTanggal.TabIndex = 2;
            lblTanggal.Text = "lblTanggal";
            // 
            // lblKelas
            // 
            lblKelas.AutoSize = true;
            lblKelas.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Bold);
            lblKelas.Location = new Point(39, 67);
            lblKelas.Name = "lblKelas";
            lblKelas.Size = new Size(56, 21);
            lblKelas.TabIndex = 1;
            lblKelas.Text = "label2";
            // 
            // lblNamaKereta
            // 
            lblNamaKereta.AutoSize = true;
            lblNamaKereta.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Bold);
            lblNamaKereta.Location = new Point(39, 44);
            lblNamaKereta.Name = "lblNamaKereta";
            lblNamaKereta.Size = new Size(56, 21);
            lblNamaKereta.TabIndex = 0;
            lblNamaKereta.Text = "label1";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(419, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(193, 72);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupMetodebayar";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(0, 43);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(106, 19);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Bayar langsung";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(0, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(91, 19);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Tranfer bank";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(0, 99);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 30);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btnPesanTiket
            // 
            btnPesanTiket.BackColor = Color.Transparent;
            btnPesanTiket.BackgroundImage = (Image)resources.GetObject("btnPesanTiket.BackgroundImage");
            btnPesanTiket.BackgroundImageLayout = ImageLayout.Stretch;
            btnPesanTiket.Location = new Point(521, 81);
            btnPesanTiket.Name = "btnPesanTiket";
            btnPesanTiket.Size = new Size(91, 64);
            btnPesanTiket.TabIndex = 4;
            btnPesanTiket.UseVisualStyleBackColor = false;
            btnPesanTiket.Click += btnPesanTiket_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 80);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(3, 86);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(91, 43);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(659, 321);
            Controls.Add(btnPesanTiket);
            Controls.Add(groupBox1);
            Controls.Add(GroupDataTiket);
            Name = "Form5";
            Text = "Form5";
            GroupDataTiket.ResumeLayout(false);
            GroupDataTiket.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox GroupDataTiket;
        private System.Windows.Forms.Label lblKelas;
        private System.Windows.Forms.Label lblNamaKereta;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Label lblKursi;
        private System.Windows.Forms.Label lblJumlah;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnPesanTiket;
        private System.Windows.Forms.Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
    }
}