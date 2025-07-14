using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace House_Rental_Management_System
{
    public partial class BookInfo : Form
    {
        // MySQL connection string
        string connectionString = "Server=127.0.0.1;Database=erent_db;User ID=root;Password=;SslMode=none;";

        public BookInfo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get values from textboxes
            string name = textBox1.Text.Trim();
            string email = textBox2.Text.Trim();
            string contactPhoneNumber = textBox3.Text.Trim();

            // Validation: Check if any field is empty
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(contactPhoneNumber))
            {
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // SQL Query to insert the data into the INFO table
                    string query = "INSERT INTO INFO (Name, Email, ContactPhoneNumber) VALUES (@Name, @Email, @ContactPhoneNumber)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@ContactPhoneNumber", contactPhoneNumber);

                        // Execute the query to insert the data
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Booking successfully stored!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                // After storing data, open the Admin form and hide the current one
                Tenantt  tt = new Tenantt ();
                tt.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void BookInfo_Load(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label_back_Click(object sender, EventArgs e)
        {
            Tenantt  tt = new Tenantt ();
            tt.Show();
            this.Hide();
        }

        private void label_back_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
          
        }
    }
}