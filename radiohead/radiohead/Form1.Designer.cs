namespace radiohead
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
            radio1 = new RadioButton();
            radio2 = new RadioButton();
            radio3 = new RadioButton();
            radio4 = new RadioButton();
            tblHitung = new Button();
            groupBox1 = new GroupBox();
            txtPendaftaran = new TextBox();
            btnForm2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // radio1
            // 
            radio1.AutoSize = true;
            radio1.Location = new Point(45, 32);
            radio1.Name = "radio1";
            radio1.Size = new Size(111, 19);
            radio1.TabIndex = 0;
            radio1.TabStop = true;
            radio1.Text = "Anak <10 Tahun";
            radio1.UseVisualStyleBackColor = true;
            // 
            // radio2
            // 
            radio2.AutoSize = true;
            radio2.Location = new Point(45, 57);
            radio2.Name = "radio2";
            radio2.Size = new Size(132, 19);
            radio2.TabIndex = 1;
            radio2.TabStop = true;
            radio2.Text = "Remaja 10-18 Tahun";
            radio2.UseVisualStyleBackColor = true;
            // 
            // radio3
            // 
            radio3.AutoSize = true;
            radio3.Location = new Point(45, 82);
            radio3.Name = "radio3";
            radio3.Size = new Size(133, 19);
            radio3.TabIndex = 2;
            radio3.TabStop = true;
            radio3.Text = "Dewasa 18-40 Tahun";
            radio3.UseVisualStyleBackColor = true;
            // 
            // radio4
            // 
            radio4.AutoSize = true;
            radio4.Location = new Point(45, 107);
            radio4.Name = "radio4";
            radio4.Size = new Size(117, 19);
            radio4.TabIndex = 3;
            radio4.TabStop = true;
            radio4.Text = "Sepuh >40 Tahun";
            radio4.UseVisualStyleBackColor = true;
            // 
            // tblHitung
            // 
            tblHitung.Location = new Point(451, 176);
            tblHitung.Name = "tblHitung";
            tblHitung.Size = new Size(75, 23);
            tblHitung.TabIndex = 4;
            tblHitung.Text = "HARGA PENDAFTARAN";
            tblHitung.UseVisualStyleBackColor = true;
            tblHitung.Click += tblHitung_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radio3);
            groupBox1.Controls.Add(radio1);
            groupBox1.Controls.Add(radio4);
            groupBox1.Controls.Add(radio2);
            groupBox1.Location = new Point(217, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 166);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txtPendaftaran
            // 
            txtPendaftaran.Location = new Point(451, 217);
            txtPendaftaran.Name = "txtPendaftaran";
            txtPendaftaran.Size = new Size(100, 23);
            txtPendaftaran.TabIndex = 6;
            // 
            // btnForm2
            // 
            btnForm2.Location = new Point(298, 288);
            btnForm2.Name = "btnForm2";
            btnForm2.Size = new Size(119, 23);
            btnForm2.TabIndex = 7;
            btnForm2.Text = "Menurut harga";
            btnForm2.UseVisualStyleBackColor = true;
            btnForm2.Click += btnForm2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnForm2);
            Controls.Add(txtPendaftaran);
            Controls.Add(groupBox1);
            Controls.Add(tblHitung);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radio1;
        private RadioButton radio2;
        private RadioButton radio3;
        private RadioButton radio4;
        private Button tblHitung;
        private GroupBox groupBox1;
        private TextBox txtPendaftaran;
        private Button btnForm2;
    }
}
