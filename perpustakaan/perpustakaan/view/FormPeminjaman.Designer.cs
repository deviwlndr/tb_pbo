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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbCariData = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataBarang = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.id_barang = new System.Windows.Forms.ComboBox();
            this.penerbit = new System.Windows.Forms.TextBox();
            this.penulis = new System.Windows.Forms.TextBox();
            this.tahun_terbit = new System.Windows.Forms.TextBox();
            this.kategori = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nama_peminjam = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataBarang)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnHapus);
            this.groupBox4.Controls.Add(this.btnUbah);
            this.groupBox4.Controls.Add(this.btnSimpan);
            this.groupBox4.Controls.Add(this.Refresh);
            this.groupBox4.Location = new System.Drawing.Point(523, 303);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(216, 148);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tombol Action";
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.Red;
            this.btnHapus.Location = new System.Drawing.Point(12, 113);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(2);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(197, 21);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            // 
            // btnUbah
            // 
            this.btnUbah.BackColor = System.Drawing.Color.Yellow;
            this.btnUbah.Location = new System.Drawing.Point(12, 83);
            this.btnUbah.Margin = new System.Windows.Forms.Padding(2);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(197, 20);
            this.btnUbah.TabIndex = 2;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = false;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSimpan.Location = new System.Drawing.Point(12, 51);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(2);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(197, 22);
            this.btnSimpan.TabIndex = 1;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Refresh.Location = new System.Drawing.Point(12, 17);
            this.Refresh.Margin = new System.Windows.Forms.Padding(2);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(197, 22);
            this.Refresh.TabIndex = 0;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbCariData);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(509, 250);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(230, 40);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Form Pencarian";
            // 
            // tbCariData
            // 
            this.tbCariData.Location = new System.Drawing.Point(62, 14);
            this.tbCariData.Margin = new System.Windows.Forms.Padding(2);
            this.tbCariData.Name = "tbCariData";
            this.tbCariData.Size = new System.Drawing.Size(161, 20);
            this.tbCariData.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cari Data";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nama_peminjam);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(2, 250);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(488, 201);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Form Peminjaman Buku";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 88);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Kategori";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Penerbit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tahun Terbit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Penulis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Buku";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataBarang);
            this.groupBox1.Location = new System.Drawing.Point(2, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(737, 245);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Table Peminjaman Buku";
            // 
            // DataBarang
            // 
            this.DataBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBarang.Location = new System.Drawing.Point(5, 17);
            this.DataBarang.Margin = new System.Windows.Forms.Padding(2);
            this.DataBarang.Name = "DataBarang";
            this.DataBarang.RowHeadersWidth = 62;
            this.DataBarang.RowTemplate.Height = 28;
            this.DataBarang.Size = new System.Drawing.Size(725, 224);
            this.DataBarang.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.kategori);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.tahun_terbit);
            this.groupBox5.Controls.Add(this.id_barang);
            this.groupBox5.Controls.Add(this.penerbit);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.penulis);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(101, 53);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(361, 134);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            // 
            // id_barang
            // 
            this.id_barang.FormattingEnabled = true;
            this.id_barang.Location = new System.Drawing.Point(6, 11);
            this.id_barang.Name = "id_barang";
            this.id_barang.Size = new System.Drawing.Size(168, 21);
            this.id_barang.TabIndex = 0;
            // 
            // penerbit
            // 
            this.penerbit.Location = new System.Drawing.Point(191, 60);
            this.penerbit.Name = "penerbit";
            this.penerbit.Size = new System.Drawing.Size(149, 20);
            this.penerbit.TabIndex = 7;
            // 
            // penulis
            // 
            this.penulis.Location = new System.Drawing.Point(6, 60);
            this.penulis.Name = "penulis";
            this.penulis.Size = new System.Drawing.Size(168, 20);
            this.penulis.TabIndex = 6;
            // 
            // tahun_terbit
            // 
            this.tahun_terbit.Location = new System.Drawing.Point(6, 103);
            this.tahun_terbit.Name = "tahun_terbit";
            this.tahun_terbit.Size = new System.Drawing.Size(168, 20);
            this.tahun_terbit.TabIndex = 8;
            // 
            // kategori
            // 
            this.kategori.Location = new System.Drawing.Point(191, 103);
            this.kategori.Name = "kategori";
            this.kategori.Size = new System.Drawing.Size(149, 20);
            this.kategori.TabIndex = 9;
            this.kategori.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nama Peminjam";
            // 
            // nama_peminjam
            // 
            this.nama_peminjam.Location = new System.Drawing.Point(107, 28);
            this.nama_peminjam.Margin = new System.Windows.Forms.Padding(2);
            this.nama_peminjam.Name = "nama_peminjam";
            this.nama_peminjam.Size = new System.Drawing.Size(168, 20);
            this.nama_peminjam.TabIndex = 2;
            // 
            // FormPeminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 469);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPeminjaman";
            this.Text = "FormPeminjaman";
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataBarang)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DataBarang;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox id_barang;
        private System.Windows.Forms.TextBox penerbit;
        private System.Windows.Forms.TextBox penulis;
        private System.Windows.Forms.TextBox kategori;
        private System.Windows.Forms.TextBox tahun_terbit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nama_peminjam;
    }
}