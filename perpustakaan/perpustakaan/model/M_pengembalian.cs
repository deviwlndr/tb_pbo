using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perpustakaan.model
{
    internal class M_pengembalian
    {
        string id_peminjaman, id_buku, npm;

        public M_pengembalian()
        {

        }


        public M_pengembalian(string id_peminjaman, string id_buku, string npm)
        {
            this.Id_peminjaman = id_peminjaman;
            this.Id_buku = id_buku;
            this.Npm = npm;
           /* this.Durasi_pinjam = durasi_pinjam;*/
        }

        public string Id_peminjaman { get => id_peminjaman; set => id_peminjaman = value; }
        public string Id_buku { get => id_buku; set => id_buku = value; }
        public string Npm { get => npm; set => npm = value; }
        /*public string Durasi_pinjam { get => durasi_pinjam; set => durasi_pinjam = value; }*/
    }
}
