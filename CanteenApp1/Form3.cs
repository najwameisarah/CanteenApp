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
using System.Xml.Linq;


namespace CanteenApp1
{
    public partial class Userinputmenu : Form
    {
        string connectionString = @"Server=LAPTOP-T0VGVVC9\SQLEXPRESS;Database=DB_Canteen;Integrated Security=True;Encrypt=False;";

        private int? setId;

        public Userinputmenu(int? setId = null)
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Interval = 1000; // Set interval ke 1 detik
            timer1.Tick += new EventHandler(guna2HtmlLabel1_Click); // Event handler untuk Timer
            timer1.Start();
            this.setId = setId;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Userdb userdb = new Userdb(); // Buat instance dari AdminMenu
            userdb.Show(); // Tampilkan form AdminMenu
            this.Hide(); // Sembunyikan form saat ini (AdminForm)
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

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

        private void menuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();


        }

        private void Userinputmenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_CanteenDataSet.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.dB_CanteenDataSet.Menu);

            // Kosongkan input fields
            txtNamaMenu.Clear();
            txtHPP.Clear();
            txtHarga.Clear();
            txtStock.Clear();
            txtNamaSupplier.Clear();
            setIdNumericUpDown.Value = 1;

            // TODO: This line of code loads data into the 'dB_CanteenDataSet.Menu' table. You can move, or remove it, as needed.

        }

        private void menuBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.menuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_CanteenDataSet);

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            string menuName = txtNamaMenu.Text.Trim();

            if (string.IsNullOrEmpty(menuName))
            {
                MessageBox.Show("Nama menu tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Cek apakah nama menu sudah ada di database
                    string checkQuery = "SELECT COUNT(*) FROM Menu WHERE NamaMenu = @NamaMenu";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@NamaMenu", menuName);
                    int existingCount = (int)checkCmd.ExecuteScalar();

                    if (existingCount > 0)
                    {
                        MessageBox.Show("Nama menu sudah ada! Gunakan nama lain.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Jika tidak ada, lanjutkan insert
                    string query = "INSERT INTO Menu (NamaMenu, HPP, Harga, SetId, Stock, NamaSupplier) VALUES (@NamaMenu, @HPP, @Harga, @SetId, @Stock, @NamaSupplier)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@NamaMenu", menuName);
                    cmd.Parameters.AddWithValue("@HPP", txtHPP.Text);
                    cmd.Parameters.AddWithValue("@Harga", txtHarga.Text);
                    cmd.Parameters.AddWithValue("@SetId", setIdNumericUpDown.Value);
                    cmd.Parameters.AddWithValue("@Stock", txtStock.Text);
                    cmd.Parameters.AddWithValue("@NamaSupplier", txtNamaSupplier.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data berhasil ditambahkan!");

                        // Bersihkan input setelah insert sukses
                        txtNamaMenu.Clear();
                        txtHPP.Clear();
                        txtHarga.Clear();
                        txtStock.Clear();
                        txtNamaSupplier.Clear();
                        setIdNumericUpDown.Value = 1;

                        // Update tampilan di form lain
                        UserLaporanPenjualan.Instance?.UpdateListBox(menuName);
                        Adminlaporanpenjualan.Instance?.LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Data tidak berhasil ditambahkan. Cek kembali input dan database.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                UserLaporanPenjualan.Instance.UpdateListBox(menuName);

                // Refresh DataGridView di Admin Laporan Penjualan
                Adminlaporanpenjualan.Instance.LoadData();

                txtNamaMenu.Clear();

                Userinputmenu form = new Userinputmenu(setId); // Kirim setId saat pindah view
                form.Show();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
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

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            ViewMenu Viewmenu = new ViewMenu(); // Ganti "Form1" dengan nama form login kamu
            Viewmenu.Show();
            this.Hide(); // Menyembunyikan form saat ini
        }
    }
}
