using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using perpustakaan.model;
using System.Windows.Forms;

namespace perpustakaan.controller
{
    internal class Register
    {
        //memanggil class Koneksi dan membuat objek baru
        Koneksi koneksi = new Koneksi();

        //Method Insert
        public bool Insert(M_register registrasi)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO t_user(username, password) VALUES('" + registrasi.Username + "','" + registrasi.Password + "')");
                status = true;
                MessageBox.Show("Akun berhasil terbuat", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Akun gagal terbuat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
    }
}
