namespace volume_kududs
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
            groupBox1 = new GroupBox();
            tblHitung = new Button();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtVolume = new TextBox();
            txtPanjang = new TextBox();
            txtTinggi = new TextBox();
            txtLebar = new TextBox();
            tblClear = new Button();
            tblClose = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tblClose);
            groupBox1.Controls.Add(tblClear);
            groupBox1.Controls.Add(tblHitung);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtVolume);
            groupBox1.Controls.Add(txtPanjang);
            groupBox1.Controls.Add(txtTinggi);
            groupBox1.Controls.Add(txtLebar);
            groupBox1.Location = new Point(327, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(254, 256);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Volume kudus";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // tblHitung
            // 
            tblHitung.Location = new Point(21, 213);
            tblHitung.Name = "tblHitung";
            tblHitung.Size = new Size(55, 23);
            tblHitung.TabIndex = 9;
            tblHitung.Text = "Hitung";
            tblHitung.UseVisualStyleBackColor = true;
            tblHitung.Click += tblHitung_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 128);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 7;
            label3.Text = "lebar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 167);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 8;
            label4.Text = "Volume";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 85);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 6;
            label2.Text = "Tinggi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 40);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 5;
            label1.Text = "Panjang ";
            // 
            // txtVolume
            // 
            txtVolume.Location = new Point(110, 167);
            txtVolume.Name = "txtVolume";
            txtVolume.Size = new Size(100, 23);
            txtVolume.TabIndex = 4;
            // 
            // txtPanjang
            // 
            txtPanjang.Location = new Point(110, 37);
            txtPanjang.Name = "txtPanjang";
            txtPanjang.Size = new Size(100, 23);
            txtPanjang.TabIndex = 1;
            txtPanjang.TextChanged += txtPanjang_TextChanged;
            // 
            // txtTinggi
            // 
            txtTinggi.Location = new Point(110, 125);
            txtTinggi.Name = "txtTinggi";
            txtTinggi.Size = new Size(100, 23);
            txtTinggi.TabIndex = 3;
            // 
            // txtLebar
            // 
            txtLebar.Location = new Point(110, 82);
            txtLebar.Name = "txtLebar";
            txtLebar.Size = new Size(100, 23);
            txtLebar.TabIndex = 2;
            // 
            // tblClear
            // 
            tblClear.Location = new Point(93, 213);
            tblClear.Name = "tblClear";
            tblClear.Size = new Size(42, 23);
            tblClear.TabIndex = 10;
            tblClear.Text = "Clear";
            tblClear.UseVisualStyleBackColor = true;
            tblClear.Click += button1_Click;
            // 
            // tblClose
            // 
            tblClose.Location = new Point(159, 213);
            tblClose.Name = "tblClose";
            tblClose.Size = new Size(75, 23);
            tblClose.TabIndex = 11;
            tblClose.Text = "Close";
            tblClose.UseVisualStyleBackColor = true;
            tblClose.Click += tblClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtPanjang;
        private TextBox txtLebar;
        private TextBox txtTinggi;
        private TextBox txtVolume;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button tblHitung;
        private Button tblClear;
        private Button tblClose;
    }
}
