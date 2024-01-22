namespace perpustakaan.view
{
    partial class ParentForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBukuToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMahasiswaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataTransaksiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPeminjamanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPengembalianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.dataMasterToolStripMenuItem,
            this.dataTransaksiToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(913, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.dataBukuToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem1.Text = "Logout";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.dataBukuToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.tentangToolStripMenuItem_Click);
            // 
            // dataMasterToolStripMenuItem
            // 
            this.dataMasterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataBukuToolStripMenuItem2,
            this.dataMahasiswaToolStripMenuItem});
            this.dataMasterToolStripMenuItem.Name = "dataMasterToolStripMenuItem";
            this.dataMasterToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.dataMasterToolStripMenuItem.Text = "Data Master";
            this.dataMasterToolStripMenuItem.Click += new System.EventHandler(this.dataTransaksiToolStripMenuItem_Click);
            // 
            // dataBukuToolStripMenuItem2
            // 
            this.dataBukuToolStripMenuItem2.Name = "dataBukuToolStripMenuItem2";
            this.dataBukuToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.dataBukuToolStripMenuItem2.Text = "Data Buku";
            this.dataBukuToolStripMenuItem2.Click += new System.EventHandler(this.dataBukuToolStripMenuItem2_Click);
            // 
            // dataMahasiswaToolStripMenuItem
            // 
            this.dataMahasiswaToolStripMenuItem.Name = "dataMahasiswaToolStripMenuItem";
            this.dataMahasiswaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataMahasiswaToolStripMenuItem.Text = "Data Mahasiswa";
            this.dataMahasiswaToolStripMenuItem.Click += new System.EventHandler(this.dataMahasiswaToolStripMenuItem_Click);
            // 
            // dataTransaksiToolStripMenuItem1
            // 
            this.dataTransaksiToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataPeminjamanToolStripMenuItem1,
            this.dataPengembalianToolStripMenuItem});
            this.dataTransaksiToolStripMenuItem1.Name = "dataTransaksiToolStripMenuItem1";
            this.dataTransaksiToolStripMenuItem1.Size = new System.Drawing.Size(93, 22);
            this.dataTransaksiToolStripMenuItem1.Text = "Data Transaksi";
            // 
            // dataPeminjamanToolStripMenuItem1
            // 
            this.dataPeminjamanToolStripMenuItem1.Name = "dataPeminjamanToolStripMenuItem1";
            this.dataPeminjamanToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.dataPeminjamanToolStripMenuItem1.Text = "Data Peminjaman";
            this.dataPeminjamanToolStripMenuItem1.Click += new System.EventHandler(this.dataPeminjamanToolStripMenuItem1_Click);
            // 
            // dataPengembalianToolStripMenuItem
            // 
            this.dataPengembalianToolStripMenuItem.Name = "dataPengembalianToolStripMenuItem";
            this.dataPengembalianToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.dataPengembalianToolStripMenuItem.Text = "Data Pengembalian";
            this.dataPengembalianToolStripMenuItem.Click += new System.EventHandler(this.dataPengembalianToolStripMenuItem_Click);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 487);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ParentForm";
            this.Text = "ParentForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ParentForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dataMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataTransaksiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dataPeminjamanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataBukuToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem dataPengembalianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataMahasiswaToolStripMenuItem;
    }
}