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
    public partial class LandBut : Form
    {
        string connectionString = "Server=127.0.0.1;Database=erent_db;User ID=root;Password=;SslMode=none;";
        public LandBut()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Open connection to the database
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    // SQL query to select all data from the INFO table
                    string query = "SELECT * FROM LINFO";
                    // Create a MySqlCommand object with the query and connection
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Create a MySqlDataAdapter object
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        // Create a new DataTable to hold the data
                        System.Data.DataTable dt = new System.Data.DataTable();
                        // Fill the DataTable with the data from the database
                        adapter.Fill(dt);
                        // Bind the DataTable to the DataGridView
                        dataGridView1.DataSource = dt;  // Directly bind to DataGridView
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the clicked row
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                // Access individual cells
                string address = row.Cells["Address"].Value.ToString();
                string road = row.Cells["Road"].Value.ToString();
                string bedroom = row.Cells["Bedroom"].Value.ToString();
                string washroom = row.Cells["Washroom"].Value.ToString();
                string email = row.Cells["Email"].Value.ToString();
                string area = row.Cells["Area"].Value.ToString();
                string price = row.Cells["Price"].Value.ToString();
                string contactNumber = row.Cells["ContactPhonenumber"].Value.ToString();
                // Show message box or perform any other action with the data
                MessageBox.Show($"Address: {address}\nRoad: {road} \nBedroom: {bedroom}\nWashroom: {washroom}\nEmail: {email}\nArea: {area}\nPrice: {price}\nContact: {contactNumber}", "Row Clicked", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (!int.TryParse(textBox1.Text, out id))
                {
                    MessageBox.Show("Please enter a valid numeric ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM LINFO WHERE ID = @ID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", id);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            button2_Click(sender, e); // Refresh DataGridView
                        }
                        else
                        {
                            MessageBox.Show("No record found with the entered ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.ForeColor = Color.MediumTurquoise;
            button5.BackColor = Color.White;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.ForeColor = Color.White;
            button5.BackColor = Color.MediumTurquoise;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.ForeColor = Color.MediumTurquoise;
            button3.BackColor = Color.White;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.White;
            button3.BackColor = Color.MediumTurquoise;
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.ForeColor = Color.MediumTurquoise;
            button6.BackColor = Color.White;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.ForeColor = Color.White;
            button6.BackColor = Color.MediumTurquoise;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.ForeColor = Color.White;
            button7.BackColor = Color.Red;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.ForeColor = Color.Red;
            button7.BackColor = Color.White;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Show();
            this.Hide();
        }
    }
}