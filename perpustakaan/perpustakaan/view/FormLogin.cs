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

namespace perpustakaan.view
{
    public partial class FormLogin : Form
    {
        CekLogin login = new CekLogin();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Username dan Password tidak boleh kosong !!!");
            }
            else
            {
                string username = tbUsername.Text;
                string password = tbPassword.Text;

                bool status = login.cek_login(username, password);
                if (status)
                {
                    MessageBox.Show("Login Berhasil", "Berhasil");
                    ParentForm pform = new ParentForm();
                    this.Hide();
                    pform.Show();
                }
                else
                {
                    MessageBox.Show("Gagal Login", "Gagal");
                }
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

           // Membuka form registrasi
           FormRegister register = new FormRegister();
           register.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
