namespace kereta_argo_ngawi_gejes_gejes
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            groupTiket = new GroupBox();
            btnKursi = new Button();
            lblTujuan = new Label();
            lblJumlah = new Label();
            lbKelas = new Label();
            lblTanggal = new Label();
            lblHarga = new Label();
            label1 = new Label();
            groupTiket.SuspendLayout();
            SuspendLayout();
            // 
            // groupTiket
            // 
            groupTiket.BackColor = Color.Transparent;
            groupTiket.Controls.Add(btnKursi);
            groupTiket.Controls.Add(lblTujuan);
            groupTiket.Controls.Add(lblJumlah);
            groupTiket.Controls.Add(lbKelas);
            groupTiket.Controls.Add(lblTanggal);
            groupTiket.Controls.Add(lblHarga);
            groupTiket.ForeColor = SystemColors.ControlText;
            groupTiket.Location = new Point(531, 103);
            groupTiket.Name = "groupTiket";
            groupTiket.Size = new Size(200, 249);
            groupTiket.TabIndex = 0;
            groupTiket.TabStop = false;
            groupTiket.Text = "groupBox3";
            // 
            // btnKursi
            // 
            btnKursi.Location = new Point(62, 162);
            btnKursi.Name = "btnKursi";
            btnKursi.Size = new Size(75, 31);
            btnKursi.TabIndex = 1;
            btnKursi.Text = "button1";
            btnKursi.UseVisualStyleBackColor = true;
            // 
            // lblTujuan
            // 
            lblTujuan.AutoSize = true;
            lblTujuan.Location = new Point(133, 82);
            lblTujuan.Name = "lblTujuan";
            lblTujuan.Size = new Size(38, 15);
            lblTujuan.TabIndex = 5;
            lblTujuan.Text = "label2";
            // 
            // lblJumlah
            // 
            lblJumlah.AutoSize = true;
            lblJumlah.Location = new Point(62, 71);
            lblJumlah.Name = "lblJumlah";
            lblJumlah.Size = new Size(38, 15);
            lblJumlah.TabIndex = 4;
            lblJumlah.Text = "label2";
            // 
            // lbKelas
            // 
            lbKelas.AutoSize = true;
            lbKelas.Location = new Point(105, 51);
            lbKelas.Name = "lbKelas";
            lbKelas.Size = new Size(38, 15);
            lbKelas.TabIndex = 3;
            lbKelas.Text = "label2";
            // 
            // lblTanggal
            // 
            lblTanggal.AutoSize = true;
            lblTanggal.Location = new Point(62, 34);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(38, 15);
            lblTanggal.TabIndex = 2;
            lblTanggal.Text = "label2";
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Location = new Point(33, 19);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(38, 15);
            lblHarga.TabIndex = 1;
            lblHarga.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(542, 43);
            label1.Name = "label1";
            label1.Size = new Size(172, 23);
            label1.TabIndex = 1;
            label1.Text = "Data penumpang";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(789, 597);
            Controls.Add(label1);
            Controls.Add(groupTiket);
            Name = "Form3";
            Text = "x";
            Load += Form3_Load;
            groupTiket.ResumeLayout(false);
            groupTiket.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lblTanggal;
        private GroupBox groupTiket;
        private Label lblHarga;
        private Label lblTujuan;
        private Label lblJumlah;
        private Label lbKelas;
        private Button btnKursi;
        private Label label1;
    }
}