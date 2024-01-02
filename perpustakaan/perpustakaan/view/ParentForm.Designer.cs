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
            this.dataBukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBukuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataTransaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPeminjamanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataTransaksiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPeminjamanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataBukuToolStripMenuItem,
            this.dataTransaksiToolStripMenuItem,
            this.dataTransaksiToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataBukuToolStripMenuItem
            // 
            this.dataBukuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataBukuToolStripMenuItem1});
            this.dataBukuToolStripMenuItem.Name = "dataBukuToolStripMenuItem";
            this.dataBukuToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.dataBukuToolStripMenuItem.Text = "File";
            // 
            // dataBukuToolStripMenuItem1
            // 
            this.dataBukuToolStripMenuItem1.Name = "dataBukuToolStripMenuItem1";
            this.dataBukuToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.dataBukuToolStripMenuItem1.Text = "Exit";
            // 
            // dataTransaksiToolStripMenuItem
            // 
            this.dataTransaksiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataPeminjamanToolStripMenuItem});
            this.dataTransaksiToolStripMenuItem.Name = "dataTransaksiToolStripMenuItem";
            this.dataTransaksiToolStripMenuItem.Size = new System.Drawing.Size(124, 29);
            this.dataTransaksiToolStripMenuItem.Text = "Data Master";
            this.dataTransaksiToolStripMenuItem.Click += new System.EventHandler(this.dataTransaksiToolStripMenuItem_Click);
            // 
            // dataPeminjamanToolStripMenuItem
            // 
            this.dataPeminjamanToolStripMenuItem.Name = "dataPeminjamanToolStripMenuItem";
            this.dataPeminjamanToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.dataPeminjamanToolStripMenuItem.Text = "Data Buku";
            // 
            // dataTransaksiToolStripMenuItem1
            // 
            this.dataTransaksiToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataPeminjamanToolStripMenuItem1});
            this.dataTransaksiToolStripMenuItem1.Name = "dataTransaksiToolStripMenuItem1";
            this.dataTransaksiToolStripMenuItem1.Size = new System.Drawing.Size(140, 29);
            this.dataTransaksiToolStripMenuItem1.Text = "Data Transaksi";
            // 
            // dataPeminjamanToolStripMenuItem1
            // 
            this.dataPeminjamanToolStripMenuItem1.Name = "dataPeminjamanToolStripMenuItem1";
            this.dataPeminjamanToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.dataPeminjamanToolStripMenuItem1.Text = "Data Peminjaman";
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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
        private System.Windows.Forms.ToolStripMenuItem dataBukuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataBukuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dataTransaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPeminjamanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataTransaksiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dataPeminjamanToolStripMenuItem1;
    }
}