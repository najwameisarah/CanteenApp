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
    public partial class Adminabsensi : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-T0VGVVC9\\SQLEXPRESS;Initial Catalog=DB_Canteen;Integrated Security=True");

        public Adminabsensi()
        {
            InitializeComponent();
            
            timer1 = new Timer();
            timer1.Interval = 1000; // Set interval ke 1 detik
            timer1.Tick += new EventHandler(guna2HtmlLabel1_Click); // Event handler untuk Timer
            timer1.Start();

        }

        private void absensiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.absensiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_CanteenDataSet);

        }

        private void Adminabsensi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_CanteenDataSet.Absensi' table. You can move, or remove it, as needed.
            this.absensiTableAdapter.Fill(this.dB_CanteenDataSet.Absensi);
            LoadData();

        }
        private void LoadData()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM absensi";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                absensiDataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

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

        private void absensiDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            login1 loginForm = new login1(); // Ganti "Form1" dengan nama form login kamu
            loginForm.Show();
            this.Hide(); // Menyembunyikan form saat ini
        }

        private void absensiDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            guna2HtmlLabel1.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");

        }
    }
}
