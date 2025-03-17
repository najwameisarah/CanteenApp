using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace CanteenApp1
{
    public partial class UserAbsensi : Form
    {
        string connectionString = @"Data Source=LAPTOP-T0VGVVC9\SQLEXPRESS;Initial Catalog=DB_Canteen;Integrated Security=True;Trust Server Certificate=True";

        public UserAbsensi()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Interval = 1000; // Set interval ke 1 detik
            timer1.Tick += new EventHandler(guna2HtmlLabel1_Click); // Event handler untuk Timer
            timer1.Start();
        }

        private void UserAbsensi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_CanteenDataSet.Absensi' table. You can move, or remove it, as needed.
            this.absensiTableAdapter.Fill(this.dB_CanteenDataSet.Absensi);

        }
        private void fotoPictureBox_DragEnter(object sender, DragEventArgs e)
        {
            // Jika yang diseret adalah file, ubah efeknya jadi Copy
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void fotoPictureBox_DragDrop(object sender, DragEventArgs e)
        {
            // Ambil file yang didrop
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files.Length > 0)
            {
                try
                {
                    // Tampilkan gambar di PictureBox
                    fotoPictureBox.Image = Image.FromFile(files[0]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat gambar: " + ex.Message);
                }
            }
        }

        

        private void fotoPictureBox_Click(object sender, EventArgs e)
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
            ViewAbsensi Viewabsensi = new ViewAbsensi(); // Ganti "Form1" dengan nama form login kamu
            Viewabsensi.Show();
            this.Hide(); // Menyembunyikan form saat ini
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Userdb userdb = new Userdb(); // Buat instance dari AdminMenu
            userdb.Show(); // Tampilkan form AdminMenu
            this.Hide(); // Sembunyikan form saat ini (AdminForm)
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Userinputmenu userinputmenu = new Userinputmenu();
            userinputmenu.Show();
            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

            UserLaporanPenjualan userlaporanpenjualan = new UserLaporanPenjualan(); // Buat instance dari AdminMenu
            userlaporanpenjualan.Show(); // Tampilkan form AdminMenu
            this.Hide(); // Sembunyikan form saat ini (AdminForm)
        }

        private void guna2Button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Koneksi ke database
                string connectionString = "Data Source=YOUR_SERVER;Initial Catalog=YOUR_DATABASE;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Ambil gambar dari PictureBox
                    MemoryStream ms = new MemoryStream();
                    fotoPictureBox.Image.Save(ms, fotoPictureBox.Image.RawFormat);
                    byte[] fotoBytes = ms.ToArray();

                    // Query SQL untuk insert data
                    string query = "INSERT INTO Absensi (Name, Kelas, SetAbsen, Tanggal, Waktu, Foto) VALUES (@Name, @Kelas, @SetAbsen, @Tanggal, @Waktu, @Foto)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", txtName.Text);
                        cmd.Parameters.AddWithValue("@Kelas", txtKelas.Text);
                        cmd.Parameters.AddWithValue("@SetAbsen", numericSetAbsen.Value);
                        cmd.Parameters.AddWithValue("@Tanggal", tanggalDateTimePicker.Value);
                        cmd.Parameters.AddWithValue("@Waktu", txtWaktu.Text);
                        cmd.Parameters.AddWithValue("@Foto", fotoBytes);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

