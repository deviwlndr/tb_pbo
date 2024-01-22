using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace perpustakaan.model
{
    internal class M_mahasiswa
    {
        string npm, nama, email, no_telp, prodi;
        public M_mahasiswa()
        {

        }

        public M_mahasiswa(string npm, string nama, string email, string no_telp, string prodi)
        {

            this.Npm = npm;
            this.Nama = nama;
            this.Email = email;
            this.No_Telp = no_telp;
            this.Prodi = prodi;
        }

        public string Npm { get => npm; set => npm = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Email { get => email; set => email = value; }
        public string No_Telp { get => no_telp; set => no_telp = value; }
        public string Prodi { get => prodi; set => prodi = value; }
    }
}
