namespace hari_hari_switch
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnTampilkan = new Button();
            txtHari = new TextBox();
            txtNoHari = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnTampilkan);
            groupBox1.Controls.Add(txtHari);
            groupBox1.Controls.Add(txtNoHari);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(202, 163);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hari";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 130);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 5;
            label3.Text = "Hari :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 30);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 4;
            label2.Text = "PIlih hari dari 1-7";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 134);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 3;
            // 
            // btnTampilkan
            // 
            btnTampilkan.Location = new Point(0, 82);
            btnTampilkan.Name = "btnTampilkan";
            btnTampilkan.Size = new Size(188, 23);
            btnTampilkan.TabIndex = 2;
            btnTampilkan.Text = "tampilkan hari";
            btnTampilkan.UseVisualStyleBackColor = true;
            btnTampilkan.Click += button1_Click;
            // 
            // txtHari
            // 
            txtHari.Location = new Point(47, 127);
            txtHari.Name = "txtHari";
            txtHari.Size = new Size(139, 23);
            txtHari.TabIndex = 1;
            // 
            // txtNoHari
            // 
            txtNoHari.Location = new Point(108, 30);
            txtNoHari.Name = "txtNoHari";
            txtNoHari.Size = new Size(80, 23);
            txtNoHari.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(224, 180);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnTampilkan;
        private TextBox txtHari;
        private TextBox txtNoHari;
        private Label label3;
        private Label label2;
    }
}
