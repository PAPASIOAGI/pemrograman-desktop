namespace datetime
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
            dtp2 = new DateTimePicker();
            dtp1 = new DateTimePicker();
            txtTampilan = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // dtp2
            // 
            dtp2.Location = new Point(383, 176);
            dtp2.Name = "dtp2";
            dtp2.Size = new Size(200, 23);
            dtp2.TabIndex = 0;
            // 
            // dtp1
            // 
            dtp1.Location = new Point(383, 121);
            dtp1.Name = "dtp1";
            dtp1.Size = new Size(200, 23);
            dtp1.TabIndex = 1;
            // 
            // txtTampilan
            // 
            txtTampilan.Location = new Point(344, 254);
            txtTampilan.Multiline = true;
            txtTampilan.Name = "txtTampilan";
            txtTampilan.Size = new Size(277, 102);
            txtTampilan.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(437, 225);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "TAMPILAN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtTampilan);
            Controls.Add(dtp1);
            Controls.Add(dtp2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtp2;
        private DateTimePicker dtp1;
        private TextBox txtTampilan;
        private Button button1;
    }
}
