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
    public partial class GulshanF : Form
    {
        public GulshanF()
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

       /* private void button3_MouseEnter(object sender, EventArgs e)
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            BookInfo bi = new BookInfo();
            bi.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
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
    }
}
