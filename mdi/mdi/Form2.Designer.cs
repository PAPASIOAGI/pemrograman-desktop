namespace mdi
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            dataToolStripMenuItem = new ToolStripMenuItem();
            memberToolStripMenuItem = new ToolStripMenuItem();
            bARANGToolStripMenuItem = new ToolStripMenuItem();
            uSERToolStripMenuItem = new ToolStripMenuItem();
            transaksiToolStripMenuItem = new ToolStripMenuItem();
            pembelianToolStripMenuItem = new ToolStripMenuItem();
            penjualanToolStripMenuItem = new ToolStripMenuItem();
            lAPORANToolStripMenuItem = new ToolStripMenuItem();
            sTOKToolStripMenuItem = new ToolStripMenuItem();
            lAPORANToolStripMenuItem1 = new ToolStripMenuItem();
            laporanKeuangaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            mASTERToolStripMenuItem = new ToolStripMenuItem();
            tRANSAKSIToolStripMenuItem1 = new ToolStripMenuItem();
            lAPORANToolStripMenuItem2 = new ToolStripMenuItem();
            sYSTEMToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { dataToolStripMenuItem, transaksiToolStripMenuItem, lAPORANToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(129, 70);
            // 
            // dataToolStripMenuItem
            // 
            dataToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { memberToolStripMenuItem, bARANGToolStripMenuItem, uSERToolStripMenuItem });
            dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            dataToolStripMenuItem.Size = new Size(128, 22);
            dataToolStripMenuItem.Text = "Data";
            dataToolStripMenuItem.Click += dataToolStripMenuItem_Click;
            // 
            // memberToolStripMenuItem
            // 
            memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            memberToolStripMenuItem.Size = new Size(121, 22);
            memberToolStripMenuItem.Text = "Member";
            // 
            // bARANGToolStripMenuItem
            // 
            bARANGToolStripMenuItem.Name = "bARANGToolStripMenuItem";
            bARANGToolStripMenuItem.Size = new Size(121, 22);
            bARANGToolStripMenuItem.Text = "BARANG";
            // 
            // uSERToolStripMenuItem
            // 
            uSERToolStripMenuItem.Name = "uSERToolStripMenuItem";
            uSERToolStripMenuItem.Size = new Size(121, 22);
            uSERToolStripMenuItem.Text = "USER";
            // 
            // transaksiToolStripMenuItem
            // 
            transaksiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pembelianToolStripMenuItem, penjualanToolStripMenuItem });
            transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            transaksiToolStripMenuItem.Size = new Size(128, 22);
            transaksiToolStripMenuItem.Text = "transaksi";
            // 
            // pembelianToolStripMenuItem
            // 
            pembelianToolStripMenuItem.Name = "pembelianToolStripMenuItem";
            pembelianToolStripMenuItem.Size = new Size(130, 22);
            pembelianToolStripMenuItem.Text = "Pembelian";
            // 
            // penjualanToolStripMenuItem
            // 
            penjualanToolStripMenuItem.Name = "penjualanToolStripMenuItem";
            penjualanToolStripMenuItem.Size = new Size(130, 22);
            penjualanToolStripMenuItem.Text = "Penjualan";
            // 
            // lAPORANToolStripMenuItem
            // 
            lAPORANToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sTOKToolStripMenuItem, lAPORANToolStripMenuItem1, laporanKeuangaToolStripMenuItem });
            lAPORANToolStripMenuItem.Name = "lAPORANToolStripMenuItem";
            lAPORANToolStripMenuItem.Size = new Size(128, 22);
            lAPORANToolStripMenuItem.Text = "LAPORAN";
            // 
            // sTOKToolStripMenuItem
            // 
            sTOKToolStripMenuItem.Name = "sTOKToolStripMenuItem";
            sTOKToolStripMenuItem.Size = new Size(165, 22);
            sTOKToolStripMenuItem.Text = "STOK";
            // 
            // lAPORANToolStripMenuItem1
            // 
            lAPORANToolStripMenuItem1.Name = "lAPORANToolStripMenuItem1";
            lAPORANToolStripMenuItem1.Size = new Size(165, 22);
            lAPORANToolStripMenuItem1.Text = "LAPORAN";
            // 
            // laporanKeuangaToolStripMenuItem
            // 
            laporanKeuangaToolStripMenuItem.Name = "laporanKeuangaToolStripMenuItem";
            laporanKeuangaToolStripMenuItem.Size = new Size(165, 22);
            laporanKeuangaToolStripMenuItem.Text = "Laporan keuanga";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mASTERToolStripMenuItem, tRANSAKSIToolStripMenuItem1, lAPORANToolStripMenuItem2, sYSTEMToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // mASTERToolStripMenuItem
            // 
            mASTERToolStripMenuItem.Name = "mASTERToolStripMenuItem";
            mASTERToolStripMenuItem.Size = new Size(64, 20);
            mASTERToolStripMenuItem.Text = "MASTER";
            // 
            // tRANSAKSIToolStripMenuItem1
            // 
            tRANSAKSIToolStripMenuItem1.Name = "tRANSAKSIToolStripMenuItem1";
            tRANSAKSIToolStripMenuItem1.Size = new Size(80, 20);
            tRANSAKSIToolStripMenuItem1.Text = "TRANSAKSI";
            // 
            // lAPORANToolStripMenuItem2
            // 
            lAPORANToolStripMenuItem2.Name = "lAPORANToolStripMenuItem2";
            lAPORANToolStripMenuItem2.Size = new Size(73, 20);
            lAPORANToolStripMenuItem2.Text = "LAPORAN";
            // 
            // sYSTEMToolStripMenuItem
            // 
            sYSTEMToolStripMenuItem.Name = "sYSTEMToolStripMenuItem";
            sYSTEMToolStripMenuItem.Size = new Size(62, 20);
            sYSTEMToolStripMenuItem.Text = "SYSTEM";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Form2";
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem dataToolStripMenuItem;
        private ToolStripMenuItem transaksiToolStripMenuItem;
        private ToolStripMenuItem lAPORANToolStripMenuItem;
        private ToolStripMenuItem memberToolStripMenuItem;
        private ToolStripMenuItem bARANGToolStripMenuItem;
        private ToolStripMenuItem uSERToolStripMenuItem;
        private ToolStripMenuItem pembelianToolStripMenuItem;
        private ToolStripMenuItem penjualanToolStripMenuItem;
        private ToolStripMenuItem sTOKToolStripMenuItem;
        private ToolStripMenuItem lAPORANToolStripMenuItem1;
        private ToolStripMenuItem laporanKeuangaToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mASTERToolStripMenuItem;
        private ToolStripMenuItem tRANSAKSIToolStripMenuItem1;
        private ToolStripMenuItem lAPORANToolStripMenuItem2;
        private ToolStripMenuItem sYSTEMToolStripMenuItem;
    }
}