namespace latihan_loop_while
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            btnConversi = new Button();
            label4 = new Label();
            label3 = new Label();
            txtOktal = new TextBox();
            txtHeksa = new TextBox();
            label2 = new Label();
            txtBiner = new TextBox();
            label1 = new Label();
            txtDesimal = new TextBox();
            listBox1 = new ListBox();
            button1 = new Button();
            label5 = new Label();
            btnClear = new Button();
            SuspendLayout();
            // 
            // btnConversi
            // 
            btnConversi.BackgroundImage = (Image)resources.GetObject("btnConversi.BackgroundImage");
            btnConversi.BackgroundImageLayout = ImageLayout.Stretch;
            btnConversi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConversi.Location = new Point(35, 236);
            btnConversi.Name = "btnConversi";
            btnConversi.Size = new Size(93, 35);
            btnConversi.TabIndex = 21;
            btnConversi.UseVisualStyleBackColor = true;
            btnConversi.Click += btnConversi_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(2, 156);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 20;
            label4.Text = "Oktal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(2, 181);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 19;
            label3.Text = "Heksidesimal";
            // 
            // txtOktal
            // 
            txtOktal.Location = new Point(103, 156);
            txtOktal.Name = "txtOktal";
            txtOktal.Size = new Size(100, 23);
            txtOktal.TabIndex = 18;
            txtOktal.TextChanged += txtOktal_TextChanged;
            // 
            // txtHeksa
            // 
            txtHeksa.Location = new Point(103, 181);
            txtHeksa.Name = "txtHeksa";
            txtHeksa.Size = new Size(100, 23);
            txtHeksa.TabIndex = 17;
            txtHeksa.TextChanged += txtHeksa_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(2, 131);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 16;
            label2.Text = "Biner";
            // 
            // txtBiner
            // 
            txtBiner.Location = new Point(103, 131);
            txtBiner.Name = "txtBiner";
            txtBiner.Size = new Size(100, 23);
            txtBiner.TabIndex = 15;
            txtBiner.TextChanged += txtBiner_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(2, 84);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 14;
            label1.Text = "Angka desimal";
            // 
            // txtDesimal
            // 
            txtDesimal.Location = new Point(103, 81);
            txtDesimal.Name = "txtDesimal";
            txtDesimal.Size = new Size(100, 23);
            txtDesimal.TabIndex = 13;
            txtDesimal.TextChanged += txtDesimal_TextChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(219, 58);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(266, 274);
            listBox1.TabIndex = 22;
            // 
            // button1
            // 
            button1.Location = new Point(-8, 340);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 23;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(145, 9);
            label5.Name = "label5";
            label5.Size = new Size(209, 32);
            label5.TabIndex = 24;
            label5.Text = "Biner convertion";
            // 
            // btnClear
            // 
            btnClear.BackgroundImage = (Image)resources.GetObject("btnClear.BackgroundImage");
            btnClear.BackgroundImageLayout = ImageLayout.Stretch;
            btnClear.Location = new Point(134, 236);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 51);
            btnClear.TabIndex = 25;
            btnClear.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(501, 359);
            Controls.Add(btnClear);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(btnConversi);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtOktal);
            Controls.Add(txtHeksa);
            Controls.Add(label2);
            Controls.Add(txtBiner);
            Controls.Add(label1);
            Controls.Add(txtDesimal);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConversi;
        private Label label4;
        private Label label3;
        private TextBox txtOktal;
        private TextBox txtHeksa;
        private Label label2;
        private TextBox txtBiner;
        private Label label1;
        private TextBox txtDesimal;
        private ListBox listBox1;
        private Button button1;
        private Label label5;
        private Button btnClear;
    }
}