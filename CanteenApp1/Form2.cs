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
    public partial class Userdb : Form
    {
        public Userdb()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Interval = 1000; // Set interval ke 1 detik
            timer1.Tick += new EventHandler(guna2HtmlLabel1_Click); // Event handler untuk Timer
            timer1.Start();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Userinputmenu userinputmenu = new Userinputmenu(); // Buat instance dari AdminMenu
            userinputmenu.Show(); // Tampilkan form AdminMenu
            this.Hide(); // Sembunyikan form saat ini (AdminForm)
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UserAbsensi userabsensi = new UserAbsensi(); // Buat instance dari AdminMenu
            userabsensi.Show(); // Tampilkan form AdminMenu
            this.Hide(); // Sembunyikan form saat ini (AdminForm)
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            UserLaporanPenjualan userlaporanpenjualan = new UserLaporanPenjualan(); // Buat instance dari AdminMenu
            userlaporanpenjualan.Show(); // Tampilkan form AdminMenu
            this.Hide(); // Sembunyikan form saat ini (AdminForm)
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            guna2HtmlLabel1.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            login1 loginForm = new login1(); // Ganti "Form1" dengan nama form login kamu
            loginForm.Show();
            this.Hide(); // Menyembunyikan form saat ini
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
