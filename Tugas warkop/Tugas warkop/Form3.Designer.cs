namespace Tugas_warkop
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            pictureBox1 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            tblPrint = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(2, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(339, 500);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(74, 11);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(165, 102);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(145, 122);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 17);
            label2.TabIndex = 4;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(59, 40);
            label3.Name = "label3";
            label3.Size = new Size(192, 20);
            label3.TabIndex = 5;
            label3.Text = "Jl. Pejaten Raya, RT.6/RW.6, Pejaten Bar., Ps. Minggu, Kota\r\n Jakarta Selatan, Daerah Khusus Ibukota Jakarta 12510";
            label3.Click += label3_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(36, 60);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(235, 299);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // tblPrint
            // 
            tblPrint.BackgroundImage = (Image)resources.GetObject("tblPrint.BackgroundImage");
            tblPrint.BackgroundImageLayout = ImageLayout.Stretch;
            tblPrint.Location = new Point(277, 170);
            tblPrint.Name = "tblPrint";
            tblPrint.Size = new Size(48, 41);
            tblPrint.TabIndex = 7;
            tblPrint.UseVisualStyleBackColor = true;
            tblPrint.Click += tblPrint_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 411);
            Controls.Add(tblPrint);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ContextMenuStrip contextMenuStrip1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private RichTextBox richTextBox1;
        private Button tblPrint;
    }
}