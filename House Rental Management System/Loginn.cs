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
    public partial class Loginn : Form
    {
        // MySQL Connection String
        string connectionString = "Server=127.0.0.1;Database=erent_db;User ID=root;Password=;SslMode=none;";

        public Loginn()
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
            Registrationn rn = new Registrationn();
            rn.Show();
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
                    string query = "SELECT * FROM landlord WHERE email = @Email AND password_hash = SHA2(@Password, 256)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Redirect to the dashboard or home page
                                Landlord l = new Landlord();
                                l.Show();
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            Registrationn rn = new Registrationn();
            rn.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
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

        private void label_back_Click_1(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgot f = new Forgot();
            f.Show();
            this.Hide();
        }

        private void button1_MouseEnter_1(object sender, EventArgs e)
        {
            button1.ForeColor = Color.MediumTurquoise;
            button1.BackColor = Color.White;
        }

        private void button1_MouseLeave_1(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
            button1.BackColor = Color.MediumTurquoise;
        }

        private void button2_MouseEnter_1(object sender, EventArgs e)
        {
            button2.ForeColor = Color.MediumTurquoise;
            button2.BackColor = Color.White;
        }

        private void button2_MouseLeave_1(object sender, EventArgs e)
        {
            button2.ForeColor = Color.White;
            button2.BackColor = Color.MediumTurquoise;
        }

        private void label_back_MouseEnter_1(object sender, EventArgs e)
        {
            label_back.ForeColor = Color.Red;
        }

        private void label_back_MouseLeave_1(object sender, EventArgs e)
        {
            label_back.ForeColor = Color.White ;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}