using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace House_Rental_Management_System
{
    public partial class Login : Form
    {
        // MySQL Connection String
        string connectionString = "Server=127.0.0.1;Database=erent_db;User ID=root;Password=;SslMode=none;";

        public Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void label_back_MouseEnter(object sender, EventArgs e)
        {
            label_back.ForeColor = Color.Red;
        }

        private void label_back_MouseLeave(object sender, EventArgs e)
        {
            label_back.ForeColor = Color.White;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.MediumTurquoise;
            button1.BackColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
            button1.BackColor = Color.MediumTurquoise;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.MediumTurquoise;
            button2.BackColor = Color.White;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.White;
            button2.BackColor = Color.MediumTurquoise;
        }

        private void label_back_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration r = new Registration();
            r.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgot f = new Forgot();
            f.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Email input (No logic needed here)
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Password input (No logic needed here)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text.Trim();
            string password = textBox2.Text;

            // Validation
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Check if the email and password match the admin table
                    string adminQuery = "SELECT * FROM admin WHERE email = @Email AND password = @Password";

                    using (MySqlCommand cmd = new MySqlCommand(adminQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password); // Assuming the password is stored in plain text, otherwise, hash it as needed

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                // Admin credentials match, redirect to Admin Home Page
                                MessageBox.Show("Login successful as Admin!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Admin adminHome = new Admin(); // Redirect to Admin Home page
                                adminHome.Show();
                                this.Hide();
                                return; // Exit to prevent checking user credentials if admin is matched
                            }
                        }
                    }

                    // Check if the email and password match the user table
                    string userQuery = "SELECT * FROM users WHERE email = @Email AND password_hash = SHA2(@Password, 256)";

                    using (MySqlCommand cmd = new MySqlCommand(userQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password); // Password hashing already considered in the query

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                // User credentials match, redirect to User Home Page
                                MessageBox.Show("Login successful as User!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Tenantt  tt = new Tenantt (); // Redirect to User Home page
                                tt.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid email or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}