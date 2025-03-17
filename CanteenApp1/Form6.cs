using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanteenApp1
{
    public partial class AdminDB : Form
    {
        public AdminDB()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Interval = 1000; // Set interval ke 1 detik
            timer1.Tick += new EventHandler(guna2HtmlLabel2_Click); // Event handler untuk Timer
            timer1.Start();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu(); // Buat instance dari AdminMenu
            adminMenu.Show(); // Tampilkan form AdminMenu
            this.Hide(); // Sembunyikan form saat ini (AdminForm)
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Adminabsensi adminAbsensi = new Adminabsensi(); // Buat instance dari AdminMenu
            adminAbsensi.Show(); // Tampilkan form AdminMenu
            this.Hide(); // Sembunyikan form saat ini (AdminForm)
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Adminlaporanpenjualan adminPenjualan = new Adminlaporanpenjualan(); // Buat instance dari AdminMenu
            adminPenjualan.Show(); // Tampilkan form AdminMenu
            this.Hide(); // Sembunyikan form saat ini (AdminForm)
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            AdminKelolaUser adminKelola = new AdminKelolaUser(); // Buat instance dari AdminMenu
            adminKelola.Show(); // Tampilkan form AdminMenu
            this.Hide(); // Sembunyikan form saat ini (AdminForm)
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            login1 loginForm = new login1(); // Ganti "Form1" dengan nama form login kamu
            loginForm.Show();
            this.Hide(); // Menyembunyikan form saat ini
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
            guna2HtmlLabel2.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");

        }
    }
}
