using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House_Rental_Management_System
{
    public partial class Allpro : Form
    {
        // MySQL Connection String
       // string connectionString = "Server=127.0.0.1;Database=erent_db;User ID=root;Password=;SslMode=none;";
        public Allpro()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {

            button1.ForeColor = Color.White;
            button1.BackColor = Color.MediumTurquoise;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {

            button1.ForeColor = Color.MediumTurquoise;
            button1.BackColor = Color.White;
        }

        /* private void button4_MouseEnter(object sender, EventArgs e)
         {
             button4.ForeColor = Color.White;
             button4.BackColor = Color.MediumTurquoise;
         }

        private void button4_MouseLeave(object sender, EventArgs e)
         {
             button4.ForeColor = Color.MediumTurquoise;
             button4.BackColor = Color.White;
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
         }*/

         private void button1_Click(object sender, EventArgs e)
         {
             Tenantt  tt = new Tenantt   ();
             tt.Show();
             this.Hide();
         }

         private void button4_Click(object sender, EventArgs e)
         {
            Allpro  ap = new Allpro ();
             ap.Show();
             this.Hide();
         }

         private void panel3_Paint(object sender, PaintEventArgs e)
         {

         }

        /* private void button3_Click(object sender, EventArgs e)
         {
             string area = comboBox1.Text.Trim();
             string requirement = comboBox2.Text.Trim();
             string propid = textBox1.Text.Trim();



             // Validation
             if (string.IsNullOrEmpty(area) || string.IsNullOrEmpty(requirement) || string.IsNullOrEmpty(propid))
             {
                 MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
             }


             try
             {
                 using (MySqlConnection conn = new MySqlConnection(connectionString))
                 {
                     conn.Open();
                     string query = "INSERT INTO allpro (area, requirement, propid) VALUES (@area, @requirement, @propid)";

                     using (MySqlCommand cmd = new MySqlCommand(query, conn))
                     {
                         cmd.Parameters.AddWithValue("@area", area);
                         cmd.Parameters.AddWithValue("@requirement", requirement);
                         cmd.Parameters.AddWithValue("@propid", propid);

                         int rowsAffected = cmd.ExecuteNonQuery();
                         if (rowsAffected > 0)
                         {
                             MessageBox.Show("product search successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                             //if (area == "Uttara" && requirement == "Furnished Apartment ")
                             //{
                             //    this.Hide();
                             //    UttF furnishedForm = new UttF();
                             //    furnishedForm.Show();
                             //}
                             //else if (area == "Uttara" && requirement == "Non Furnished Apartment")
                             //{
                             //    this.Hide();
                             //    UttNF nonFurnishedForm = new UttNF();
                             //    nonFurnishedForm.Show();
                             //}
                         }
                         else
                         {
                             MessageBox.Show("product search failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         }
                     }
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }*/

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            BookInfo bi = new BookInfo();
            bi.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BookInfo bi = new BookInfo();
            bi.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BookInfo bi = new BookInfo();
            bi.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            BookInfo bi = new BookInfo();
            bi.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            BookInfo bi = new BookInfo();
            bi.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            BookInfo bi = new BookInfo();
            bi.Show();
            this.Hide();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            BookInfo bi = new BookInfo();
            bi.Show();
            this.Hide();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            BookInfo bi = new BookInfo();
            bi.Show();
            this.Hide();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            BookInfo bi = new BookInfo();
            bi.Show();
            this.Hide();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            BookInfo bi = new BookInfo();
            bi.Show();
            this.Hide();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            BookInfo bi = new BookInfo();
            bi.Show();
            this.Hide();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            BookInfo bi = new BookInfo();
            bi.Show();
            this.Hide();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            BookInfo bi = new BookInfo();
            bi.Show();
            this.Hide();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            BookInfo bi = new BookInfo();
            bi.Show();
            this.Hide();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            BookInfo bi = new BookInfo();
            bi.Show();
            this.Hide();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            BookInfo bi = new BookInfo();
            bi.Show();
            this.Hide();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            BookInfo bi = new BookInfo();
            bi.Show();
            this.Hide();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            BookInfo bi = new BookInfo();
            bi.Show();
            this.Hide();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            BookInfo bi = new BookInfo();
            bi.Show();
            this.Hide();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            BookInfo bi = new BookInfo();
            bi.Show();
            this.Hide();
        }

        private void button52_Click(object sender, EventArgs e)
        {
            BookInfo bi = new BookInfo();
            bi.Show();
            this.Hide();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            BookInfo bi = new BookInfo();
            bi.Show();
            this.Hide();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            BookInfo bi = new BookInfo();
            bi.Show();
            this.Hide();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            BookInfo bi = new BookInfo();
            bi.Show();
            this.Hide();
        }

        private void button74_Click(object sender, EventArgs e)
        {
            BookInfo bi = new BookInfo();
            bi.Show();
            this.Hide();
        }

        private void button72_Click(object sender, EventArgs e)
        {
            BookInfo bi = new BookInfo();
            bi.Show();
            this.Hide();
        }

        private void button70_Click(object sender, EventArgs e)
        {
            BookInfo bi = new BookInfo();
            bi.Show();
            this.Hide();
        }

        private void button68_Click(object sender, EventArgs e)
        {
            BookInfo bi = new BookInfo();
            bi.Show();
            this.Hide();
        }

        private void button66_Click(object sender, EventArgs e)
        {
            BookInfo bi = new BookInfo();
            bi.Show();
            this.Hide();
        }

        private void button64_Click(object sender, EventArgs e)
        {
            BookInfo bi = new BookInfo();
            bi.Show();
            this.Hide();
        }

        private void button86_Click(object sender, EventArgs e)
        {
            BookInfo bi = new BookInfo();
            bi.Show();
            this.Hide();
        }

        private void button84_Click(object sender, EventArgs e)
        {
            BookInfo bi = new BookInfo();
            bi.Show();
            this.Hide();
        }

        private void button82_Click(object sender, EventArgs e)
        {
            BookInfo bi = new BookInfo();
            bi.Show();
            this.Hide();
        }

        private void button76_Click(object sender, EventArgs e)
        {
            BookInfo bi = new BookInfo();
            bi.Show();
            this.Hide();
        }

        private void button80_Click(object sender, EventArgs e)
        {
            BookInfo bi = new BookInfo();
            bi.Show();
            this.Hide();
        }

        private void button78_Click(object sender, EventArgs e)
        {
            BookInfo bi = new BookInfo();
            bi.Show();
            this.Hide();
        }
    }
}
