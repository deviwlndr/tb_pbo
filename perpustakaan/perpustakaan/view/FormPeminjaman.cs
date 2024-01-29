using MySql.Data.MySqlClient;
using perpustakaan.controller;
using perpustakaan.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace perpustakaan.view
{
    public partial class FormPeminjaman : Form
    {
        Koneksi koneksi = new Koneksi();
        M_peminjaman m_peminjaman = new M_peminjaman();
        string id_peminjaman;
        string tanggalDariMySQL = "25/01/2024";

        public FormPeminjaman()
        {
            InitializeComponent();
        }

        public void Tampil()
        {
            DataPeminjaman.DataSource = koneksi.ShowData("SELECT " +
          " t_peminjaman.id_peminjaman, t_buku.id_buku, nama, t_mahasiswa.npm, judul, tanggal_peminjaman, tanggal_pengembalian " +
          " FROM t_peminjaman JOIN t_buku ON (t_buku.id_buku = t_peminjaman.id_buku) JOIN t_mahasiswa ON (t_mahasiswa.npm = t_peminjaman.npm)");
            //mengubah nama header tabel
            DataPeminjaman.Columns[0].HeaderText = "ID Peminjaman";
            DataPeminjaman.Columns[1].HeaderText = "ID Buku";
            DataPeminjaman.Columns[2].HeaderText = "Nama Peminjam";
            DataPeminjaman.Columns[3].HeaderText = "NPM";
            DataPeminjaman.Columns[4].HeaderText = "Judul";
            DataPeminjaman.Columns[5].HeaderText = "Tanggal Peminjaman";
            DataPeminjaman.Columns[6].HeaderText = "Tanggal Pengembalian";

        }

        public void ResetForm()
        {
            id_buku.SelectedIndex = -1;
            nama_peminjam.Text = "";
            npm.Text = "";
            judul.Text = "";
            tanggal_peminjaman.Text = "";
            tanggal_pengembalian.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            //Query search data
            DataPeminjaman.DataSource = koneksi.ShowData("SELECT id_peminjaman, t_buku.id_buku, judul, nama, t_mahasiswa.npm, tanggal_peminjaman, tanggal_pengembalian peminjaman " +
            "FROM t_peminjaman JOIN t_buku ON t_buku.id_buku = t_peminjaman.id_buku " +
            "WHERE t_peminjaman.id_buku LIKE '%' '" + tbCariData.Text + "' '%' " +
            "OR judul LIKE '%' '" + tbCariData.Text + "' '%'");
        }

        private void FormPeminjaman_Load(object sender, EventArgs e)
        {
            Tampil();
            GetDataIDBuku();
            GetDataJudulBuku();
            GetDataMhs();

            id_buku.SelectedIndexChanged += id_buku_SelectedIndexChanged;
            npm.SelectedIndexChanged += npm_SelectedIndexChange;

        }

        public void GetDataIDBuku()
        {
            //ambil data ID Buku dari table (T_buku) untuk mengisi data pada combobox id buku
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM t_buku");
            while (reader.Read())
            {
                id_buku.Items.Add(reader.GetString("id_buku"));
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        public void GetDataMhs()
        {
            
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM t_mahasiswa");
            while (reader.Read())
            {
                npm.Items.Add(reader.GetString("npm"));
               
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        public void GetDataJudulBuku()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT judul FROM t_buku WHERE id_buku = '" + id_buku.Text + "'");
            while (reader.Read())
            {

                judul.Text = reader.GetString(0);
            }
            reader.Close();
            koneksi.CloseConnection();

        }
        public void GetDataNamaMhs()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT nama FROM t_mahasiswa WHERE npm = '" + npm.Text + "'");
            while (reader.Read())
            {

                nama_peminjam.Text = reader.GetString(0);
            }
            reader.Close();
            koneksi.CloseConnection();

        }
        private void id_buku_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDataJudulBuku();
        }

        private void npm_SelectedIndexChange(object sender, EventArgs e)
        {
            GetDataMhs();
            GetDataNamaMhs();
        }



        private void DataPeminjaman_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_peminjaman = DataPeminjaman.Rows[e.RowIndex].Cells[0].Value.ToString();
            id_buku.Text = DataPeminjaman.Rows[e.RowIndex].Cells[1].Value.ToString();
            nama_peminjam.Text = DataPeminjaman.Rows[e.RowIndex].Cells[2].Value.ToString();
            npm.Text = DataPeminjaman.Rows[e.RowIndex].Cells[3].Value.ToString();
            judul.Text = DataPeminjaman.Rows[e.RowIndex].Cells[4].Value.ToString();
            tanggal_peminjaman.Text = DataPeminjaman.Rows[e.RowIndex].Cells[5].Value.ToString();
            tanggal_pengembalian.Text = DataPeminjaman.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        private void DataPeminjaman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void judul_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
                if (id_buku.SelectedIndex == -1 || npm.Text == "" || nama_peminjam.Text == "" || judul.Text == "" || tanggal_peminjaman.Value == null || tanggal_pengembalian.Value == null)
                {
                    MessageBox.Show("Isi form dengan benar sebelum disimpan!", "Gagal Menyimpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Peminjaman pinjam = new Peminjaman();

                    DateTime tanggalPeminjaman = tanggal_peminjaman.Value;
                    DateTime tanggalPengembalian = tanggal_pengembalian.Value;

                    m_peminjaman.Tanggal_peminjaman = tanggalPeminjaman.ToString("yyyy-MM-dd");
                    m_peminjaman.Tanggal_pengembalian = tanggalPengembalian.ToString("yyyy-MM-dd");

                    m_peminjaman.Id_buku = id_buku.Text;
                    m_peminjaman.Npm = npm.Text;

                    pinjam.Insert(m_peminjaman);
                    ResetForm();
                    Tampil();
                }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            ResetForm();
            Tampil();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (id_buku.SelectedIndex == -1 || npm.Text == "" || nama_peminjam.Text == "" || judul.Text == "" || tanggal_peminjaman.Value == null || tanggal_pengembalian.Value == null)
            {
                MessageBox.Show("Isi form dengan benar sebelum disimpan!", "Gagal Mengubah Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Peminjaman pinjam = new Peminjaman();

                DateTime tanggalPeminjaman = tanggal_peminjaman.Value;
                DateTime tanggalPengembalian = tanggal_pengembalian.Value;

                m_peminjaman.Tanggal_peminjaman = tanggalPeminjaman.ToString("yyyy-MM-dd");
                m_peminjaman.Tanggal_pengembalian = tanggalPengembalian.ToString("yyyy-MM-dd");

                m_peminjaman.Id_buku = id_buku.Text;
                m_peminjaman.Npm = npm.Text;

                pinjam.Update(m_peminjaman, id_peminjaman);
                ResetForm();
                Tampil();
            }

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah yakin akan menghapus data ini?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                Peminjaman pinjam = new Peminjaman();
                pinjam.Delete(id_peminjaman);
                ResetForm();
                Tampil();
            }

        }

        private void id_buku_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }
    }
}
