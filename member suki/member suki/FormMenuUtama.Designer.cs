namespace member_suki
{
    partial class FormMenuUtama
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
            menuStrip1 = new MenuStrip();
            mASTERToolStripMenuItem = new ToolStripMenuItem();
            tRANSAKSIToolStripMenuItem = new ToolStripMenuItem();
            mEMBERToolStripMenuItem = new ToolStripMenuItem();
            sTOKGUDANGToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            dataGridUser = new DataGridView();
            txtID = new TextBox();
            label1 = new Label();
            groupmember = new GroupBox();
            label5 = new Label();
            cbKategori = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtPW = new TextBox();
            txtNama = new TextBox();
            tblTambah = new Button();
            tblUpdate = new Button();
            tblDelete = new Button();
            groupstok = new GroupBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            kodeBarang = new Label();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupbtnmember = new GroupBox();
            groupbtnstok = new GroupBox();
            button1 = new Button();
            cbJenisbarang = new ComboBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridUser).BeginInit();
            groupmember.SuspendLayout();
            groupstok.SuspendLayout();
            groupbtnmember.SuspendLayout();
            groupbtnstok.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mASTERToolStripMenuItem, tRANSAKSIToolStripMenuItem, mEMBERToolStripMenuItem, sTOKGUDANGToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mASTERToolStripMenuItem
            // 
            mASTERToolStripMenuItem.Name = "mASTERToolStripMenuItem";
            mASTERToolStripMenuItem.Size = new Size(64, 20);
            mASTERToolStripMenuItem.Text = "MASTER";
            mASTERToolStripMenuItem.Click += mASTERToolStripMenuItem_Click;
            // 
            // tRANSAKSIToolStripMenuItem
            // 
            tRANSAKSIToolStripMenuItem.Name = "tRANSAKSIToolStripMenuItem";
            tRANSAKSIToolStripMenuItem.Size = new Size(80, 20);
            tRANSAKSIToolStripMenuItem.Text = "TRANSAKSI";
            // 
            // mEMBERToolStripMenuItem
            // 
            mEMBERToolStripMenuItem.Name = "mEMBERToolStripMenuItem";
            mEMBERToolStripMenuItem.Size = new Size(67, 20);
            mEMBERToolStripMenuItem.Text = "MEMBER";
            mEMBERToolStripMenuItem.Click += mEMBERToolStripMenuItem_Click;
            // 
            // sTOKGUDANGToolStripMenuItem
            // 
            sTOKGUDANGToolStripMenuItem.Name = "sTOKGUDANGToolStripMenuItem";
            sTOKGUDANGToolStripMenuItem.Size = new Size(102, 20);
            sTOKGUDANGToolStripMenuItem.Text = "STOK GUDANG ";
            sTOKGUDANGToolStripMenuItem.Click += sTOKGUDANGToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 273);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(614, 277);
            dataGridView1.TabIndex = 1;
            // 
            // dataGridUser
            // 
            dataGridUser.BackgroundColor = SystemColors.ActiveCaption;
            dataGridUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUser.Location = new Point(18, 273);
            dataGridUser.Name = "dataGridUser";
            dataGridUser.Size = new Size(614, 277);
            dataGridUser.TabIndex = 2;
            dataGridUser.CellContentClick += dataGridView2_CellContentClick;
            // 
            // txtID
            // 
            txtID.Location = new Point(65, 54);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 57);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 4;
            label1.Text = "UserID";
            label1.Click += label1_Click;
            // 
            // groupmember
            // 
            groupmember.Controls.Add(label5);
            groupmember.Controls.Add(cbKategori);
            groupmember.Controls.Add(label4);
            groupmember.Controls.Add(label3);
            groupmember.Controls.Add(label2);
            groupmember.Controls.Add(txtPW);
            groupmember.Controls.Add(txtNama);
            groupmember.Controls.Add(txtID);
            groupmember.Controls.Add(label1);
            groupmember.Location = new Point(12, 26);
            groupmember.Name = "groupmember";
            groupmember.Size = new Size(398, 188);
            groupmember.TabIndex = 5;
            groupmember.TabStop = false;
            groupmember.Enter += groupmember_Enter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(176, 19);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 11;
            label5.Text = "Member";
            // 
            // cbKategori
            // 
            cbKategori.FormattingEnabled = true;
            cbKategori.Items.AddRange(new object[] { "KASIR", "ADMIN", "MAGANG" });
            cbKategori.Location = new Point(122, 164);
            cbKategori.Name = "cbKategori";
            cbKategori.Size = new Size(121, 23);
            cbKategori.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(144, 131);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 6;
            label4.Text = "Kategori";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(144, 84);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 9;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(204, 62);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 8;
            label2.Text = "Nama";
            // 
            // txtPW
            // 
            txtPW.Location = new Point(128, 102);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(100, 23);
            txtPW.TabIndex = 7;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(249, 54);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(100, 23);
            txtNama.TabIndex = 5;
            // 
            // tblTambah
            // 
            tblTambah.Location = new Point(204, 12);
            tblTambah.Name = "tblTambah";
            tblTambah.Size = new Size(75, 23);
            tblTambah.TabIndex = 6;
            tblTambah.Text = "TAMBAH";
            tblTambah.UseVisualStyleBackColor = true;
            tblTambah.Click += tblTambah_Click;
            // 
            // tblUpdate
            // 
            tblUpdate.Location = new Point(4, 12);
            tblUpdate.Name = "tblUpdate";
            tblUpdate.Size = new Size(75, 23);
            tblUpdate.TabIndex = 7;
            tblUpdate.Text = "UPDATE";
            tblUpdate.UseVisualStyleBackColor = true;
            // 
            // tblDelete
            // 
            tblDelete.Location = new Point(101, 12);
            tblDelete.Name = "tblDelete";
            tblDelete.Size = new Size(75, 23);
            tblDelete.TabIndex = 8;
            tblDelete.Text = "HAPUS";
            tblDelete.UseVisualStyleBackColor = true;
            // 
            // groupstok
            // 
            groupstok.Controls.Add(cbJenisbarang);
            groupstok.Controls.Add(label11);
            groupstok.Controls.Add(label10);
            groupstok.Controls.Add(label9);
            groupstok.Controls.Add(label8);
            groupstok.Controls.Add(label7);
            groupstok.Controls.Add(kodeBarang);
            groupstok.Controls.Add(textBox6);
            groupstok.Controls.Add(textBox5);
            groupstok.Controls.Add(textBox4);
            groupstok.Controls.Add(textBox2);
            groupstok.Controls.Add(textBox1);
            groupstok.Location = new Point(416, 35);
            groupstok.Name = "groupstok";
            groupstok.Size = new Size(372, 178);
            groupstok.TabIndex = 9;
            groupstok.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(213, 131);
            label11.Name = "label11";
            label11.Size = new Size(35, 15);
            label11.TabIndex = 11;
            label11.Text = "STOK";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(213, 75);
            label10.Name = "label10";
            label10.Size = new Size(76, 15);
            label10.TabIndex = 10;
            label10.Text = "HARGA JUAL";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(213, 27);
            label9.Name = "label9";
            label9.Size = new Size(72, 15);
            label9.TabIndex = 9;
            label9.Text = "HARGA BELI";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(34, 131);
            label8.Name = "label8";
            label8.Size = new Size(85, 15);
            label8.TabIndex = 8;
            label8.Text = "JENIS BARANG";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 75);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 7;
            label7.Text = "NAMA BARANG";
            // 
            // kodeBarang
            // 
            kodeBarang.AutoSize = true;
            kodeBarang.Location = new Point(34, 22);
            kodeBarang.Name = "kodeBarang";
            kodeBarang.Size = new Size(86, 15);
            kodeBarang.TabIndex = 6;
            kodeBarang.Text = "KODE BARANG";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(213, 149);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(213, 93);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(213, 45);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(34, 93);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // groupbtnmember
            // 
            groupbtnmember.Controls.Add(tblDelete);
            groupbtnmember.Controls.Add(tblTambah);
            groupbtnmember.Controls.Add(tblUpdate);
            groupbtnmember.Location = new Point(12, 220);
            groupbtnmember.Name = "groupbtnmember";
            groupbtnmember.Size = new Size(280, 47);
            groupbtnmember.TabIndex = 10;
            groupbtnmember.TabStop = false;
            // 
            // groupbtnstok
            // 
            groupbtnstok.Controls.Add(button1);
            groupbtnstok.Location = new Point(416, 232);
            groupbtnstok.Name = "groupbtnstok";
            groupbtnstok.Size = new Size(372, 35);
            groupbtnstok.TabIndex = 11;
            groupbtnstok.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(6, 11);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "TAMBAH";
            button1.UseVisualStyleBackColor = true;
            // 
            // cbJenisbarang
            // 
            cbJenisbarang.FormattingEnabled = true;
            cbJenisbarang.Location = new Point(34, 149);
            cbJenisbarang.Name = "cbJenisbarang";
            cbJenisbarang.Size = new Size(121, 23);
            cbJenisbarang.TabIndex = 13;
            // 
            // FormMenuUtama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 576);
            Controls.Add(groupbtnstok);
            Controls.Add(groupbtnmember);
            Controls.Add(groupstok);
            Controls.Add(groupmember);
            Controls.Add(dataGridUser);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMenuUtama";
            Text = "FormMenuUtama";
            Load += FormMenuUtama_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridUser).EndInit();
            groupmember.ResumeLayout(false);
            groupmember.PerformLayout();
            groupstok.ResumeLayout(false);
            groupstok.PerformLayout();
            groupbtnmember.ResumeLayout(false);
            groupbtnstok.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mASTERToolStripMenuItem;
        private ToolStripMenuItem tRANSAKSIToolStripMenuItem;
        private DataGridView dataGridView1;
        private ToolStripMenuItem mEMBERToolStripMenuItem;
        private ToolStripMenuItem sTOKGUDANGToolStripMenuItem;
        private DataGridView dataGridUser;
        private TextBox txtID;
        private Label label1;
        private GroupBox groupmember;
        private Label label2;
        private TextBox txtPW;
        private TextBox txtNama;
        private ComboBox cbKategori;
        private Label label4;
        private Label label3;
        private Button tblTambah;
        private Button tblUpdate;
        private Button tblDelete;
        private GroupBox groupstok;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label5;
        private Label kodeBarang;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private GroupBox groupbtnmember;
        private GroupBox groupbtnstok;
        private Button button1;
        private ComboBox cbJenisbarang;
    }
}