namespace login_kudus_lagi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtId = new TextBox();
            txtPw = new TextBox();
            label1 = new Label();
            tblLogin = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(351, 163);
            txtId.Multiline = true;
            txtId.Name = "txtId";
            txtId.Size = new Size(95, 23);
            txtId.TabIndex = 0;
            // 
            // txtPw
            // 
            txtPw.Location = new Point(351, 201);
            txtPw.Name = "txtPw";
            txtPw.PasswordChar = '*';
            txtPw.Size = new Size(95, 23);
            txtPw.TabIndex = 1;
            txtPw.TextChanged += txtPw_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Cursor = Cursors.AppStarting;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(355, 67);
            label1.Name = "label1";
            label1.Size = new Size(91, 39);
            label1.TabIndex = 2;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // tblLogin
            // 
            tblLogin.Location = new Point(387, 239);
            tblLogin.Name = "tblLogin";
            tblLogin.Size = new Size(59, 23);
            tblLogin.TabIndex = 3;
            tblLogin.Text = "LOGIN";
            tblLogin.UseVisualStyleBackColor = true;
            tblLogin.Click += tblLogin_Click;
            // 
            // button1
            // 
            button1.Location = new Point(351, 239);
            button1.Name = "button1";
            button1.Size = new Size(43, 23);
            button1.TabIndex = 4;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(375, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 39);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(tblLogin);
            Controls.Add(label1);
            Controls.Add(txtPw);
            Controls.Add(txtId);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtPw;
        private Label label1;
        private Button tblLogin;
        private Button button1;
        private PictureBox pictureBox1;
    }
}
