namespace kereta_argo_ngawi_gejes_gejes
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tblPemesanan = new Button();
            txtKodebook = new TextBox();
            groupCek = new GroupBox();
            tblCek = new Button();
            label2 = new Label();
            label1 = new Label();
            txtNIK = new TextBox();
            pictureKereta1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            groupCek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureKereta1).BeginInit();
            SuspendLayout();
            // 
            // tblPemesanan
            // 
            tblPemesanan.BackgroundImage = (Image)resources.GetObject("tblPemesanan.BackgroundImage");
            tblPemesanan.BackgroundImageLayout = ImageLayout.Stretch;
            tblPemesanan.Location = new Point(293, 199);
            tblPemesanan.Name = "tblPemesanan";
            tblPemesanan.Size = new Size(210, 52);
            tblPemesanan.TabIndex = 2;
            tblPemesanan.UseVisualStyleBackColor = true;
            tblPemesanan.Click += tblPemesanan_Click;
            // 
            // txtKodebook
            // 
            txtKodebook.Location = new Point(94, 12);
            txtKodebook.Name = "txtKodebook";
            txtKodebook.Size = new Size(100, 23);
            txtKodebook.TabIndex = 4;
            // 
            // groupCek
            // 
            groupCek.BackColor = Color.Transparent;
            groupCek.Controls.Add(tblCek);
            groupCek.Controls.Add(label2);
            groupCek.Controls.Add(label1);
            groupCek.Controls.Add(txtNIK);
            groupCek.Controls.Add(txtKodebook);
            groupCek.Location = new Point(558, 161);
            groupCek.Name = "groupCek";
            groupCek.Size = new Size(200, 100);
            groupCek.TabIndex = 5;
            groupCek.TabStop = false;
            groupCek.Enter += groupCek_Enter;
            // 
            // tblCek
            // 
            tblCek.Location = new Point(54, 70);
            tblCek.Name = "tblCek";
            tblCek.Size = new Size(75, 23);
            tblCek.TabIndex = 8;
            tblCek.Text = "cek";
            tblCek.UseVisualStyleBackColor = true;
            tblCek.Click += tblCek_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 44);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 7;
            label2.Text = "No. NIK";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 12);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 6;
            label1.Text = "Kode booking";
            // 
            // txtNIK
            // 
            txtNIK.BackColor = Color.White;
            txtNIK.Location = new Point(94, 41);
            txtNIK.Name = "txtNIK";
            txtNIK.Size = new Size(100, 23);
            txtNIK.TabIndex = 5;
            // 
            // pictureKereta1
            // 
            pictureKereta1.BackColor = Color.Transparent;
            pictureKereta1.BackgroundImage = (Image)resources.GetObject("pictureKereta1.BackgroundImage");
            pictureKereta1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureKereta1.Location = new Point(-1097, 353);
            pictureKereta1.Name = "pictureKereta1";
            pictureKereta1.Size = new Size(1346, 61);
            pictureKereta1.TabIndex = 6;
            pictureKereta1.TabStop = false;
            pictureKereta1.Click += pictureKereta1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureKereta1);
            Controls.Add(groupCek);
            Controls.Add(tblPemesanan);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupCek.ResumeLayout(false);
            groupCek.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureKereta1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button tblPemesanan;
        private TextBox txtKodebook;
        private GroupBox groupCek;
        private TextBox txtNIK;
        private Button tblCek;
        private Label label2;
        private Label label1;
        private PictureBox pictureKereta1;
        private System.Windows.Forms.Timer timer1;
    }
}
