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

    public partial class Adminlaporanpenjualan : Form
    {
        private string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=DB_Canteen;Integrated Security=True";

        private static Adminlaporanpenjualan _instance;
        public static Adminlaporanpenjualan Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Adminlaporanpenjualan();
                return _instance;
            }
        }

        public Adminlaporanpenjualan()
        {
            InitializeComponent();
            LoadData();
            timer1 = new Timer();
            timer1.Interval = 1000; // Set interval ke 1 detik
            timer1.Tick += new EventHandler(guna2HtmlLabel1_Click); // Event handler untuk Timer
            timer1.Start();
        }
        public void LoadData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM Penjualan"; // Sesuaikan dengan tabel di database
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    penjualanDataGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void penjualanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.penjualanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_CanteenDataSet);

        }

        private void adminlaporanpenjualan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_CanteenDataSet.Penjualan' table. You can move, or remove it, as needed.
            this.penjualanTableAdapter.Fill(this.dB_CanteenDataSet.Penjualan);

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
            this.Hide(); // Sembunyikan form saat ini (AdminForm)
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            login1 loginForm = new login1(); // Ganti "Form1" dengan nama form login kamu
            loginForm.Show();
            this.Hide(); // Menyembunyikan form saat ini
        }

        private void penjualanDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void penjualanDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            guna2HtmlLabel1.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");

        }
    }
}
