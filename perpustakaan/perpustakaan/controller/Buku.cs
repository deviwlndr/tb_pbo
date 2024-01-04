using perpustakaan.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace perpustakaan.controller
{
    internal class Buku
    {
        //memenaggil class koneksi dan membuat objek baru
        Koneksi koneksi = new Koneksi();

        //Method Insert

        public bool Insert(M_buku buku)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO t_buku (judul, penulis, penerbit, tahun_terbit, kategori) VALUES(' " + buku.Judul + "','" + buku.Penulis + "','" + buku.Penerbit + "','" + buku.Tahun_terbit + "','" + buku.Kategori + "')");
                status = true;
                MessageBox.Show("Data berhasil ditambahkan", "Informasi",
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
        public bool Update(M_buku buku, string id_buku)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection(); koneksi.ExecuteQuery("UPDATE t_buku SET judul='" + buku.Judul + "'," + "penulis='" + buku.Penulis + "'," + "penerbit='" + buku.Penerbit + "'," + "tahun_terbit='" + buku.Tahun_terbit + "' WHERE id = '" + id_buku + "'");status = true;
                MessageBox.Show("Data berhasil diubah", "Informasi",
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

        public bool Delete(string id_buku)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection(); koneksi.ExecuteQuery("DELETE FROM t_buku WHERE id='" + id_buku + "'"); 
                MessageBox.Show("Data berhasil dihapus", "Informasi",
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
