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
    public partial class UttNF : Form
    {
        public UttNF()
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

        
        private void button1_Click(object sender, EventArgs e)
        {
            Tenantt tt = new Tenantt();
            tt.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Allpro ap = new Allpro();
            ap.Show();
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
