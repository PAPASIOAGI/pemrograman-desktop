namespace tampilkan_angka
{
    partial class Form3
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
            CBDadu = new ComboBox();
            btnLemparDadu = new Button();
            listBox1 = new ListBox();
            btnClear = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // CBDadu
            // 
            CBDadu.FormattingEnabled = true;
            CBDadu.Location = new Point(310, 75);
            CBDadu.Name = "CBDadu";
            CBDadu.Size = new Size(176, 23);
            CBDadu.TabIndex = 0;
            // 
            // btnLemparDadu
            // 
            btnLemparDadu.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLemparDadu.Location = new Point(310, 24);
            btnLemparDadu.Name = "btnLemparDadu";
            btnLemparDadu.Size = new Size(176, 45);
            btnLemparDadu.TabIndex = 1;
            btnLemparDadu.Text = "LEMPAR!";
            btnLemparDadu.UseVisualStyleBackColor = true;
            btnLemparDadu.Click += btnLemparDadu_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(310, 108);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(176, 154);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(411, 268);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 3;
            btnClear.Text = "clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // button1
            // 
            button1.Location = new Point(310, 268);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnClear);
            Controls.Add(listBox1);
            Controls.Add(btnLemparDadu);
            Controls.Add(CBDadu);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox CBDadu;
        private Button btnLemparDadu;
        private ListBox listBox1;
        private Button btnClear;
        private Button button1;
    }
}