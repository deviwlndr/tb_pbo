using perpustakaan.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace perpustakaan.view
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void dataPeminjamanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataTransaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ParentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataPeminjamanToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormBuku buku = new FormBuku();
            buku.MdiParent = this;
            buku.Show();
        }

        private void tentangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.MdiParent = this;
            about.Show();
        }

        private void dataPeminjamanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormPeminjaman peminjaman = new FormPeminjaman();
            peminjaman.MdiParent = this;
            peminjaman.Show();
        }

        private void dataBukuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            

            // Buka form login
            ParentForm pform = new ParentForm();
            this.Hide();// Set MdiParent dari form login
            FormLogin login = new FormLogin();  
            login.Show();
        }

        private void dataBukuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataBukuToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormBuku FormBuku = new FormBuku();
            FormBuku.MdiParent = this;
            FormBuku.Show();

        }

        private void dataPengembalianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPengembalian pengembalian = new FormPengembalian();
            pengembalian.MdiParent = this;
            pengembalian.Show();

        }

        private void dataMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMahasiswa mhs = new FormMahasiswa();
            mhs.MdiParent = this;
            mhs.Show();
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
