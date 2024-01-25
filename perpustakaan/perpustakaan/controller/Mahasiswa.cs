using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using perpustakaan.model;
using System.Windows.Forms;

namespace perpustakaan.controller
{
    internal class Mahasiswa
    {
        //memenaggil class koneksi dan membuat objek baru
        Koneksi koneksi = new Koneksi();

        //Method Insert
        public bool Insert(M_mahasiswa mahasiswa)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO t_mahasiswa (npm, nama, email, no_telp, prodi) VALUES(' " + mahasiswa.Npm + "','" + mahasiswa.Nama + "','" + mahasiswa.Email + "','" + mahasiswa.No_Telp + "','" + mahasiswa.Prodi + "')");
                status = true;
                MessageBox.Show("Data mahasiswa berhasil ditambahkan", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }


        //Method Update
        public bool Update(M_mahasiswa mahasiswa, string npm)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection(); koneksi.ExecuteQuery("UPDATE t_mahasiswa SET nama='" + mahasiswa.Nama + "'," + "email='" + mahasiswa.Email + "'," + "no_telp='" + mahasiswa.No_Telp + "'," + "prodi='" + mahasiswa.Prodi + "' WHERE npm = '" + npm + "'"); 
                MessageBox.Show("Data mahasiswa berhasil diubah", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        //method delete
        public bool Delete(M_mahasiswa mahasiswa, string npm)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("DELETE FROM t_mahasiswa WHERE npm='" + npm + "'");
                MessageBox.Show("Data mahasiswa berhasil dihapus", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Hapus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;

        }
    }
}
