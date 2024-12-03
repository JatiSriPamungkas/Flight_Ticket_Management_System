using Flight_Ticket_Management.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight_Ticket_Management.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            showUserControls(new PendaftaranControl());
        }

        private void showUserControls(UserControl userControl)
        {
            mainPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(userControl);
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms["Login"].Show();
        }

        private void lblClose_MouseEnter(object sender, EventArgs e)
        {
            lblClose.BackColor = Color.Gray;
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.BackColor = Color.DarkGray;
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblMinimize_MouseEnter(object sender, EventArgs e)
        {
            lblMinimize.BackColor = Color.Gray;
        }

        private void lblMinimize_MouseLeave(object sender, EventArgs e)
        {
            lblMinimize.BackColor = Color.DarkGray;
        }

        private void btnPendaftaran_Click(object sender, EventArgs e)
        {
            showUserControls(new PendaftaranControl());
        }

        private void btnTiket_Click(object sender, EventArgs e)
        {
            showUserControls(new TiketControl());
        }

        private void btnJadwal_Click(object sender, EventArgs e)
        {
            showUserControls(new JadwalControl());
        }

        private void btnPembayaran_Click(object sender, EventArgs e)
        {
            showUserControls(new PembayaranControl());
        }

        private void btnPengaturan_Click(object sender, EventArgs e)
        {
            showUserControls(new PengaturanControl());
        }
    }
}
