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
using System.IO;
using OfficeOpenXml;
using ExcelLicense = OfficeOpenXml.LicenseContext;


namespace CanteenApp1
{
    public partial class AdminMenu : Form
    {
        string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=DB_Canteen;Integrated Security=True";

        private int? setId;
        public AdminMenu(int? setId = null)
        {
            InitializeComponent();
            this.setId = setId;
            LoadData();
            timer1 = new Timer();
            timer1.Interval = 1000; // Set interval ke 1 detik
            timer1.Tick += new EventHandler(guna2HtmlLabel1_Click); // Event handler untuk Timer
            timer1.Start();

        }

        private void menuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.menuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_CanteenDataSet);

        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_CanteenDataSet.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.dB_CanteenDataSet.Menu);
            LoadData();

        }
        private void LoadData()
        {
            string query;
            if (setId.HasValue) // Jika User, filter data berdasarkan setId
            {
                query = "SELECT * FROM menu WHERE setId = @setId";
            }
            else // Jika Admin, tampilkan semua
            {
                query = "SELECT * FROM menu";
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (setId.HasValue) // Jika User, tambahkan parameter setId
                    {
                        cmd.Parameters.AddWithValue("@setId", setId.Value);
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    menuDataGridView.DataSource = dt;
                }
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AdminDB AdminDBs = new AdminDB();
            AdminDBs.Show();
            this.Hide();
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

        private void menuDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            login1 loginForm = new login1(); // Ganti "Form1" dengan nama form login kamu
            loginForm.Show();
            this.Hide(); // Menyembunyikan form saat ini
        }

        private void menuDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            guna2HtmlLabel1.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");

        }
        private SaveFileDialog saveFileDialog = new SaveFileDialog();
        private void Export_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Excel File (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Save as Excel File";
            saveFileDialog.FileName = "DataMenu.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                AdminMenu.ExportToExcell(menuDataGridView, path);

            }
        }
        public static void ExportToExcell(DataGridView dataGridView, string path)
        {
            try
            {
                OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                using (ExcelPackage excel = new ExcelPackage())
                {
                    var ws = excel.Workbook.Worksheets.Add("Data Menu");

                    // Set header sesuai tabel di gambar
                    string[] headers = { "Id", "NamaMenu", "HPP", "Harga", "SetId", "Stock", "NamaSupplier" };
                    for (int col = 0; col < headers.Length; col++)
                    {
                        ws.Cells[1, col + 1].Value = headers[col];
                        ws.Cells[1, col + 1].Style.Font.Bold = true;
                    }

                    // Ambil data dari DataGridView
                    for (int row = 0; row < dataGridView.Rows.Count; row++)
                    {
                        for (int col = 0; col < headers.Length; col++)
                        {
                            ws.Cells[row + 2, col + 1].Value = dataGridView.Rows[row].Cells[col].Value?.ToString();
                        }
                    }

                    // Simpan ke file
                    FileInfo excelFile = new FileInfo(path);
                    excel.SaveAs(excelFile);

                    MessageBox.Show("File Excel berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
