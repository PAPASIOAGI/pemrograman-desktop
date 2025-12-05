namespace latihan_loop_while
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            btnGenerate = new Button();
            listBox1 = new ListBox();
            txtJumlah = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtSatu = new TextBox();
            txtDua = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnClear = new Button();
            back = new Button();
            SuspendLayout();
            // 
            // btnGenerate
            // 
            btnGenerate.BackgroundImage = (Image)resources.GetObject("btnGenerate.BackgroundImage");
            btnGenerate.BackgroundImageLayout = ImageLayout.Stretch;
            btnGenerate.Location = new Point(12, 205);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(121, 45);
            btnGenerate.TabIndex = 0;
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(228, 63);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(181, 259);
            listBox1.TabIndex = 1;
            // 
            // txtJumlah
            // 
            txtJumlah.Location = new Point(110, 154);
            txtJumlah.Name = "txtJumlah";
            txtJumlah.Size = new Size(100, 23);
            txtJumlah.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(68, 9);
            label1.Name = "label1";
            label1.Size = new Size(191, 32);
            label1.TabIndex = 3;
            label1.Text = "Deret fibonacci";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 154);
            label2.Name = "label2";
            label2.Size = new Size(109, 32);
            label2.TabIndex = 4;
            label2.Text = "Masukan jumlah\r\n Fibonacci\r\n";
            label2.Click += label2_Click;
            // 
            // txtSatu
            // 
            txtSatu.Location = new Point(110, 63);
            txtSatu.Name = "txtSatu";
            txtSatu.Size = new Size(100, 23);
            txtSatu.TabIndex = 5;
            // 
            // txtDua
            // 
            txtDua.Location = new Point(110, 106);
            txtDua.Name = "txtDua";
            txtDua.Size = new Size(100, 23);
            txtDua.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 65);
            label3.Name = "label3";
            label3.Size = new Size(101, 16);
            label3.TabIndex = 7;
            label3.Text = "Angka Pertama";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 106);
            label4.Name = "label4";
            label4.Size = new Size(88, 16);
            label4.TabIndex = 8;
            label4.Text = "Angka Kedua";
            // 
            // btnClear
            // 
            btnClear.BackgroundImage = (Image)resources.GetObject("btnClear.BackgroundImage");
            btnClear.BackgroundImageLayout = ImageLayout.Stretch;
            btnClear.Location = new Point(145, 205);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(65, 45);
            btnClear.TabIndex = 9;
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // back
            // 
            back.Location = new Point(-7, 338);
            back.Name = "back";
            back.Size = new Size(75, 23);
            back.TabIndex = 10;
            back.Text = "BACK";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(421, 357);
            Controls.Add(back);
            Controls.Add(btnClear);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtDua);
            Controls.Add(txtSatu);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtJumlah);
            Controls.Add(listBox1);
            Controls.Add(btnGenerate);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerate;
        private ListBox listBox1;
        private TextBox txtJumlah;
        private Label label1;
        private Label label2;
        private TextBox txtSatu;
        private TextBox txtDua;
        private Label label3;
        private Label label4;
        private Button btnClear;
        private Button back;
    }
}