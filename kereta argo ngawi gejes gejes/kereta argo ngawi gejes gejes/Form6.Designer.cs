namespace kereta_argo_ngawi_gejes_gejes
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            Nama = new Label();
            kereta = new Label();
            NoKursi = new Label();
            Kelas = new Label();
            NamaKereta = new Label();
            Tanggal = new Label();
            groupBoarding = new GroupBox();
            groupBoarding.SuspendLayout();
            SuspendLayout();
            // 
            // Nama
            // 
            Nama.AutoSize = true;
            Nama.Location = new Point(43, 80);
            Nama.Name = "Nama";
            Nama.Size = new Size(38, 15);
            Nama.TabIndex = 1;
            Nama.Text = "label1";
            
            // 
            // kereta
            // 
            kereta.AutoSize = true;
            kereta.Location = new Point(43, 118);
            kereta.Name = "kereta";
            kereta.Size = new Size(38, 15);
            kereta.TabIndex = 2;
            kereta.Text = "label1";
            // 
            // NoKursi
            // 
            NoKursi.AutoSize = true;
            NoKursi.Location = new Point(208, 171);
            NoKursi.Name = "NoKursi";
            NoKursi.Size = new Size(38, 15);
            NoKursi.TabIndex = 3;
            NoKursi.Text = "label1";
            // 
            // Kelas
            // 
            Kelas.AutoSize = true;
            Kelas.Location = new Point(208, 118);
            Kelas.Name = "Kelas";
            Kelas.Size = new Size(38, 15);
            Kelas.TabIndex = 4;
            Kelas.Text = "label1";
            // 
            // NamaKereta
            // 
            NamaKereta.AutoSize = true;
            NamaKereta.Location = new Point(43, 171);
            NamaKereta.Name = "NamaKereta";
            NamaKereta.Size = new Size(38, 15);
            NamaKereta.TabIndex = 5;
            NamaKereta.Text = "label1";
            // 
            // Tanggal
            // 
            Tanggal.AutoSize = true;
            Tanggal.Location = new Point(43, 216);
            Tanggal.Name = "Tanggal";
            Tanggal.Size = new Size(38, 15);
            Tanggal.TabIndex = 6;
            Tanggal.Text = "label1";
            // 
            // groupBoarding
            // 
            groupBoarding.BackgroundImage = (Image)resources.GetObject("groupBoarding.BackgroundImage");
            groupBoarding.BackgroundImageLayout = ImageLayout.Stretch;
            groupBoarding.Controls.Add(Nama);
            groupBoarding.Controls.Add(NoKursi);
            groupBoarding.Controls.Add(Kelas);
            groupBoarding.Controls.Add(Tanggal);
            groupBoarding.Controls.Add(kereta);
            groupBoarding.Controls.Add(NamaKereta);
            groupBoarding.Location = new Point(129, 37);
            groupBoarding.Name = "groupBoarding";
            groupBoarding.Size = new Size(516, 297);
            groupBoarding.TabIndex = 7;
            groupBoarding.TabStop = false;
            groupBoarding.Text = "groupBox1";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoarding);
            Name = "Form6";
            Text = "Form6";
            groupBoarding.ResumeLayout(false);
            groupBoarding.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label Nama;
        private Label kereta;
        private Label NoKursi;
        private Label Kelas;
        private Label NamaKereta;
        private Label Tanggal;
        private GroupBox groupBoarding;
    }
}