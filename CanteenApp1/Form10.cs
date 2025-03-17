using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanteenApp1
{
    public partial class AdminKelolaUser : Form
    {
        public AdminKelolaUser()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_CanteenDataSet);

        }

        private void AdminKelolaUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_CanteenDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dB_CanteenDataSet.users);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            AdminDB AdminDBs = new AdminDB();
            AdminDBs.Show();
            this.Hide();
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
            this.Hide(); // Sembunyikan form saat ini (AdminForm)

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            login1 loginForm = new login1(); // Ganti "Form1" dengan nama form login kamu
            loginForm.Show();
            this.Hide(); // Menyembunyikan form saat ini
        }
    }
}
