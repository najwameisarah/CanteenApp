using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CanteenApp1
{
    public partial class login1 : Form
    {
        string connectionString = @"Data Source=LAPTOP-T0VGVVC9\SQLEXPRESS;Initial Catalog=DB_Canteen;Integrated Security=True;Trust Server Certificate=True";
        public login1()
        {
            InitializeComponent();
        }

        private bool ValidateUser(string username, string password, string role)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(1) FROM Users WHERE Username=@username AND Password=@password AND Role=@role";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password); // Sebaiknya pakai hashing
                cmd.Parameters.AddWithValue("@role", role);

                conn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (guna2ComboBox1.Items.Count == 0) // Mencegah duplikasi
            {
                guna2ComboBox1.Items.Add("Admin");
                guna2ComboBox1.Items.Add("User");
            }
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked == true)
            {
                guna2TextBox2.UseSystemPasswordChar = false;
            }
            else
            {
                guna2TextBox2.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = guna2TextBox1.Text.Trim();
            string password = guna2TextBox2.Text.Trim();
            string role = guna2ComboBox1.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username dan Password harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Silakan pilih Role!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (role == "Admin")
            {
                if (username == "admin123" && password == "admin1")
                {
                    MessageBox.Show("Login Admin berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    AdminDB AdminDBs = new AdminDB();
                    AdminDBs.Show();
                }
                else
                {
                    MessageBox.Show("Username atau Password Admin salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (role == "User")
            {
                if (ValidateUser(username, password, role))
                {
                    MessageBox.Show("Login User berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Userdb userdb = new Userdb();
                    userdb.Show();
                }
                else
                {
                    MessageBox.Show("Username atau Password User salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
