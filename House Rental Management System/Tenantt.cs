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
    public partial class Tenantt : Form
    {
        public Tenantt()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Allpro ap = new Allpro();
            ap.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UttF uf = new UttF();
            uf.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UttNF unf = new UttNF();
            unf.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           GulshanF gf = new GulshanF();
            gf.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GulshanNF gnf = new GulshanNF();
            gnf.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MohF mf = new MohF();
            mf.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MohNF mnf = new MohNF();
            mnf.Show();
            this.Hide();
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

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.White;
            button2.BackColor = Color.MediumTurquoise;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.MediumTurquoise;
            button2.BackColor = Color.White;
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

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.ForeColor = Color.MediumTurquoise;
            button7.BackColor = Color.White;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.ForeColor = Color.White;
            button7.BackColor = Color.MediumTurquoise;
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.ForeColor = Color.MediumTurquoise;
            button8.BackColor = Color.White;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.ForeColor = Color.White;
            button8.BackColor = Color.MediumTurquoise;
        }
    }
}
