namespace tampilkan_angka
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
            btnKalkulator = new Button();
            btnGambling = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnKalkulator
            // 
            btnKalkulator.BackgroundImage = (Image)resources.GetObject("btnKalkulator.BackgroundImage");
            btnKalkulator.BackgroundImageLayout = ImageLayout.Stretch;
            btnKalkulator.Location = new Point(138, 132);
            btnKalkulator.Name = "btnKalkulator";
            btnKalkulator.Size = new Size(97, 89);
            btnKalkulator.TabIndex = 0;
            btnKalkulator.UseVisualStyleBackColor = true;
            btnKalkulator.Click += btnKalkulator_Click;
            // 
            // btnGambling
            // 
            btnGambling.BackgroundImage = (Image)resources.GetObject("btnGambling.BackgroundImage");
            btnGambling.BackgroundImageLayout = ImageLayout.Stretch;
            btnGambling.Location = new Point(260, 132);
            btnGambling.Name = "btnGambling";
            btnGambling.Size = new Size(97, 89);
            btnGambling.TabIndex = 1;
            btnGambling.UseVisualStyleBackColor = true;
            btnGambling.Click += btnGambling_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(394, 132);
            button3.Name = "button3";
            button3.Size = new Size(97, 89);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Location = new Point(534, 132);
            button4.Name = "button4";
            button4.Size = new Size(97, 89);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(330, 67);
            label1.Name = "label1";
            label1.Size = new Size(107, 26);
            label1.TabIndex = 4;
            label1.Text = "HITUNG";
            // 
            // button1
            // 
            button1.Location = new Point(362, 246);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnGambling);
            Controls.Add(btnKalkulator);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKalkulator;
        private Button btnGambling;
        private Button button3;
        private Button button4;
        private Label label1;
        private Button button1;
    }
}