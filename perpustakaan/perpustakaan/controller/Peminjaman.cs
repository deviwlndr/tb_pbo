using perpustakaan.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace perpustakaan.controller
{
    class Peminjaman
    {
        //memanggil class Koneksi dan membuat objek baru
        Koneksi koneksi = new Koneksi();


        //Method Insert
        public bool Insert(M_peminjaman peminjaman)

        {

            Boolean status = false;

            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO t_peminjaman(id_buku, npm, tanggal_peminjaman, tanggal_pengembalian) VALUES('" + peminjaman.Id_buku + "','" + peminjaman.Npm + "','" + peminjaman.Tanggal_peminjaman + "','" + peminjaman.Tanggal_pengembalian + "')");
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
        public bool Update(M_peminjaman peminjaman, string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("UPDATE t_peminjaman SET id_buku='" + peminjaman.Id_buku + "'," + "npm= '" + peminjaman.Npm + "'," + "tanggal_peminjaman='" + peminjaman.Tanggal_peminjaman + "'," + "tanggal_pengembalian='" + peminjaman.Tanggal_pengembalian + "' WHERE id_peminjaman='" + id + "'");
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
                koneksi.ExecuteQuery("DELETE FROM t_peminjaman WHERE id_peminjaman='" + id + "'");
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
