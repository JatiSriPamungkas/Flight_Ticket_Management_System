using Flight_Ticket_Management.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Flight_Ticket_Management
{
    public partial class Login : Form
    {

        Dashboard dashboard = new Dashboard();

        public Login()
        {
            InitializeComponent();
        }

        private void ResetForm()
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void closelbl_Click(object sender, EventArgs e)
        {
            dashboard.Close();
            Application.Exit();
        }

        private void closelbl_MouseEnter(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.FromArgb(223, 31, 44);
        }

        private void closelbl_MouseHover(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.FromArgb(223, 31, 44);
        }

        private void closelbl_MouseLeave(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.FromArgb(64, 45, 51);
        }

        private void btnSignIn_MouseEnter(object sender, EventArgs e)
        {
            btnSignIn.BackColor = Color.FromArgb(223, 31, 44);
            btnSignIn.ForeColor = Color.FromArgb(240, 240, 240);
        }

        private void btnSignIn_MouseHover(object sender, EventArgs e)
        {
            btnSignIn.BackColor = Color.FromArgb(223, 31, 44);
            btnSignIn.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnSignIn_MouseLeave(object sender, EventArgs e)
        {
            btnSignIn.BackColor = Color.FromArgb(224, 224, 224);
            btnSignIn.ForeColor = Color.FromArgb(64, 45, 51);
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string name = txtUsername.Text;
            string password = txtPassword.Text;
            /*if (name == "" && password == "")
            {
                ResetForm();
                MessageBox.Show("Mohon isi kolom Username dan Password !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            if (txtUsername.Text == "" && txtPassword.Text == "")
            {
                ResetForm();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                ResetForm();
                MessageBox.Show("Username atau Password Salah !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblReset_MouseEnter(object sender, EventArgs e)
        {
            lblReset.Font = new Font(lblReset.Font, FontStyle.Underline);
        }

        private void lblReset_MouseHover(object sender, EventArgs e)
        {
            lblReset.Font = new Font(lblReset.Font, FontStyle.Underline);
        }

        private void lblReset_MouseLeave(object sender, EventArgs e)
        {
            lblReset.Font = new Font(lblReset.Font, FontStyle.Regular);
        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
