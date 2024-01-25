using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perpustakaan.model
{
    class M_peminjaman
    {
        string id_buku, npm, tanggal_peminjaman, tanggal_pengembalian;
        public M_peminjaman()
        {

        }

        public M_peminjaman(string id_buku, string npm, string tanggal_peminjaman, string tanggal_pengembalian)
        {
           
            this.Id_buku = id_buku;
            this.Npm = npm;
            this.Tanggal_peminjaman = tanggal_peminjaman;
            this.Tanggal_pengembalian = tanggal_pengembalian;
        }

        public string Id_buku { get => id_buku; set => id_buku = value; }
        public string Npm { get => npm; set => npm = value; }
        public string Tanggal_peminjaman { get => tanggal_peminjaman; set => tanggal_peminjaman = value; }
        public string Tanggal_pengembalian { get => tanggal_pengembalian; set => tanggal_pengembalian = value; }
    }
}
