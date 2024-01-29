using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using perpustakaan.controller;
using perpustakaan.model;

namespace perpustakaan.view
{
    public partial class FormRegister : Form
    {
        Koneksi koneksi = new Koneksi();
        M_register m_register = new M_register();
        string id_buku;

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
            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Register registrasi = new Register();
                m_register.Username = tbUsername.Text;
                m_register.Password = tbPassword.Text;
      

                registrasi.Insert(m_register);

            }
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Membuka form login
            FormLogin login = new FormLogin();
            login.ShowDialog();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
