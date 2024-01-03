using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace perpustakaan.view
{
    public partial class FormRegister : Form
    {

        public FormRegister()
        {
            InitializeComponent();
        }

        private void tbNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNotelp_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Membuka form login
            FormLogin login = new FormLogin();
            login.ShowDialog();
        }
    }
}
