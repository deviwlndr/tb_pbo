using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perpustakaan.model
{
    internal class M_register
    {
        string username, password;

        public M_register()
        {

        }

        public M_register(string username, string password)
        {

            this.Username = username;
            this.Password = password;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
