using perpustakaan.controller;
using perpustakaan.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace perpustakaan.view
{
    public partial class FormBuku : Form
    {
        Koneksi koneksi = new Koneksi();
        M_buku m_buku = new M_buku();
        string id_buku;
        public FormBuku()
        {
            InitializeComponent();
        }

        public void ResetForm()
        {
            tbJudulBuku.Text = "";
            tbPenulis.Text = "";
            tbPenerbit.Text = "";
            tbTahunTerbit.Text = "";
            cbKategori.SelectedIndex = -1;  
        }

        public void Tampil()
        {
            DataBuku.DataSource = koneksi.ShowData("SELECT * FROM t_buku");
            //mengubah nama kolom tabel
            DataBuku.Columns[0].HeaderText = "ID Buku";
            DataBuku.Columns[1].HeaderText = "Judul Buku";
            DataBuku.Columns[2].HeaderText = "Penulis";
            DataBuku.Columns[3].HeaderText = "Penerbit";
            DataBuku.Columns[4].HeaderText = "Tahun Terbit";
            DataBuku.Columns[5].HeaderText = "Kategori";
        }


        private void FormBuku_Load(object sender, EventArgs e)
        {
            //Memanggil method Tampil
            Tampil();
            ResetForm();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (tbJudulBuku.Text == "" || tbPenulis.Text == "" ||tbPenerbit.Text == "" || tbTahunTerbit.Text == "" || cbKategori.SelectedIndex == -1)
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Buku buku = new Buku();
                    m_buku.Judul = tbJudulBuku.Text;
                    m_buku.Penulis = tbPenulis.Text;
                    m_buku.Penerbit = tbPenerbit.Text;
                    m_buku.Tahun_terbit = tbTahunTerbit.Text;
                    m_buku.Kategori = cbKategori.Text;

                    buku.Insert(m_buku);

                    ResetForm();
                    Tampil();
            }
        }

        private void DataBuku_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_buku = DataBuku.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbJudulBuku.Text = DataBuku.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbPenulis.Text = DataBuku.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbPenerbit.Text = DataBuku.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbTahunTerbit.Text = DataBuku.Rows[e.RowIndex].Cells[4].Value.ToString();
            cbKategori.Text = DataBuku.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (tbJudulBuku.Text == "" || tbPenulis.Text == "" || tbPenerbit.Text == "" || tbTahunTerbit.Text == "" || cbKategori.SelectedIndex == -1)
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Buku buku = new Buku();
                
                    m_buku.Judul = tbJudulBuku.Text;
                    m_buku.Penulis = tbPenulis.Text;
                    m_buku.Penerbit = tbPenerbit.Text;
                    m_buku.Tahun_terbit = tbTahunTerbit.Text;
                    m_buku.Kategori = cbKategori.Text;

                    buku.Update(m_buku, id_buku);

                    ResetForm();
                    Tampil();
                
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }
        public void RefreshForm()
        {
            ResetForm();
            Tampil();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show(
               "Apakah yakin akan menghapus data ini?",
               "Perhatian",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                Buku buku = new Buku();
                buku.Delete(id_buku);
                ResetForm();
                Tampil();
            }
        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            //Query DB seacrh data
            DataBuku.DataSource = koneksi.ShowData("SELECT * FROM t_buku WHERE id LIKE '%" + tbCariData.Text + "%' OR judul LIKE '%" + tbCariData.Text + "%'");
        }

        private void DataBuku_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbJudulBuku_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
