namespace login_untuk_hitung_kudus
{
    partial class Kubus
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
            tblKubus = new Button();
            SuspendLayout();
            // 
            // tblKubus
            // 
            tblKubus.Location = new Point(387, 90);
            tblKubus.Name = "tblKubus";
            tblKubus.Size = new Size(75, 23);
            tblKubus.TabIndex = 0;
            tblKubus.Text = "Kubus";
            tblKubus.UseVisualStyleBackColor = true;
            tblKubus.Click += tblKubus_Click;
            // 
            // Kubus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblKubus);
            Name = "Kubus";
            Text = "Kubus";
            ResumeLayout(false);
        }

        #endregion

        private Button tblKubus;
    }
}