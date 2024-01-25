namespace perpustakaan.view
{
    partial class FormPeminjaman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPeminjaman));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbCariData = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.npm = new System.Windows.Forms.ComboBox();
            this.judul = new System.Windows.Forms.TextBox();
            this.tanggal_pengembalian = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.id_buku = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tanggal_peminjaman = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.nama_peminjam = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataPeminjaman = new System.Windows.Forms.DataGridView();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataPeminjaman)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox4.BackgroundImage")));
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox4.Controls.Add(this.btnHapus);
            this.groupBox4.Controls.Add(this.btnUbah);
            this.groupBox4.Controls.Add(this.btnSimpan);
            this.groupBox4.Controls.Add(this.Refresh);
            this.groupBox4.Location = new System.Drawing.Point(764, 465);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(390, 234);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tombol Action";
            this.groupBox4.UseWaitCursor = true;
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.Red;
            this.btnHapus.Location = new System.Drawing.Point(18, 174);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(354, 32);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.UseWaitCursor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.BackColor = System.Drawing.Color.Yellow;
            this.btnUbah.Location = new System.Drawing.Point(18, 128);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(354, 31);
            this.btnUbah.TabIndex = 2;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = false;
            this.btnUbah.UseWaitCursor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSimpan.Location = new System.Drawing.Point(18, 78);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(354, 34);
            this.btnSimpan.TabIndex = 1;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.UseWaitCursor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Refresh.Location = new System.Drawing.Point(18, 26);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(354, 34);
            this.Refresh.TabIndex = 0;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.UseWaitCursor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.Controls.Add(this.tbCariData);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(764, 385);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(390, 62);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Form Pencarian";
            this.groupBox3.UseWaitCursor = true;
            // 
            // tbCariData
            // 
            this.tbCariData.Location = new System.Drawing.Point(93, 22);
            this.tbCariData.Name = "tbCariData";
            this.tbCariData.Size = new System.Drawing.Size(240, 26);
            this.tbCariData.TabIndex = 1;
            this.tbCariData.UseWaitCursor = true;
            this.tbCariData.TextChanged += new System.EventHandler(this.tbCariData_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cari Data";
            this.label3.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.npm);
            this.groupBox2.Controls.Add(this.judul);
            this.groupBox2.Controls.Add(this.tanggal_pengembalian);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.id_buku);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tanggal_peminjaman);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.nama_peminjam);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(3, 385);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(755, 332);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Form Peminjaman Buku";
            this.groupBox2.UseWaitCursor = true;
            // 
            // npm
            // 
            this.npm.FormattingEnabled = true;
            this.npm.Location = new System.Drawing.Point(197, 34);
            this.npm.Name = "npm";
            this.npm.Size = new System.Drawing.Size(250, 28);
            this.npm.TabIndex = 22;
            this.npm.UseWaitCursor = true;
            // 
            // judul
            // 
            this.judul.Location = new System.Drawing.Point(197, 181);
            this.judul.Name = "judul";
            this.judul.Size = new System.Drawing.Size(552, 26);
            this.judul.TabIndex = 11;
            this.judul.UseWaitCursor = true;
            this.judul.TextChanged += new System.EventHandler(this.judul_TextChanged);
            // 
            // tanggal_pengembalian
            // 
            this.tanggal_pengembalian.Location = new System.Drawing.Point(197, 288);
            this.tanggal_pengembalian.Name = "tanggal_pengembalian";
            this.tanggal_pengembalian.Size = new System.Drawing.Size(200, 26);
            this.tanggal_pengembalian.TabIndex = 21;
            this.tanggal_pengembalian.UseWaitCursor = true;
            this.tanggal_pengembalian.Value = new System.DateTime(2024, 1, 25, 14, 18, 18, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Judul";
            this.label11.UseWaitCursor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Tanggal Pengembalian";
            this.label10.UseWaitCursor = true;
            // 
            // id_buku
            // 
            this.id_buku.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_buku.FormattingEnabled = true;
            this.id_buku.Location = new System.Drawing.Point(197, 120);
            this.id_buku.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.id_buku.Name = "id_buku";
            this.id_buku.Size = new System.Drawing.Size(250, 28);
            this.id_buku.TabIndex = 0;
            this.id_buku.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tanggal Peminjaman";
            this.label9.UseWaitCursor = true;
            // 
            // tanggal_peminjaman
            // 
            this.tanggal_peminjaman.Location = new System.Drawing.Point(197, 228);
            this.tanggal_peminjaman.Name = "tanggal_peminjaman";
            this.tanggal_peminjaman.Size = new System.Drawing.Size(200, 26);
            this.tanggal_peminjaman.TabIndex = 20;
            this.tanggal_peminjaman.UseWaitCursor = true;
            this.tanggal_peminjaman.Value = new System.DateTime(2024, 1, 25, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "NPM";
            this.label8.UseWaitCursor = true;
            // 
            // nama_peminjam
            // 
            this.nama_peminjam.Location = new System.Drawing.Point(197, 72);
            this.nama_peminjam.Name = "nama_peminjam";
            this.nama_peminjam.Size = new System.Drawing.Size(250, 26);
            this.nama_peminjam.TabIndex = 2;
            this.nama_peminjam.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nama Peminjam";
            this.label7.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Buku";
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.DataPeminjaman);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1154, 377);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Table Peminjaman Buku";
            this.groupBox1.UseWaitCursor = true;
            // 
            // DataPeminjaman
            // 
            this.DataPeminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataPeminjaman.Location = new System.Drawing.Point(8, 26);
            this.DataPeminjaman.Name = "DataPeminjaman";
            this.DataPeminjaman.RowHeadersWidth = 62;
            this.DataPeminjaman.RowTemplate.Height = 28;
            this.DataPeminjaman.Size = new System.Drawing.Size(1146, 345);
            this.DataPeminjaman.TabIndex = 0;
            this.DataPeminjaman.UseWaitCursor = true;
            this.DataPeminjaman.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataPeminjaman_CellClick);
            this.DataPeminjaman.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataPeminjaman_CellContentClick);
            // 
            // FormPeminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1166, 718);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPeminjaman";
            this.Text = "FormPeminjaman";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.FormPeminjaman_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataPeminjaman)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbCariData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DataPeminjaman;
        private System.Windows.Forms.ComboBox id_buku;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nama_peminjam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox judul;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker tanggal_pengembalian;
        private System.Windows.Forms.DateTimePicker tanggal_peminjaman;
        private System.Windows.Forms.ComboBox npm;
    }
}