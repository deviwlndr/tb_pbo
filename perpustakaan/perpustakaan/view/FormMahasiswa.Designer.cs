namespace perpustakaan.view
{
    partial class FormMahasiswa
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbCariData = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbProdi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNoTelp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNpm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DataMahasiswa = new System.Windows.Forms.GroupBox();
            this.DataMhs = new System.Windows.Forms.DataGridView();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.DataMahasiswa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataMhs)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnHapus);
            this.groupBox4.Controls.Add(this.btnUbah);
            this.groupBox4.Controls.Add(this.btnSimpan);
            this.groupBox4.Controls.Add(this.btnRefresh);
            this.groupBox4.Location = new System.Drawing.Point(431, 299);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(309, 131);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tombol Action";
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHapus.Location = new System.Drawing.Point(12, 97);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(2);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(285, 21);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUbah.Location = new System.Drawing.Point(12, 73);
            this.btnUbah.Margin = new System.Windows.Forms.Padding(2);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(285, 20);
            this.btnUbah.TabIndex = 2;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = false;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSimpan.Location = new System.Drawing.Point(12, 47);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(2);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(285, 22);
            this.btnSimpan.TabIndex = 1;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 21);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(285, 22);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbCariData);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(431, 255);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(309, 40);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Form Pencarian";
            // 
            // tbCariData
            // 
            this.tbCariData.Location = new System.Drawing.Point(67, 17);
            this.tbCariData.Margin = new System.Windows.Forms.Padding(2);
            this.tbCariData.Name = "tbCariData";
            this.tbCariData.Size = new System.Drawing.Size(235, 20);
            this.tbCariData.TabIndex = 1;
            this.tbCariData.TextChanged += new System.EventHandler(this.tbCariData_TextChanged);
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
            this.groupBox2.Controls.Add(this.cbProdi);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbEmail);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbNoTelp);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbNama);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbNpm);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(7, 251);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(415, 179);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Form Input Mahasiswa";
            // 
            // cbProdi
            // 
            this.cbProdi.FormattingEnabled = true;
            this.cbProdi.Items.AddRange(new object[] {
            "D3 Akuntansi ",
            "D3 Manajemen Bisnis",
            "D3 Manajemen Logistik",
            "D3 Sistem Informasi",
            "D3 Teknik Informatika\t",
            "D4 Manajemen Bisnis",
            "D4 Akuntansi Keuangan",
            "D4 Logistik Bisnis",
            "D4 Teknik Informatika",
            "D4 E-Commerce Logistik",
            "S1 Sains Data",
            "S1 Manajemen Transportasi",
            "S1 Bisnis Digital",
            "S1 Manajemen Rekayasa",
            "S1 Manajemen Logistik"});
            this.cbProdi.Location = new System.Drawing.Point(95, 145);
            this.cbProdi.Margin = new System.Windows.Forms.Padding(2);
            this.cbProdi.Name = "cbProdi";
            this.cbProdi.Size = new System.Drawing.Size(309, 21);
            this.cbProdi.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Program Studi";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(95, 85);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(309, 20);
            this.tbEmail.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email";
            // 
            // tbNoTelp
            // 
            this.tbNoTelp.Location = new System.Drawing.Point(95, 115);
            this.tbNoTelp.Margin = new System.Windows.Forms.Padding(2);
            this.tbNoTelp.Name = "tbNoTelp";
            this.tbNoTelp.Size = new System.Drawing.Size(309, 20);
            this.tbNoTelp.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "No Telp";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(95, 55);
            this.tbNama.Margin = new System.Windows.Forms.Padding(2);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(309, 20);
            this.tbNama.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama";
            // 
            // tbNpm
            // 
            this.tbNpm.Location = new System.Drawing.Point(95, 24);
            this.tbNpm.Margin = new System.Windows.Forms.Padding(2);
            this.tbNpm.Name = "tbNpm";
            this.tbNpm.Size = new System.Drawing.Size(309, 20);
            this.tbNpm.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Npm";
            // 
            // DataMahasiswa
            // 
            this.DataMahasiswa.Controls.Add(this.DataMhs);
            this.DataMahasiswa.Location = new System.Drawing.Point(3, 2);
            this.DataMahasiswa.Margin = new System.Windows.Forms.Padding(2);
            this.DataMahasiswa.Name = "DataMahasiswa";
            this.DataMahasiswa.Padding = new System.Windows.Forms.Padding(2);
            this.DataMahasiswa.Size = new System.Drawing.Size(737, 245);
            this.DataMahasiswa.TabIndex = 8;
            this.DataMahasiswa.TabStop = false;
            this.DataMahasiswa.Text = "Table Data Mahasiswa";
            // 
            // DataMhs
            // 
            this.DataMhs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataMhs.Location = new System.Drawing.Point(5, 17);
            this.DataMhs.Margin = new System.Windows.Forms.Padding(2);
            this.DataMhs.Name = "DataMhs";
            this.DataMhs.RowHeadersWidth = 62;
            this.DataMhs.RowTemplate.Height = 28;
            this.DataMhs.Size = new System.Drawing.Size(725, 224);
            this.DataMhs.TabIndex = 0;
            this.DataMhs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataMahasiswa_CellClick);
            this.DataMhs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataMahasiswa_CellContentClick);
            // 
            // FormMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 437);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DataMahasiswa);
            this.Name = "FormMahasiswa";
            this.Text = "FormMahasiswa";
            this.Load += new System.EventHandler(this.FormMahasiswa_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.DataMahasiswa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataMhs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbCariData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbProdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNoTelp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNpm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox DataMahasiswa;
        private System.Windows.Forms.DataGridView DataMhs;
    }
}