namespace kereta_argo_ngawi_gejes_gejes
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            dateTimePicker1 = new DateTimePicker();
            StasiunTujuan = new ComboBox();
            StasiunAsal = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            btnCarikereta = new Button();
            txtInfrant = new TextBox();
            btnKurang = new Button();
            btnTambah = new Button();
            tblTambah = new Button();
            tblKurang = new Button();
            txtDewasa = new TextBox();
            groupPAPANDA = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            btnEksekutifpapa1 = new Button();
            btnEksekutifpapa2 = new Button();
            btnEkonomipapa = new Button();
            label5 = new Label();
            groupArgobromo = new GroupBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            btnEksekutifargo1 = new Button();
            btnEksekutifargo2 = new Button();
            btnEkonomiargo = new Button();
            label9 = new Label();
            groupBangunkarta = new GroupBox();
            label15 = new Label();
            label10 = new Label();
            label16 = new Label();
            label17 = new Label();
            btnEkonomibangun = new Button();
            btnEksekutifbangun1 = new Button();
            btnEksekutifbangun2 = new Button();
            groupBogowonto = new GroupBox();
            label18 = new Label();
            label11 = new Label();
            label19 = new Label();
            label20 = new Label();
            btnEkonomibogowonto2 = new Button();
            btnEksekutifbogowonto1 = new Button();
            btnEksekutifbogowonto2 = new Button();
            groupBox1.SuspendLayout();
            groupPAPANDA.SuspendLayout();
            groupArgobromo.SuspendLayout();
            groupBangunkarta.SuspendLayout();
            groupBogowonto.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(45, 68);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(299, 23);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // StasiunTujuan
            // 
            StasiunTujuan.FormattingEnabled = true;
            StasiunTujuan.Location = new Point(212, 39);
            StasiunTujuan.Name = "StasiunTujuan";
            StasiunTujuan.Size = new Size(134, 23);
            StasiunTujuan.TabIndex = 1;
            // 
            // StasiunAsal
            // 
            StasiunAsal.FormattingEnabled = true;
            StasiunAsal.Location = new Point(45, 39);
            StasiunAsal.Name = "StasiunAsal";
            StasiunAsal.Size = new Size(148, 23);
            StasiunAsal.TabIndex = 2;
            StasiunAsal.SelectedIndexChanged += StasiunAsal_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(45, 21);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 3;
            label1.Text = "Stasiun asal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(212, 21);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 4;
            label2.Text = "Stasiun Tujuan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(26, 114);
            label3.Name = "label3";
            label3.Size = new Size(167, 15);
            label3.TabIndex = 7;
            label3.Text = "Penumpang dewasa <3 Tahun";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(251, 114);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 8;
            label4.Text = "Infrant >3 Tahun";
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox1.Controls.Add(btnCarikereta);
            groupBox1.Controls.Add(txtInfrant);
            groupBox1.Controls.Add(btnKurang);
            groupBox1.Controls.Add(btnTambah);
            groupBox1.Controls.Add(tblTambah);
            groupBox1.Controls.Add(tblKurang);
            groupBox1.Controls.Add(txtDewasa);
            groupBox1.Controls.Add(StasiunAsal);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(StasiunTujuan);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(204, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(389, 231);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnCarikereta
            // 
            btnCarikereta.Location = new Point(152, 178);
            btnCarikereta.Name = "btnCarikereta";
            btnCarikereta.Size = new Size(75, 23);
            btnCarikereta.TabIndex = 15;
            btnCarikereta.Text = "cari";
            btnCarikereta.UseVisualStyleBackColor = true;
            btnCarikereta.Click += btnCarikereta_Click;
            // 
            // txtInfrant
            // 
            txtInfrant.Location = new Point(267, 132);
            txtInfrant.Name = "txtInfrant";
            txtInfrant.Size = new Size(66, 23);
            txtInfrant.TabIndex = 14;
            // 
            // btnKurang
            // 
            btnKurang.Location = new Point(238, 132);
            btnKurang.Name = "btnKurang";
            btnKurang.Size = new Size(33, 23);
            btnKurang.TabIndex = 13;
            btnKurang.Text = "-";
            btnKurang.UseVisualStyleBackColor = true;
            btnKurang.Click += btnKurang_Click;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(328, 132);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(33, 23);
            btnTambah.TabIndex = 12;
            btnTambah.Text = "+";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // tblTambah
            // 
            tblTambah.Location = new Point(142, 132);
            tblTambah.Name = "tblTambah";
            tblTambah.Size = new Size(33, 23);
            tblTambah.TabIndex = 11;
            tblTambah.Text = "+";
            tblTambah.UseVisualStyleBackColor = true;
            tblTambah.Click += tblTambah_Click;
            // 
            // tblKurang
            // 
            tblKurang.Location = new Point(47, 132);
            tblKurang.Name = "tblKurang";
            tblKurang.Size = new Size(33, 23);
            tblKurang.TabIndex = 10;
            tblKurang.Text = "-";
            tblKurang.UseVisualStyleBackColor = true;
            tblKurang.Click += tblKurang_Click;
            // 
            // txtDewasa
            // 
            txtDewasa.Location = new Point(80, 132);
            txtDewasa.Name = "txtDewasa";
            txtDewasa.Size = new Size(66, 23);
            txtDewasa.TabIndex = 11;
            // 
            // groupPAPANDA
            // 
            groupPAPANDA.BackColor = Color.Transparent;
            groupPAPANDA.BackgroundImageLayout = ImageLayout.Stretch;
            groupPAPANDA.Controls.Add(label8);
            groupPAPANDA.Controls.Add(label7);
            groupPAPANDA.Controls.Add(label6);
            groupPAPANDA.Controls.Add(btnEksekutifpapa1);
            groupPAPANDA.Controls.Add(btnEksekutifpapa2);
            groupPAPANDA.Controls.Add(btnEkonomipapa);
            groupPAPANDA.Controls.Add(label5);
            groupPAPANDA.Location = new Point(107, 235);
            groupPAPANDA.Name = "groupPAPANDA";
            groupPAPANDA.Size = new Size(547, 100);
            groupPAPANDA.TabIndex = 10;
            groupPAPANDA.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(355, 75);
            label8.Name = "label8";
            label8.Size = new Size(82, 15);
            label8.TabIndex = 12;
            label8.Text = "EKSEKUTIF AA";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(355, 43);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 11;
            label7.Text = "EKSEKUTIF A";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(355, 14);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 4;
            label6.Text = "EKONOMI";
            // 
            // btnEksekutifpapa1
            // 
            btnEksekutifpapa1.Location = new Point(466, 39);
            btnEksekutifpapa1.Name = "btnEksekutifpapa1";
            btnEksekutifpapa1.Size = new Size(75, 23);
            btnEksekutifpapa1.TabIndex = 3;
            btnEksekutifpapa1.Text = "pesan";
            btnEksekutifpapa1.UseVisualStyleBackColor = true;
            btnEksekutifpapa1.Click += btnEksekutifpapa1_Click;
            // 
            // btnEksekutifpapa2
            // 
            btnEksekutifpapa2.Location = new Point(466, 71);
            btnEksekutifpapa2.Name = "btnEksekutifpapa2";
            btnEksekutifpapa2.Size = new Size(75, 23);
            btnEksekutifpapa2.TabIndex = 2;
            btnEksekutifpapa2.Text = "pesan";
            btnEksekutifpapa2.UseVisualStyleBackColor = true;
            btnEksekutifpapa2.Click += btnEksekutifpapa2_Click;
            // 
            // btnEkonomipapa
            // 
            btnEkonomipapa.Location = new Point(466, 10);
            btnEkonomipapa.Name = "btnEkonomipapa";
            btnEkonomipapa.Size = new Size(75, 23);
            btnEkonomipapa.TabIndex = 1;
            btnEkonomipapa.Text = "pesan";
            btnEkonomipapa.UseVisualStyleBackColor = true;
            btnEkonomipapa.Click += btnEkonomipapa_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 47);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 0;
            label5.Text = "PAPANDAYANGAN";
            // 
            // groupArgobromo
            // 
            groupArgobromo.BackColor = Color.Transparent;
            groupArgobromo.Controls.Add(label12);
            groupArgobromo.Controls.Add(label13);
            groupArgobromo.Controls.Add(label14);
            groupArgobromo.Controls.Add(btnEksekutifargo1);
            groupArgobromo.Controls.Add(btnEksekutifargo2);
            groupArgobromo.Controls.Add(btnEkonomiargo);
            groupArgobromo.Controls.Add(label9);
            groupArgobromo.Location = new Point(107, 235);
            groupArgobromo.Name = "groupArgobromo";
            groupArgobromo.Size = new Size(547, 100);
            groupArgobromo.TabIndex = 11;
            groupArgobromo.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(355, 80);
            label12.Name = "label12";
            label12.Size = new Size(82, 15);
            label12.TabIndex = 19;
            label12.Text = "EKSEKUTIF AA";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(355, 48);
            label13.Name = "label13";
            label13.Size = new Size(74, 15);
            label13.TabIndex = 18;
            label13.Text = "EKSEKUTIF A";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(355, 19);
            label14.Name = "label14";
            label14.Size = new Size(60, 15);
            label14.TabIndex = 17;
            label14.Text = "EKONOMI";
            // 
            // btnEksekutifargo1
            // 
            btnEksekutifargo1.Location = new Point(466, 44);
            btnEksekutifargo1.Name = "btnEksekutifargo1";
            btnEksekutifargo1.Size = new Size(75, 23);
            btnEksekutifargo1.TabIndex = 16;
            btnEksekutifargo1.Text = "pesan";
            btnEksekutifargo1.UseVisualStyleBackColor = true;
            btnEksekutifargo1.Click += btnEksekutifargo1_Click;
            // 
            // btnEksekutifargo2
            // 
            btnEksekutifargo2.Location = new Point(466, 76);
            btnEksekutifargo2.Name = "btnEksekutifargo2";
            btnEksekutifargo2.Size = new Size(75, 23);
            btnEksekutifargo2.TabIndex = 15;
            btnEksekutifargo2.Text = "pesan";
            btnEksekutifargo2.UseVisualStyleBackColor = true;
            btnEksekutifargo2.Click += btnEksekutifargo2_Click;
            // 
            // btnEkonomiargo
            // 
            btnEkonomiargo.Location = new Point(466, 15);
            btnEkonomiargo.Name = "btnEkonomiargo";
            btnEkonomiargo.Size = new Size(75, 23);
            btnEkonomiargo.TabIndex = 14;
            btnEkonomiargo.Text = "pesan";
            btnEkonomiargo.UseVisualStyleBackColor = true;
            btnEkonomiargo.Click += btnEkonomiargo_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(32, 32);
            label9.Name = "label9";
            label9.Size = new Size(120, 15);
            label9.TabIndex = 13;
            label9.Text = "Argo Bromo Anggrek";
            // 
            // groupBangunkarta
            // 
            groupBangunkarta.BackColor = Color.Transparent;
            groupBangunkarta.Controls.Add(label15);
            groupBangunkarta.Controls.Add(label10);
            groupBangunkarta.Controls.Add(label16);
            groupBangunkarta.Controls.Add(label17);
            groupBangunkarta.Controls.Add(btnEkonomibangun);
            groupBangunkarta.Controls.Add(btnEksekutifbangun1);
            groupBangunkarta.Controls.Add(btnEksekutifbangun2);
            groupBangunkarta.Location = new Point(107, 235);
            groupBangunkarta.Name = "groupBangunkarta";
            groupBangunkarta.Size = new Size(547, 100);
            groupBangunkarta.TabIndex = 12;
            groupBangunkarta.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(355, 80);
            label15.Name = "label15";
            label15.Size = new Size(82, 15);
            label15.TabIndex = 25;
            label15.Text = "EKSEKUTIF AA";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(32, 45);
            label10.Name = "label10";
            label10.Size = new Size(75, 15);
            label10.TabIndex = 14;
            label10.Text = "BangunKarta";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(355, 48);
            label16.Name = "label16";
            label16.Size = new Size(74, 15);
            label16.TabIndex = 24;
            label16.Text = "EKSEKUTIF A";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(355, 19);
            label17.Name = "label17";
            label17.Size = new Size(60, 15);
            label17.TabIndex = 23;
            label17.Text = "EKONOMI";
            // 
            // btnEkonomibangun
            // 
            btnEkonomibangun.Location = new Point(466, 15);
            btnEkonomibangun.Name = "btnEkonomibangun";
            btnEkonomibangun.Size = new Size(75, 23);
            btnEkonomibangun.TabIndex = 20;
            btnEkonomibangun.Text = "pesan";
            btnEkonomibangun.UseVisualStyleBackColor = true;
            btnEkonomibangun.Click += btnEkonomibangun_Click;
            // 
            // btnEksekutifbangun1
            // 
            btnEksekutifbangun1.Location = new Point(466, 44);
            btnEksekutifbangun1.Name = "btnEksekutifbangun1";
            btnEksekutifbangun1.Size = new Size(75, 23);
            btnEksekutifbangun1.TabIndex = 22;
            btnEksekutifbangun1.Text = "pesan";
            btnEksekutifbangun1.UseVisualStyleBackColor = true;
            btnEksekutifbangun1.Click += btnEksekutifbangun1_Click;
            // 
            // btnEksekutifbangun2
            // 
            btnEksekutifbangun2.Location = new Point(466, 76);
            btnEksekutifbangun2.Name = "btnEksekutifbangun2";
            btnEksekutifbangun2.Size = new Size(75, 23);
            btnEksekutifbangun2.TabIndex = 21;
            btnEksekutifbangun2.Text = "pesan";
            btnEksekutifbangun2.UseVisualStyleBackColor = true;
            btnEksekutifbangun2.Click += btnEksekutifbangun2_Click;
            // 
            // groupBogowonto
            // 
            groupBogowonto.BackColor = Color.Transparent;
            groupBogowonto.Controls.Add(label18);
            groupBogowonto.Controls.Add(label11);
            groupBogowonto.Controls.Add(label19);
            groupBogowonto.Controls.Add(label20);
            groupBogowonto.Controls.Add(btnEkonomibogowonto2);
            groupBogowonto.Controls.Add(btnEksekutifbogowonto1);
            groupBogowonto.Controls.Add(btnEksekutifbogowonto2);
            groupBogowonto.Location = new Point(107, 235);
            groupBogowonto.Name = "groupBogowonto";
            groupBogowonto.Size = new Size(547, 100);
            groupBogowonto.TabIndex = 12;
            groupBogowonto.TabStop = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(355, 80);
            label18.Name = "label18";
            label18.Size = new Size(82, 15);
            label18.TabIndex = 31;
            label18.Text = "EKSEKUTIF AA";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Location = new Point(23, 47);
            label11.Name = "label11";
            label11.Size = new Size(69, 15);
            label11.TabIndex = 15;
            label11.Text = "Bogowonto";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(355, 48);
            label19.Name = "label19";
            label19.Size = new Size(74, 15);
            label19.TabIndex = 30;
            label19.Text = "EKSEKUTIF A";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(355, 19);
            label20.Name = "label20";
            label20.Size = new Size(60, 15);
            label20.TabIndex = 29;
            label20.Text = "EKONOMI";
            // 
            // btnEkonomibogowonto2
            // 
            btnEkonomibogowonto2.Location = new Point(466, 15);
            btnEkonomibogowonto2.Name = "btnEkonomibogowonto2";
            btnEkonomibogowonto2.Size = new Size(75, 23);
            btnEkonomibogowonto2.TabIndex = 26;
            btnEkonomibogowonto2.Text = "pesan";
            btnEkonomibogowonto2.UseVisualStyleBackColor = true;
            btnEkonomibogowonto2.Click += btnEkonomibogowonto2_Click;
            // 
            // btnEksekutifbogowonto1
            // 
            btnEksekutifbogowonto1.Location = new Point(466, 44);
            btnEksekutifbogowonto1.Name = "btnEksekutifbogowonto1";
            btnEksekutifbogowonto1.Size = new Size(75, 23);
            btnEksekutifbogowonto1.TabIndex = 28;
            btnEksekutifbogowonto1.Text = "pesan";
            btnEksekutifbogowonto1.UseVisualStyleBackColor = true;
            btnEksekutifbogowonto1.Click += btnEksekutifbogowonto1_Click;
            // 
            // btnEksekutifbogowonto2
            // 
            btnEksekutifbogowonto2.Location = new Point(466, 76);
            btnEksekutifbogowonto2.Name = "btnEksekutifbogowonto2";
            btnEksekutifbogowonto2.Size = new Size(75, 23);
            btnEksekutifbogowonto2.TabIndex = 27;
            btnEksekutifbogowonto2.Text = "pesan";
            btnEksekutifbogowonto2.UseVisualStyleBackColor = true;
            btnEksekutifbogowonto2.Click += btnEksekutifbogowonto2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 523);
            Controls.Add(groupBangunkarta);
            Controls.Add(groupBogowonto);
            Controls.Add(groupArgobromo);
            Controls.Add(groupPAPANDA);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "zs";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupPAPANDA.ResumeLayout(false);
            groupPAPANDA.PerformLayout();
            groupArgobromo.ResumeLayout(false);
            groupArgobromo.PerformLayout();
            groupBangunkarta.ResumeLayout(false);
            groupBangunkarta.PerformLayout();
            groupBogowonto.ResumeLayout(false);
            groupBogowonto.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private ComboBox StasiunTujuan;
        private ComboBox StasiunAsal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private Button tblKurang;
        private Button tblTambah;
        private TextBox txtDewasa;
        private Button btnKurang;
        private Button btnTambah;
        private TextBox txtInfrant;
        private GroupBox groupPAPANDA;
        private Label label5;
        private Button btnEkonomipapa;
        private Button btnCarikereta;
        private Button btnEksekutifpapa1;
        private Button btnEksekutifpapa2;
        private Label label8;
        private Label label7;
        private Label label6;
        private GroupBox groupArgobromo;
        private GroupBox groupBangunkarta;
        private GroupBox groupBogowonto;
        private GroupBox groupBox5;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Button btnEksekutifargo1;
        private Button btnEksekutifargo2;
        private Button btnEkonomiargo;
        private Label label15;
        private Label label16;
        private Label label17;
        private Button btnEkonomibangun;
        private Button btnEksekutifbangun1;
        private Button btnEksekutifbangun2;
        private Label label18;
        private Label label19;
        private Label label20;
        private Button btnEkonomibogowonto2;
        private Button btnEksekutifbogowonto1;
        private Button btnEksekutifbogowonto2;
    }
}