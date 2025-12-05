namespace login_kudus_lagi
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            label2 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            tblHitung = new Button();
            tblClear = new Button();
            txtLuasalas = new TextBox();
            txtTinggi = new TextBox();
            txtHasil = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(213, 27);
            label2.Name = "label2";
            label2.Size = new Size(382, 45);
            label2.TabIndex = 4;
            label2.Text = "LIMAS SEGI EMPAT";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(564, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 141);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(273, 274);
            button1.Name = "button1";
            button1.Size = new Size(60, 50);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tblHitung
            // 
            tblHitung.BackgroundImage = (Image)resources.GetObject("tblHitung.BackgroundImage");
            tblHitung.BackgroundImageLayout = ImageLayout.Stretch;
            tblHitung.Location = new Point(359, 271);
            tblHitung.Name = "tblHitung";
            tblHitung.Size = new Size(75, 57);
            tblHitung.TabIndex = 12;
            tblHitung.UseVisualStyleBackColor = true;
            tblHitung.Click += tblHitung_Click;
            // 
            // tblClear
            // 
            tblClear.BackgroundImage = (Image)resources.GetObject("tblClear.BackgroundImage");
            tblClear.BackgroundImageLayout = ImageLayout.Stretch;
            tblClear.Location = new Point(456, 274);
            tblClear.Name = "tblClear";
            tblClear.Size = new Size(60, 50);
            tblClear.TabIndex = 13;
            tblClear.UseVisualStyleBackColor = true;
            tblClear.Click += tblClear_Click;
            // 
            // txtLuasalas
            // 
            txtLuasalas.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLuasalas.Location = new Point(346, 108);
            txtLuasalas.Name = "txtLuasalas";
            txtLuasalas.Size = new Size(100, 33);
            txtLuasalas.TabIndex = 14;
            // 
            // txtTinggi
            // 
            txtTinggi.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTinggi.Location = new Point(346, 167);
            txtTinggi.Name = "txtTinggi";
            txtTinggi.Size = new Size(100, 33);
            txtTinggi.TabIndex = 15;
            // 
            // txtHasil
            // 
            txtHasil.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHasil.Location = new Point(346, 227);
            txtHasil.Name = "txtHasil";
            txtHasil.Size = new Size(100, 33);
            txtHasil.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(252, 114);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 17;
            label1.Text = "Luas alas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(252, 173);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 18;
            label3.Text = "Tinggi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(252, 233);
            label4.Name = "label4";
            label4.Size = new Size(50, 21);
            label4.TabIndex = 19;
            label4.Text = "Hasil";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtHasil);
            Controls.Add(txtTinggi);
            Controls.Add(txtLuasalas);
            Controls.Add(tblClear);
            Controls.Add(tblHitung);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Name = "Form5";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox pictureBox1;
        private Button button1;
        private Button tblHitung;
        private Button tblClear;
        private TextBox txtLuasalas;
        private TextBox txtTinggi;
        private TextBox txtHasil;
        private Label label1;
        private Label label3;
        private Label label4;
    }
}