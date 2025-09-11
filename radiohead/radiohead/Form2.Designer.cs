namespace radiohead
{
    partial class Form2
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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            tblHitung = new Button();
            txtHarga = new TextBox();
            label1 = new Label();
            btnForm1 = new Button();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(240, 80);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(52, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Obat";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(240, 120);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(100, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Check up Gigi";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(240, 159);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(123, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Pemeriksaan mata";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(240, 195);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(100, 19);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Check up LAB";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // tblHitung
            // 
            tblHitung.Location = new Point(240, 220);
            tblHitung.Name = "tblHitung";
            tblHitung.Size = new Size(209, 23);
            tblHitung.TabIndex = 4;
            tblHitung.Text = "Harga biaya kesehatan";
            tblHitung.UseVisualStyleBackColor = true;
            tblHitung.Click += tblHitung_Click;
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(240, 274);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(100, 23);
            txtHarga.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(245, 253);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 6;
            label1.Text = "Total Biaya";
            // 
            // btnForm1
            // 
            btnForm1.Location = new Point(374, 274);
            btnForm1.Name = "btnForm1";
            btnForm1.Size = new Size(75, 23);
            btnForm1.TabIndex = 7;
            btnForm1.Text = "kembali";
            btnForm1.UseVisualStyleBackColor = true;
            btnForm1.Click += btnForm1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnForm1);
            Controls.Add(label1);
            Controls.Add(txtHarga);
            Controls.Add(tblHitung);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Button tblHitung;
        private TextBox txtHarga;
        private Label label1;
        private Button btnForm1;
    }
}