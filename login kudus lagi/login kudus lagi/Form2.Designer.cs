namespace login_kudus_lagi
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
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            tblClose = new Button();
            tblLingkaran = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(121, 80);
            button1.Name = "button1";
            button1.Size = new Size(122, 116);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(121, 24);
            label1.Name = "label1";
            label1.Size = new Size(568, 32);
            label1.TabIndex = 1;
            label1.Text = "PILIH BANGUN RUANG YANG INGIN DI HITUNG";
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(326, 80);
            button2.Name = "button2";
            button2.Size = new Size(168, 116);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(563, 80);
            button3.Name = "button3";
            button3.Size = new Size(126, 116);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tblClose
            // 
            tblClose.BackgroundImage = (Image)resources.GetObject("tblClose.BackgroundImage");
            tblClose.BackgroundImageLayout = ImageLayout.Stretch;
            tblClose.Location = new Point(386, 349);
            tblClose.Name = "tblClose";
            tblClose.Size = new Size(50, 40);
            tblClose.TabIndex = 4;
            tblClose.UseVisualStyleBackColor = true;
            tblClose.Click += button4_Click;
            // 
            // tblLingkaran
            // 
            tblLingkaran.BackgroundImage = (Image)resources.GetObject("tblLingkaran.BackgroundImage");
            tblLingkaran.BackgroundImageLayout = ImageLayout.Stretch;
            tblLingkaran.Location = new Point(346, 218);
            tblLingkaran.Name = "tblLingkaran";
            tblLingkaran.Size = new Size(126, 116);
            tblLingkaran.TabIndex = 5;
            tblLingkaran.UseVisualStyleBackColor = true;
            tblLingkaran.Click += tblLingkaran_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblLingkaran);
            Controls.Add(tblClose);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button tblClose;
        private Button tblLingkaran;
    }
}