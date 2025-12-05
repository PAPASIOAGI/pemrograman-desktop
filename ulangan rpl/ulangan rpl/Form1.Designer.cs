namespace ulangan_rpl
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
            dataview = new DataGridView();
            txtID = new TextBox();
            txtNAMA = new TextBox();
            txtJABATAN = new TextBox();
            label1 = new Label();
            groupBox = new GroupBox();
            btnHAPUS = new Button();
            btnUPDATE = new Button();
            btnTAMBAH = new Button();
            label6 = new Label();
            label4 = new Label();
            txtGAJI = new TextBox();
            txtWAKTU = new TextBox();
            label5 = new Label();
            label3 = new Label();
            txtLEMBUR = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataview).BeginInit();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // dataview
            // 
            dataview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataview.Location = new Point(393, 62);
            dataview.Name = "dataview";
            dataview.Size = new Size(378, 305);
            dataview.TabIndex = 0;
            dataview.CellContentClick += dataview_CellContentClick;
            // 
            // txtID
            // 
            txtID.Location = new Point(15, 37);
            txtID.Name = "txtID";
            txtID.Size = new Size(79, 23);
            txtID.TabIndex = 1;
            // 
            // txtNAMA
            // 
            txtNAMA.Location = new Point(169, 37);
            txtNAMA.Name = "txtNAMA";
            txtNAMA.Size = new Size(162, 23);
            txtNAMA.TabIndex = 2;
            // 
            // txtJABATAN
            // 
            txtJABATAN.Location = new Point(15, 97);
            txtJABATAN.Name = "txtJABATAN";
            txtJABATAN.Size = new Size(153, 23);
            txtJABATAN.TabIndex = 3;
            txtJABATAN.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 19);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 4;
            label1.Text = "ID";
            // 
            // groupBox
            // 
            groupBox.Controls.Add(btnHAPUS);
            groupBox.Controls.Add(btnUPDATE);
            groupBox.Controls.Add(btnTAMBAH);
            groupBox.Controls.Add(label6);
            groupBox.Controls.Add(label4);
            groupBox.Controls.Add(txtGAJI);
            groupBox.Controls.Add(txtWAKTU);
            groupBox.Controls.Add(label5);
            groupBox.Controls.Add(label3);
            groupBox.Controls.Add(txtLEMBUR);
            groupBox.Controls.Add(label2);
            groupBox.Controls.Add(txtJABATAN);
            groupBox.Controls.Add(label1);
            groupBox.Controls.Add(txtNAMA);
            groupBox.Controls.Add(txtID);
            groupBox.Location = new Point(1, 50);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(386, 317);
            groupBox.TabIndex = 5;
            groupBox.TabStop = false;
            groupBox.Enter += groupBox1_Enter;
            // 
            // btnHAPUS
            // 
            btnHAPUS.BackColor = Color.IndianRed;
            btnHAPUS.Location = new Point(232, 256);
            btnHAPUS.Name = "btnHAPUS";
            btnHAPUS.Size = new Size(75, 23);
            btnHAPUS.TabIndex = 15;
            btnHAPUS.Text = "Hapus";
            btnHAPUS.UseVisualStyleBackColor = false;
            btnHAPUS.Click += btnHAPUS_Click;
            // 
            // btnUPDATE
            // 
            btnUPDATE.Location = new Point(137, 256);
            btnUPDATE.Name = "btnUPDATE";
            btnUPDATE.Size = new Size(75, 23);
            btnUPDATE.TabIndex = 14;
            btnUPDATE.Text = "Update";
            btnUPDATE.UseVisualStyleBackColor = true;
            btnUPDATE.Click += btnUPDATE_Click;
            // 
            // btnTAMBAH
            // 
            btnTAMBAH.Location = new Point(40, 256);
            btnTAMBAH.Name = "btnTAMBAH";
            btnTAMBAH.Size = new Size(75, 23);
            btnTAMBAH.TabIndex = 13;
            btnTAMBAH.Text = "Tambah";
            btnTAMBAH.UseVisualStyleBackColor = true;
            btnTAMBAH.Click += btnTAMBAH_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 198);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 12;
            label6.Text = "GAJI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 140);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 8;
            label4.Text = "WAKTU KERJA";
            // 
            // txtGAJI
            // 
            txtGAJI.Location = new Point(15, 216);
            txtGAJI.Name = "txtGAJI";
            txtGAJI.Size = new Size(100, 23);
            txtGAJI.TabIndex = 11;
            // 
            // txtWAKTU
            // 
            txtWAKTU.Location = new Point(15, 158);
            txtWAKTU.Name = "txtWAKTU";
            txtWAKTU.Size = new Size(100, 23);
            txtWAKTU.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(169, 140);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 10;
            label5.Text = "LEMBUR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 79);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 6;
            label3.Text = "JABATAN";
            // 
            // txtLEMBUR
            // 
            txtLEMBUR.Location = new Point(169, 158);
            txtLEMBUR.Name = "txtLEMBUR";
            txtLEMBUR.Size = new Size(100, 23);
            txtLEMBUR.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 19);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 5;
            label2.Text = "NAMA";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox);
            Controls.Add(dataview);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataview).EndInit();
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataview;
        private TextBox txtID;
        private TextBox txtNAMA;
        private TextBox txtJABATAN;
        private Label label1;
        private GroupBox groupBox;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label4;
        private TextBox txtGAJI;
        private TextBox txtWAKTU;
        private Label label5;
        private TextBox txtLEMBUR;
        private Button btnHAPUS;
        private Button btnUPDATE;
        private Button btnTAMBAH;
    }
}
