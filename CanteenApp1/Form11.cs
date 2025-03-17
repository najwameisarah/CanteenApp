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
    public partial class ViewMenu : Form
    {
        string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=DB_Canteen;Integrated Security=True";

        public ViewMenu()
        {
            InitializeComponent();
        }

        private void menuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.menuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_CanteenDataSet);

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_CanteenDataSet.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.dB_CanteenDataSet.Menu);
            LoadData();

        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT * FROM Menu";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    menuDataGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void buttonMenu_Click(object sender, EventArgs e)
        {

        }

        private void buttonAbsensi_Click(object sender, EventArgs e)
        {

            ViewAbsensi Viewabsensi = new ViewAbsensi(); // Ganti "Form1" dengan nama form login kamu
            Viewabsensi.Show();
            this.Hide(); // Menyembunyikan form saat ini
        }

        private void buttonPenjualan_Click(object sender, EventArgs e)
        {
            ViewPenjualan Viewpenjualan = new ViewPenjualan();
            Viewpenjualan.Show();
            this.Hide();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Userdb userdb = new Userdb();
            userdb.Show();
            this.Hide();
        }

        private void menuDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
