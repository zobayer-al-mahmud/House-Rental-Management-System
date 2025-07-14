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
    public partial class GulshanNF : Form
    {
        public GulshanNF()
        {
            InitializeComponent();
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

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.ForeColor = Color.MediumTurquoise;
            button4.BackColor = Color.White;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.ForeColor = Color.White;
            button4.BackColor = Color.MediumTurquoise;
        }

      /*  private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.ForeColor = Color.White;
            button3.BackColor = Color.MediumTurquoise;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.MediumTurquoise;
            button3.BackColor = Color.White;
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
    }
    
}
