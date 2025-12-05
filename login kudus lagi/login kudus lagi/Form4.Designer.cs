namespace login_kudus_lagi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            label2 = new Label();
            pictureBox1 = new PictureBox();
            txtPanjang = new TextBox();
            txtLebar = new TextBox();
            txtTinggi = new TextBox();
            tblHitung = new Button();
            button1 = new Button();
            tblClear = new Button();
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
            label2.Location = new Point(329, 23);
            label2.Name = "label2";
            label2.Size = new Size(145, 45);
            label2.TabIndex = 4;
            label2.Text = "BALOK";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(540, 111);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 149);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // txtPanjang
            // 
            txtPanjang.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPanjang.Location = new Point(348, 111);
            txtPanjang.Name = "txtPanjang";
            txtPanjang.Size = new Size(100, 33);
            txtPanjang.TabIndex = 6;
            // 
            // txtLebar
            // 
            txtLebar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLebar.Location = new Point(348, 168);
            txtLebar.Name = "txtLebar";
            txtLebar.Size = new Size(100, 33);
            txtLebar.TabIndex = 7;
            // 
            // txtTinggi
            // 
            txtTinggi.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTinggi.Location = new Point(348, 225);
            txtTinggi.Name = "txtTinggi";
            txtTinggi.Size = new Size(100, 35);
            txtTinggi.TabIndex = 8;
            // 
            // tblHitung
            // 
            tblHitung.BackgroundImage = (Image)resources.GetObject("tblHitung.BackgroundImage");
            tblHitung.BackgroundImageLayout = ImageLayout.Stretch;
            tblHitung.Location = new Point(362, 287);
            tblHitung.Name = "tblHitung";
            tblHitung.Size = new Size(75, 57);
            tblHitung.TabIndex = 9;
            tblHitung.UseVisualStyleBackColor = true;
            tblHitung.Click += tblHitung_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(287, 287);
            button1.Name = "button1";
            button1.Size = new Size(60, 50);
            button1.TabIndex = 10;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tblClear
            // 
            tblClear.BackgroundImage = (Image)resources.GetObject("tblClear.BackgroundImage");
            tblClear.BackgroundImageLayout = ImageLayout.Stretch;
            tblClear.Location = new Point(453, 287);
            tblClear.Name = "tblClear";
            tblClear.Size = new Size(60, 50);
            tblClear.TabIndex = 11;
            tblClear.UseVisualStyleBackColor = true;
            tblClear.Click += tblClear_Click;
            // 
            // txtHasil
            // 
            txtHasil.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtHasil.Location = new Point(540, 254);
            txtHasil.Name = "txtHasil";
            txtHasil.Size = new Size(248, 39);
            txtHasil.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(269, 117);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 13;
            label1.Text = "Panjang";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(269, 168);
            label3.Name = "label3";
            label3.Size = new Size(54, 21);
            label3.TabIndex = 14;
            label3.Text = "Lebar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(269, 235);
            label4.Name = "label4";
            label4.Size = new Size(60, 21);
            label4.TabIndex = 15;
            label4.Text = "Tinggi";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtHasil);
            Controls.Add(tblClear);
            Controls.Add(button1);
            Controls.Add(tblHitung);
            Controls.Add(txtTinggi);
            Controls.Add(txtLebar);
            Controls.Add(txtPanjang);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox pictureBox1;
        private TextBox txtPanjang;
        private TextBox txtLebar;
        private TextBox txtTinggi;
        private Button tblHitung;
        private Button button1;
        private Button tblClear;
        private TextBox txtHasil;
        private Label label1;
        private Label label3;
        private Label label4;
    }
}