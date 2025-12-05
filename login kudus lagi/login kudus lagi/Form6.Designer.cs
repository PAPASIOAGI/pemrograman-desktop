namespace login_kudus_lagi
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
            label4 = new Label();
            txtHasil = new TextBox();
            txtJari = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            tbl = new Button();
            tblBack = new Button();
            tblClear = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(248, 208);
            label4.Name = "label4";
            label4.Size = new Size(50, 21);
            label4.TabIndex = 30;
            label4.Text = "Hasil";
            // 
            // txtHasil
            // 
            txtHasil.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHasil.Location = new Point(336, 208);
            txtHasil.Name = "txtHasil";
            txtHasil.Size = new Size(101, 33);
            txtHasil.TabIndex = 27;
            // 
            // txtJari
            // 
            txtJari.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtJari.Location = new Point(336, 132);
            txtJari.Name = "txtJari";
            txtJari.Size = new Size(101, 33);
            txtJari.TabIndex = 26;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(554, 122);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 141);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(336, 21);
            label2.Name = "label2";
            label2.Size = new Size(101, 45);
            label2.TabIndex = 20;
            label2.Text = "Bola";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(248, 138);
            label3.Name = "label3";
            label3.Size = new Size(72, 21);
            label3.TabIndex = 29;
            label3.Text = "Jari-jari";
            // 
            // tbl
            // 
            tbl.BackgroundImage = (Image)resources.GetObject("tbl.BackgroundImage");
            tbl.BackgroundImageLayout = ImageLayout.Stretch;
            tbl.Location = new Point(348, 291);
            tbl.Name = "tbl";
            tbl.Size = new Size(75, 57);
            tbl.TabIndex = 31;
            tbl.UseVisualStyleBackColor = true;
            tbl.Click += button2_Click;
            // 
            // tblBack
            // 
            tblBack.BackgroundImage = (Image)resources.GetObject("tblBack.BackgroundImage");
            tblBack.BackgroundImageLayout = ImageLayout.Stretch;
            tblBack.Location = new Point(260, 291);
            tblBack.Name = "tblBack";
            tblBack.Size = new Size(60, 50);
            tblBack.TabIndex = 32;
            tblBack.UseVisualStyleBackColor = true;
            tblBack.Click += tblBack_Click;
            // 
            // tblClear
            // 
            tblClear.BackgroundImage = (Image)resources.GetObject("tblClear.BackgroundImage");
            tblClear.BackgroundImageLayout = ImageLayout.Stretch;
            tblClear.Location = new Point(452, 291);
            tblClear.Name = "tblClear";
            tblClear.Size = new Size(60, 50);
            tblClear.TabIndex = 33;
            tblClear.UseVisualStyleBackColor = true;
            tblClear.Click += tblClear_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblClear);
            Controls.Add(tblBack);
            Controls.Add(tbl);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtHasil);
            Controls.Add(txtJari);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Name = "Form6";
            Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox txtHasil;
        private TextBox txtJari;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Button tbl;
        private Button tblBack;
        private Button tblClear;
    }
}