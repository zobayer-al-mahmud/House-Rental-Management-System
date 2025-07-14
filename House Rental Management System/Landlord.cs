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
    public partial class Landlord : Form
    {
        string connectionString = "Server=127.0.0.1;Database=erent_db;User ID=root;Password=;SslMode=none;";
        public Landlord()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All Files (*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    image1.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {

            button4.ForeColor = Color.White;
            button4.BackColor = Color.MediumTurquoise;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.ForeColor = Color.MediumTurquoise;
            button4.BackColor = Color.White;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home ();
            h.Show();
            this.Hide();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get values from textboxes
            string address = textBox8.Text.Trim();
            string road = textBox3.Text.Trim();
            string bedroom = textBox2.Text.Trim();
            string washroom = textBox1.Text.Trim();
            string email = textBox7.Text.Trim();
            string area = textBox4.Text.Trim();
            string price = textBox5.Text.Trim();
            string contactPhoneNumber = textBox6.Text.Trim();

            // Validation: Check if any field is empty
            if (string.IsNullOrEmpty(address) || string.IsNullOrEmpty(road) || string.IsNullOrEmpty(bedroom) || string.IsNullOrEmpty(washroom) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(area) || string.IsNullOrEmpty(price) || string.IsNullOrEmpty(contactPhoneNumber))
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
                    string query = "INSERT INTO LINFO (Address, Road, Bedroom, Washroom, Email, AreaSize, Price, ContactPhoneNumber) VALUES (@Address, @Road, @Bedroom, @Washroom, @Email, @AreaSize, @Price, @ContactPhoneNumber)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@Road", road);
                        cmd.Parameters.AddWithValue("@Bedroom", bedroom);
                        cmd.Parameters.AddWithValue("@Washroom", washroom);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@AreaSize", area);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@ContactPhoneNumber", contactPhoneNumber);

                        // Execute the query to insert the data
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Add successfully stored!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                // After storing data, open the Admin form and hide the current one
                Landlord l = new Landlord();
                l.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.ForeColor = Color.White;
            button3.BackColor = Color.MediumTurquoise;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.MediumTurquoise;
            button3.BackColor = Color.White;
        }
    }
}
