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
    public partial class ViewAbsensi : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-T0VGVVC9\\SQLEXPRESS;Initial Catalog=DB_Canteen;Integrated Security=True");

        public ViewAbsensi()
        {
            InitializeComponent();
        }

        private void absensiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.absensiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_CanteenDataSet);

        }

        private void Form12_Load(object sender, EventArgs e)
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
        private void guna2Button2_Click(object sender, EventArgs e)
        {

            ViewMenu Viewmenu = new ViewMenu(); // Ganti "Form1" dengan nama form login kamu
            Viewmenu.Show();
            this.Hide(); // Menyembunyikan form saat ini
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            ViewPenjualan Viewpenjualan = new ViewPenjualan();
            Viewpenjualan.Show();
            this.Hide();
        }

        private void absensiDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
