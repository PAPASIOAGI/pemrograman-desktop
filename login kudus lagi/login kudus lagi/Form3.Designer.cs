namespace login_kudus_lagi
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
            button1 = new Button();
            txtSisi = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            txtHasil = new TextBox();
            label3 = new Label();
            tblHitung = new Button();
            tblClear = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(297, 253);
            button1.Name = "button1";
            button1.Size = new Size(60, 50);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtSisi
            // 
            txtSisi.Location = new Point(363, 121);
            txtSisi.Name = "txtSisi";
            txtSisi.Size = new Size(100, 23);
            txtSisi.TabIndex = 1;
            txtSisi.TextChanged += txtSisi_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(320, 123);
            label1.Name = "label1";
            label1.Size = new Size(37, 21);
            label1.TabIndex = 2;
            label1.Text = "Sisi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(333, 27);
            label2.Name = "label2";
            label2.Size = new Size(148, 45);
            label2.TabIndex = 3;
            label2.Text = "KUBUS";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(564, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 161);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // txtHasil
            // 
            txtHasil.Location = new Point(363, 169);
            txtHasil.Name = "txtHasil";
            txtHasil.Size = new Size(100, 23);
            txtHasil.TabIndex = 5;
            txtHasil.TextChanged += txtHasil_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(307, 167);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 6;
            label3.Text = "Hasil";
            // 
            // tblHitung
            // 
            tblHitung.BackgroundImage = (Image)resources.GetObject("tblHitung.BackgroundImage");
            tblHitung.BackgroundImageLayout = ImageLayout.Stretch;
            tblHitung.Location = new Point(363, 250);
            tblHitung.Name = "tblHitung";
            tblHitung.Size = new Size(75, 57);
            tblHitung.TabIndex = 7;
            tblHitung.UseVisualStyleBackColor = true;
            tblHitung.Click += button2_Click;
            // 
            // tblClear
            // 
            tblClear.BackgroundImage = (Image)resources.GetObject("tblClear.BackgroundImage");
            tblClear.BackgroundImageLayout = ImageLayout.Stretch;
            tblClear.Location = new Point(454, 250);
            tblClear.Name = "tblClear";
            tblClear.Size = new Size(60, 50);
            tblClear.TabIndex = 8;
            tblClear.UseVisualStyleBackColor = true;
            tblClear.Click += tblClear_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblClear);
            Controls.Add(tblHitung);
            Controls.Add(label3);
            Controls.Add(txtHasil);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSisi);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtSisi;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox txtHasil;
        private Label label3;
        private Button tblHitung;
        private Button tblClear;
    }
}