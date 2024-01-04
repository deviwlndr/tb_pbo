using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perpustakaan.model
{
    internal class M_buku
    {
        string judul, penulis, penerbit, tahun_terbit, kategori;

        public M_buku()
        {

        }

        public M_buku(string judul, string penulis, string penerbit, string tahun_terbit, string kategori)
        {
            
            this.Judul = judul;
            this.Penulis = penulis;
            this.Penerbit = penerbit;
            this.Tahun_terbit = tahun_terbit;
            this.Kategori = kategori;
        }

        
        public string Judul { get => judul; set => judul = value; }
        public string Penulis { get => penulis; set => penulis = value; }
        public string Penerbit { get => penerbit; set => penerbit = value; }
        public string Tahun_terbit { get => tahun_terbit; set => tahun_terbit = value; }
        public string Kategori { get => kategori; set => kategori = value; }
    }
}
