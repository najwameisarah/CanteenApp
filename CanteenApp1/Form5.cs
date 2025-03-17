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
    public partial class UserLaporanPenjualan : Form
    {
        private static UserLaporanPenjualan instance;

        public static UserLaporanPenjualan Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserLaporanPenjualan();
                }
                return instance;
            }
        }

        public UserLaporanPenjualan()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Interval = 1000; // Set interval ke 1 detik
            timer1.Tick += new EventHandler(guna2HtmlLabel1_Click); // Event handler untuk Timer
            timer1.Start();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Userdb userdb = new Userdb();
            userdb.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Userinputmenu userinputmenu = new Userinputmenu();
            userinputmenu.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UserAbsensi userabsensi = new UserAbsensi();
            userabsensi.Show();
            this.Hide();
        }

        private void penjualanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.penjualanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_CanteenDataSet);
        }

        private void UserLaporanPenjualan_Load(object sender, EventArgs e)
        {
            this.penjualanTableAdapter.Fill(this.dB_CanteenDataSet.Penjualan);
            LoadMenuList();

            // Kosongkan input saat form pertama kali dimuat
            namaMenuListBox.ClearSelected();
            stockAkhirTextBox.Text = "";
            setIdNumericUpDown.Value = 1;
            keuntunganTextBox.Text = "";
            tanggalPenjualanDateTimePicker.Value = DateTime.Now;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (namaMenuListBox.SelectedItem == null)
            {
                MessageBox.Show("Silakan pilih menu terlebih dahulu!");
                return;
            }

            try
            {
                // Ambil nilai dari inputan
                string selectedMenu = namaMenuListBox.SelectedItem.ToString();
                int stockAkhir = 0;
                int setId = 0;
                int keuntungan = 0;

                // Validasi apakah input angka tidak kosong atau tidak valid
                if (!int.TryParse(stockAkhirTextBox.Text, out stockAkhir) ||
                    !int.TryParse(setIdNumericUpDown.Value.ToString(), out setId) ||
                    !int.TryParse(keuntunganTextBox.Text, out keuntungan))
                {
                    MessageBox.Show("Pastikan semua angka sudah diisi dengan benar!");
                    return;
                }

                string connectionString = @"Server=LAPTOP-T0VGVVC9\SQLEXPRESS;Database=DB_Canteen;Integrated Security=True;Encrypt=False;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Penjualan (NamaMenu, StockAkhir, SetId, Keuntungan, TanggalPenjualan) " +
                   "VALUES (@NamaMenu, @StockAkhir, @SetId, @Keuntungan, @TanggalPenjualan)";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NamaMenu", namaMenuListBox.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@StockAkhir", int.Parse(stockAkhirTextBox.Text));
                        cmd.Parameters.AddWithValue("@SetId", int.Parse(setIdNumericUpDown.Text));
                        cmd.Parameters.AddWithValue("@Keuntungan", int.Parse(keuntunganTextBox.Text));
                        cmd.Parameters.AddWithValue("@TanggalPenjualan", DateTime.Parse(tanggalPenjualanDateTimePicker.Text));

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Data berhasil ditambahkan!");

                            // Kosongkan semua input setelah data ditambahkan
                            namaMenuListBox.ClearSelected(); // Menghapus pilihan di ListBox
                            stockAkhirTextBox.Text = "";
                            setIdNumericUpDown.Value = 1; // Atur ke nilai default
                            keuntunganTextBox.Text = "";
                            tanggalPenjualanDateTimePicker.Value = DateTime.Now; // Atur ke tanggal saat ini
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void LoadMenuList()
        {
            namaMenuListBox.Items.Clear();

            string connectionString = @"Server=LAPTOP-T0VGVVC9\SQLEXPRESS;Database=DB_Canteen;Integrated Security=True;Encrypt=False;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT NamaMenu FROM Menu";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    namaMenuListBox.Items.Add(reader["NamaMenu"].ToString());
                }

                reader.Close();
            }
        }

        private void namaMenuListBox_SelectedIndexChanged(object sender, EventArgs e)
        {     
        }

        public void UpdateListBox(string menuName)
        {
            namaMenuListBox.Items.Add(menuName);
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

            login1 loginForm = new login1(); // Ganti "Form1" dengan nama form login kamu
            loginForm.Show();
            this.Hide(); // Menyembunyikan form saat ini
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            ViewPenjualan Viewpenjualan = new ViewPenjualan();
            Viewpenjualan.Show();
            this.Hide();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            guna2HtmlLabel1.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        }
    }
    }
