namespace Luas_suki_swicth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtSeleksiBangun = new TextBox();
            txtRadius = new TextBox();
            txtTinggi = new TextBox();
            txtLebar = new TextBox();
            txtPanjang = new TextBox();
            btnHitung = new Button();
            txtLuasBangun = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // txtSeleksiBangun
            // 
            txtSeleksiBangun.Location = new Point(143, 25);
            txtSeleksiBangun.Name = "txtSeleksiBangun";
            txtSeleksiBangun.Size = new Size(100, 23);
            txtSeleksiBangun.TabIndex = 0;
            // 
            // txtRadius
            // 
            txtRadius.Location = new Point(66, 94);
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(100, 23);
            txtRadius.TabIndex = 1;
            // 
            // txtTinggi
            // 
            txtTinggi.Location = new Point(66, 142);
            txtTinggi.Name = "txtTinggi";
            txtTinggi.Size = new Size(100, 23);
            txtTinggi.TabIndex = 2;
            // 
            // txtLebar
            // 
            txtLebar.Location = new Point(231, 142);
            txtLebar.Name = "txtLebar";
            txtLebar.Size = new Size(100, 23);
            txtLebar.TabIndex = 3;
            // 
            // txtPanjang
            // 
            txtPanjang.Location = new Point(231, 94);
            txtPanjang.Name = "txtPanjang";
            txtPanjang.Size = new Size(100, 23);
            txtPanjang.TabIndex = 4;
            // 
            // btnHitung
            // 
            btnHitung.BackgroundImage = (Image)resources.GetObject("btnHitung.BackgroundImage");
            btnHitung.BackgroundImageLayout = ImageLayout.Stretch;
            btnHitung.Location = new Point(210, 182);
            btnHitung.Name = "btnHitung";
            btnHitung.Size = new Size(45, 37);
            btnHitung.TabIndex = 5;
            btnHitung.UseVisualStyleBackColor = true;
            btnHitung.Click += btnHitung_Click;
            // 
            // txtLuasBangun
            // 
            txtLuasBangun.Location = new Point(123, 196);
            txtLuasBangun.Name = "txtLuasBangun";
            txtLuasBangun.Size = new Size(88, 23);
            txtLuasBangun.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(141, 10);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 7;
            label1.Text = "Pilih bangun datar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 60);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 8;
            label2.Text = "1.Lingkaran";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(234, 60);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 9;
            label3.Text = "3.Layang-Layang";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(142, 60);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 10;
            label4.Text = "2.Jajar Genjang";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(175, 102);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 11;
            label5.Text = "Panjang";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(18, 142);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 12;
            label6.Text = "Tinggi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(192, 145);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 13;
            label7.Text = "Lebar";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(18, 97);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 14;
            label8.Text = "Radius";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(123, 182);
            label9.Name = "label9";
            label9.Size = new Size(88, 15);
            label9.TabIndex = 15;
            label9.Text = "Luas bangunan";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(377, 268);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLuasBangun);
            Controls.Add(btnHitung);
            Controls.Add(txtPanjang);
            Controls.Add(txtLebar);
            Controls.Add(txtTinggi);
            Controls.Add(txtRadius);
            Controls.Add(txtSeleksiBangun);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSeleksiBangun;
        private TextBox txtRadius;
        private TextBox txtTinggi;
        private TextBox txtLebar;
        private TextBox txtPanjang;
        private Button btnHitung;
        private TextBox txtLuasBangun;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}
