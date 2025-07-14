using System;
using System.Net;
using System.Net.Mail;
using System.Drawing;
using System.Windows.Forms;

namespace House_Rental_Management_System
{
    public partial class Forgot : Form
    {
        private string generatedOtp; // Store OTP for verification

        public Forgot()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            button2.ForeColor = Color.White;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        // ✅ Button to send OTP
        private void buttonSendOtp_Click(object sender, EventArgs e)
        {
            
        }

        // ✅ Method to send OTP email


        // ✅ Method to send OTP email using Google SMTP
        private void SendOtpEmail(string recipientEmail)
        {
            try
            {
                // Generate a random 6-digit OTP
                Random rnd = new Random();
                generatedOtp = rnd.Next(100000, 999999).ToString();

                // Configure email sender and credentials
                string senderEmail = "your-email@gmail.com"; // Replace with your Gmail address
                string senderPassword = "your-app-password"; // Replace with App Password from Google

                // Create email message
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(senderEmail);
                mail.To.Add(recipientEmail);
                mail.Subject = "Your OTP Code";
                mail.Body = $"Your OTP is: {generatedOtp}\n\nThis OTP is valid for 10 minutes.";

                // Setup SMTP client
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587); // Use port 587 (TLS)
                smtp.Credentials = new NetworkCredential(senderEmail, senderPassword);
                smtp.EnableSsl = true;

                // Send email
                smtp.Send(mail);
                MessageBox.Show("✅ OTP sent successfully! Check your email.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SmtpException smtpEx)
            {
                MessageBox.Show($"❌ SMTP Error: {smtpEx.Message}\nCheck your email settings and App Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ General Error: {ex.Message}\nPlease check your internet connection or email details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Otp o = new Otp();
            o.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string userEmail = textBox1.Text; // Assume textBox1 is the email input field

            if (string.IsNullOrEmpty(userEmail))
            {
                MessageBox.Show("Please enter your email.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SendOtpEmail(userEmail);

        }
    }
}

