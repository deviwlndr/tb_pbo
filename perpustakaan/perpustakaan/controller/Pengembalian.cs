using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using perpustakaan.model;
using System.Windows.Forms;

namespace perpustakaan.controller
{
    internal class Pengembalian
    {
        //memanggil class Koneksi dan membuat objek baru
        Koneksi koneksi = new Koneksi();

        //Method Insert
        public bool Insert(M_pengembalian pengembalian)
        {
            Boolean status = false;

            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO t_pengembalian (id_buku, npm, id_peminjaman)" +
                    " VALUES('" + pengembalian.Id_buku + "','" + pengembalian.Npm + "','" + pengembalian.Id_peminjaman + "')");
                status = true;
                MessageBox.Show("Data berhasil ditambahkan", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        //Method update
        public bool Update(M_pengembalian pengembalian, string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("UPDATE t_pengembalian SET id_buku='" + pengembalian.Id_buku + "'," + "npm='" + pengembalian.Npm + "id_peminjaman='" + pengembalian.Id_peminjaman + "' WHERE id_pengembalian='" + id + "'");
                status = true;
                MessageBox.Show("Data berhasil diubah", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            return status;
        }

        
        //Method delete
        public bool Delete(string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("DELETE FROM t_pengembalian WHERE id_pengembalian ='" + id + "'");
                status = true;
                MessageBox.Show("Data berhasil dihapus", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            return status;
        }
    }
}
