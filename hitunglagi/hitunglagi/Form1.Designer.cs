namespace hitunglagi
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
            Operasi = new ComboBox();
            tblHitung = new Button();
            txtAngka1 = new TextBox();
            txtAngka2 = new TextBox();
            txtHasil = new TextBox();
            tblClose = new Button();
            label1 = new Label();
            tblClear = new Button();
            SuspendLayout();
            // 
            // Operasi
            // 
            Operasi.FormattingEnabled = true;
            Operasi.Location = new Point(314, 154);
            Operasi.Name = "Operasi";
            Operasi.Size = new Size(53, 23);
            Operasi.TabIndex = 1;
            // 
            // tblHitung
            // 
            tblHitung.Location = new Point(272, 196);
            tblHitung.Name = "tblHitung";
            tblHitung.Size = new Size(75, 23);
            tblHitung.TabIndex = 3;
            tblHitung.Text = "button1";
            tblHitung.UseVisualStyleBackColor = true;
            // 
            // txtAngka1
            // 
            txtAngka1.Location = new Point(192, 154);
            txtAngka1.Name = "txtAngka1";
            txtAngka1.Size = new Size(100, 23);
            txtAngka1.TabIndex = 4;
            // 
            // txtAngka2
            // 
            txtAngka2.Location = new Point(383, 154);
            txtAngka2.Name = "txtAngka2";
            txtAngka2.Size = new Size(100, 23);
            txtAngka2.TabIndex = 5;
            // 
            // txtHasil
            // 
            txtHasil.Location = new Point(516, 154);
            txtHasil.Name = "txtHasil";
            txtHasil.Size = new Size(100, 23);
            txtHasil.TabIndex = 6;
            // 
            // tblClose
            // 
            tblClose.Location = new Point(373, 196);
            tblClose.Name = "tblClose";
            tblClose.Size = new Size(75, 23);
            tblClose.TabIndex = 7;
            tblClose.Text = "close";
            tblClose.UseVisualStyleBackColor = true;
            tblClose.Click += tblClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(489, 157);
            label1.Name = "label1";
            label1.Size = new Size(15, 15);
            label1.TabIndex = 8;
            label1.Text = "=";
            // 
            // tblClear
            // 
            tblClear.Location = new Point(470, 196);
            tblClear.Name = "tblClear";
            tblClear.Size = new Size(75, 23);
            tblClear.TabIndex = 9;
            tblClear.Text = "reset";
            tblClear.UseVisualStyleBackColor = true;
            tblClear.Click += tblClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblClear);
            Controls.Add(label1);
            Controls.Add(tblClose);
            Controls.Add(txtHasil);
            Controls.Add(txtAngka2);
            Controls.Add(txtAngka1);
            Controls.Add(tblHitung);
            Controls.Add(Operasi);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox Operasi;
        private Button tblHitung;
        private TextBox txtAngka1;
        private TextBox txtAngka2;
        private TextBox txtHasil;
        private Button tblClose;
        private Label label1;
        private Button tblClear;
    }
}
