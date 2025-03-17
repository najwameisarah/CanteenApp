using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CanteenApp1
{
    public partial class ViewPenjualan : Form
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
        public ViewPenjualan()
        {
            InitializeComponent();
            LoadData();
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

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_CanteenDataSet.Penjualan' table. You can move, or remove it, as needed.
            this.penjualanTableAdapter.Fill(this.dB_CanteenDataSet.Penjualan);

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ViewMenu Viewmenu = new ViewMenu(); // Ganti "Form1" dengan nama form login kamu
            Viewmenu.Show();
            this.Hide(); // Menyembunyikan form saat ini
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            ViewAbsensi Viewabsensi = new ViewAbsensi(); // Ganti "Form1" dengan nama form login kamu
            Viewabsensi.Show();
            this.Hide(); // Menyembunyikan form saat ini
        }

        private void penjualanDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Userdb userdb = new Userdb();
            userdb.Show();
            this.Hide();
        }
    }
}
