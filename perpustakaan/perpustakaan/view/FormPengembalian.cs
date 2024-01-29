using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using perpustakaan.controller;
using perpustakaan.model;

namespace perpustakaan.view
{
    public partial class FormPengembalian : Form
    {
        Koneksi koneksi = new Koneksi();
        M_pengembalian m_pengembalian = new M_pengembalian();
        string id_pengembalian;
        

        public FormPengembalian()
        {
            InitializeComponent();
            npm.ReadOnly = true;
            id_buku.ReadOnly = true;
            judul.ReadOnly = true;
        }

        public void Tampil()
        {
            DataPengembalian.DataSource = koneksi.ShowData("SELECT " +
            "t_pengembalian.id_pengembalian, t_peminjaman.id_peminjaman, t_mahasiswa.npm, t_buku.id_buku, t_buku.judul, t_peminjaman.tanggal_peminjaman, t_peminjaman.tanggal_pengembalian " +
            "FROM t_pengembalian " +
            "JOIN t_peminjaman ON (t_pengembalian.id_peminjaman = t_peminjaman.id_peminjaman) " +
            "JOIN t_buku ON (t_pengembalian.id_buku = t_buku.id_buku) " +
            "JOIN t_mahasiswa ON (t_pengembalian.npm = t_mahasiswa.npm) ");

            // Mengubah nama header tabel (pastikan indeks sesuai)
            DataPengembalian.Columns[0].HeaderText = "ID Pengembalian";
            DataPengembalian.Columns[1].HeaderText = "ID Peminjaman";
            
            DataPengembalian.Columns[2].HeaderText = "NPM";
            DataPengembalian.Columns[3].HeaderText = "ID Buku";
            DataPengembalian.Columns[4].HeaderText = "Judul";
            DataPengembalian.Columns[5].HeaderText = "Tanggal Peminjaman";
            DataPengembalian.Columns[6].HeaderText = "Tanggal Pengembalian";

        }

        public void ResetForm()
        {
            id_peminjaman.Text = "";
           
            npm.Text = "";
            tanggal_peminjaman.Text = "";
            tanggal_pengembalian.Text = "";
            id_buku.Text = "";
            judul.Text = "";
            /*durasi_pinjam.Text = "";*/
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void id_peminjaman_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormPengembalian_Load(object sender, EventArgs e)
        {
            Tampil();
            
            GetDataNpm();
            GetDataIDPeminjaman();
            GetDataIDBuku();
            GetDataJudul();
            GetTglPinjam();
            GetTglKembali();
            id_peminjaman.SelectedIndexChanged += id_peminjaman_SelectedIndexChanged;
        }


        public void GetDataIDPeminjaman()
        {
            //ambil data ID Buku dari table (T_buku) untuk mengisi data pada combobox id buku
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM t_peminjaman");
            while (reader.Read())
            {
                id_peminjaman.Items.Add(reader.GetString("id_peminjaman"));
            }
            reader.Close();
            koneksi.CloseConnection();
        }
        public void GetDataNpm()
        {

            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT npm FROM t_peminjaman WHERE id_peminjaman = '" + id_peminjaman.Text + "'");
            while (reader.Read())
            {
                npm.Text = reader.GetString(0);
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        public void GetDataIDBuku()
        {
            //ambil data ID Buku dari table (T_buku) untuk mengisi data pada combobox id buku
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT id_buku FROM t_peminjaman WHERE id_peminjaman = '" + id_peminjaman.Text + "'");
            while (reader.Read())
            {
                id_buku.Text = reader.GetString(0);
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        public void GetDataJudul()
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

        public void GetTglPinjam()
        {

            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT tanggal_peminjaman FROM t_peminjaman WHERE id_peminjaman = '" + id_peminjaman.Text + "'");
            while (reader.Read())
            {
                tanggal_peminjaman.Text = reader.GetString(0);
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        public void GetTglKembali()
        {

            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT tanggal_pengembalian FROM t_peminjaman WHERE id_peminjaman = '" + id_peminjaman.Text + "'");
            while (reader.Read())
            {
                tanggal_pengembalian.Text = reader.GetString(0);
            }
            reader.Close();
            koneksi.CloseConnection();
        }


        private void id_peminjaman_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDataIDPeminjaman();
            GetDataNpm();
            GetDataIDBuku();
            GetDataJudul();
            GetTglPinjam();
            GetTglKembali();
        }


        private void Refresh_Click(object sender, EventArgs e)
        {
            ResetForm();
            Tampil();
        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            //Query search data
            DataPengembalian.DataSource = koneksi.ShowData("SELECT id_pengembalian, t_peminjaman.id_peminjaman, tanggal_peminjaman, tanggal_pengembalian, t_mahasiswa.npm, nama " +
            "FROM t_pengembalian JOIN t_peminjaman ON (t_peminjaman.id_peminjaman = t_pengembalian.id_peminjaman) " +
            "WHERE t_pengembalian.id_peminjaman LIKE '%" + tbCariData.Text + "%' " +
            "OR tanggal_peminjaman LIKE '%" + tbCariData.Text + "%'");
        }

        private void DataPengembalian_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DataPengembalian_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_pengembalian = DataPengembalian.Rows[e.RowIndex].Cells[0].Value.ToString();
            id_peminjaman.Text = DataPengembalian.Rows[e.RowIndex].Cells[1].Value.ToString();
            
            npm.Text = DataPengembalian.Rows[e.RowIndex].Cells[2].Value.ToString();
            id_buku.Text = DataPengembalian.Rows[e.RowIndex].Cells[3].Value.ToString();
            judul.Text = DataPengembalian.Rows[e.RowIndex].Cells[4].Value.ToString();
            tanggal_peminjaman.Text = DataPengembalian.Rows[e.RowIndex].Cells[5].Value.ToString();
            tanggal_pengembalian.Text = DataPengembalian.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (id_peminjaman.SelectedIndex == -1 || npm.Text == "" || id_buku.Text == "" || judul.Text == "" || id_peminjaman.Text == "" || tanggal_peminjaman.Text == null || tanggal_pengembalian.Text == null)
            {
                MessageBox.Show("Isi form dengan benar sebelum disimpan!", "Gagal Menyimpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Pengembalian pengembalian = new Pengembalian();

                m_pengembalian.Id_peminjaman = id_peminjaman.Text;
                m_pengembalian.Npm = npm.Text;
                m_pengembalian.Id_buku = id_buku.Text;
                

                pengembalian.Insert(m_pengembalian);
                ResetForm();
                Tampil();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (id_peminjaman.SelectedIndex == -1 || npm.Text == "" || id_buku.Text == "" || judul.Text == "" || id_peminjaman.Text == "" || tanggal_peminjaman.Text == null || tanggal_pengembalian.Text == null)
            {
                MessageBox.Show("Ubah form dengan benar sebelum disimpan!", "Gagal Menyimpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Pengembalian pengembalian = new Pengembalian();

                m_pengembalian.Id_peminjaman = id_peminjaman.Text;
                m_pengembalian.Npm = npm.Text;
                m_pengembalian.Id_buku = id_buku.Text;


                pengembalian.Update(m_pengembalian, id_pengembalian);
                ResetForm();
                Tampil();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah yakin akan menghapus data ini?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                Pengembalian pengembalian = new Pengembalian();
                pengembalian.Delete(id_pengembalian);
                ResetForm();
                Tampil();
            }
        }
    }
}
