using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using perpustakaan.controller;
using perpustakaan.model;

namespace perpustakaan.view
{
    public partial class FormMahasiswa : Form
    {
        Koneksi koneksi = new Koneksi();
        M_mahasiswa m_mahasiswa = new M_mahasiswa();
        string id;
        public FormMahasiswa()
        {
            InitializeComponent();
        }

        public void ResetForm()
        {
            tbNpm.Text = "";
            tbNama.Text = "";
            tbEmail.Text = "";
            tbNoTelp.Text = "";
            cbProdi.SelectedIndex = -1;
        }

        public void Tampil()
        {
            DataMhs.DataSource = koneksi.ShowData("SELECT * FROM t_mahasiswa");
            //mengubah nama kolom tabel
            DataMhs.Columns[0].HeaderText = "ID Mahasiswa";
            DataMhs.Columns[1].HeaderText = "Npm";
            DataMhs.Columns[2].HeaderText = "Nama";
            DataMhs.Columns[3].HeaderText = "Email";
            DataMhs.Columns[4].HeaderText = "No Telp";
            DataMhs.Columns[5].HeaderText = "Prodi";
        }

        private void FormMahasiswa_Load(object sender, EventArgs e)
        {
            //Memanggil method Tampil
            Tampil();
            ResetForm();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (tbNpm.Text == "" || tbNama.Text == "" || tbEmail.Text == "" || tbNoTelp.Text == "" || cbProdi.SelectedIndex == -1)
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Mahasiswa mhs = new Mahasiswa();
                m_mahasiswa.Npm = tbNpm.Text;
                m_mahasiswa.Nama = tbNama.Text;
                m_mahasiswa.Email = tbEmail.Text;
                m_mahasiswa.No_Telp = tbNoTelp.Text;
                m_mahasiswa.Prodi = cbProdi.Text;

                mhs.Insert(m_mahasiswa);

                ResetForm();
                Tampil();
            }
        }

        private void DataMahasiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = DataMhs.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbNpm.Text = DataMhs.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbNama.Text = DataMhs.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbEmail.Text = DataMhs.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbNoTelp.Text = DataMhs.Rows[e.RowIndex].Cells[4].Value.ToString();
            cbProdi.Text = DataMhs.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            //Query DB seacrh data
            DataMhs.DataSource = koneksi.ShowData("SELECT * FROM t_mahasiswa WHERE id LIKE '%" + tbCariData.Text + "%' OR npm LIKE '%" + tbCariData.Text + "%'");
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


        private void DataMahasiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (tbNpm.Text == "" || tbNama.Text == "" || tbEmail.Text == "" || tbNoTelp.Text == "" || cbProdi.SelectedIndex == -1)
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Mahasiswa mhs = new Mahasiswa();

                m_mahasiswa.Npm = tbNpm.Text;
                m_mahasiswa.Nama = tbNama.Text;
                m_mahasiswa.Email = tbEmail.Text;
                m_mahasiswa.No_Telp = tbNoTelp.Text;
                m_mahasiswa.Prodi = cbProdi.Text;

                mhs.Update(m_mahasiswa, id);

                ResetForm();
                Tampil();
            }
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
                Mahasiswa mhs = new Mahasiswa();
                mhs.Delete(id);
                ResetForm();
                Tampil();
            }
        }
    }
}
