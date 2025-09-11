namespace ppdb_smk
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
            cbrMinat = new ComboBox();
            txtMatematika = new TextBox();
            txtBahasaInggris = new TextBox();
            txtIPA = new TextBox();
            btnTentukan = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            lblJurusanCocok = new Label();
            btnCLear = new Button();
            SuspendLayout();
            // 
            // cbrMinat
            // 
            cbrMinat.FormattingEnabled = true;
            cbrMinat.Location = new Point(392, 84);
            cbrMinat.Name = "cbrMinat";
            cbrMinat.Size = new Size(123, 23);
            cbrMinat.TabIndex = 0;
            cbrMinat.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtMatematika
            // 
            txtMatematika.Location = new Point(415, 126);
            txtMatematika.Name = "txtMatematika";
            txtMatematika.Size = new Size(100, 23);
            txtMatematika.TabIndex = 1;
            // 
            // txtBahasaInggris
            // 
            txtBahasaInggris.Location = new Point(415, 184);
            txtBahasaInggris.Name = "txtBahasaInggris";
            txtBahasaInggris.Size = new Size(100, 23);
            txtBahasaInggris.TabIndex = 3;
            // 
            // txtIPA
            // 
            txtIPA.Location = new Point(415, 155);
            txtIPA.Name = "txtIPA";
            txtIPA.Size = new Size(100, 23);
            txtIPA.TabIndex = 4;
            // 
            // btnTentukan
            // 
            btnTentukan.Location = new Point(280, 229);
            btnTentukan.Name = "btnTentukan";
            btnTentukan.Size = new Size(235, 23);
            btnTentukan.TabIndex = 5;
            btnTentukan.Text = "button1";
            btnTentukan.UseVisualStyleBackColor = true;
            btnTentukan.Click += btnTentukan_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label1.Location = new Point(280, 125);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 6;
            label1.Text = "Matematika";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.Location = new Point(280, 187);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 7;
            label3.Text = "Bahasa Inggris";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label4.Location = new Point(280, 154);
            label4.Name = "label4";
            label4.Size = new Size(33, 20);
            label4.TabIndex = 8;
            label4.Text = "IPA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.Location = new Point(342, 83);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 9;
            label2.Text = "Minat";
            // 
            // lblJurusanCocok
            // 
            lblJurusanCocok.AutoSize = true;
            lblJurusanCocok.Location = new Point(305, 278);
            lblJurusanCocok.Name = "lblJurusanCocok";
            lblJurusanCocok.Size = new Size(181, 15);
            lblJurusanCocok.TabIndex = 10;
            lblJurusanCocok.Text = "Jurusan yang cocok dengan mu :";
            // 
            // btnCLear
            // 
            btnCLear.Location = new Point(280, 252);
            btnCLear.Name = "btnCLear";
            btnCLear.Size = new Size(235, 23);
            btnCLear.TabIndex = 11;
            btnCLear.Text = "clear";
            btnCLear.UseVisualStyleBackColor = true;
            btnCLear.Click += btnCLear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCLear);
            Controls.Add(lblJurusanCocok);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnTentukan);
            Controls.Add(txtIPA);
            Controls.Add(txtBahasaInggris);
            Controls.Add(txtMatematika);
            Controls.Add(cbrMinat);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbrMinat;
        private TextBox txtMatematika;
        private TextBox txtBahasaInggris;
        private TextBox txtIPA;
        private Button btnTentukan;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label lblJurusanCocok;
        private Button btnCLear;
    }
}
