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
        public UserControl[] userControl;

        public PendaftaranControl pendaftaranControl;
        public JadwalControl jadwalControl;
        public DetailJadwalControl detailjadwalControl;
        public KeteranganJadwalControl keteranganJadwalControl;
        public TiketControl tiketControl;
        public PembayaranControl pembayaranControl;
        public PengaturanControl pengaturanControl;

        public Dashboard()
        {
            pendaftaranControl = new PendaftaranControl();
            jadwalControl = new JadwalControl(this);
            detailjadwalControl = new DetailJadwalControl(this);
            keteranganJadwalControl = new KeteranganJadwalControl(this);
            tiketControl = new TiketControl();
            pembayaranControl = new PembayaranControl();
            pengaturanControl = new PengaturanControl();


            InitializeComponent();

            userControl = new UserControl[] {
                pendaftaranControl, // [0]
                jadwalControl, // [1]
                detailjadwalControl, // [2]
                keteranganJadwalControl, // [3]
                tiketControl, // [4]
                pembayaranControl, // [5]
                pengaturanControl // [6]
            };

            stackControls();
            showUserControls(userControl[0]);
        }

        public void stackControls()
        {
            foreach (Control control in userControl)
            {
                control.Dock = DockStyle.Fill;
                control.Visible = false;
                mainPanel.Controls.Add(control);
            }
        }

        public void showUserControls(UserControl control)
        {
            foreach (UserControl hideControl in userControl) hideControl.Visible = false;


            control.Visible = true;
            control.BringToFront();
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
            showUserControls(userControl[0]);
        }


        private void btnJadwal_Click(object sender, EventArgs e)
        {
            showUserControls(userControl[1]);
        }
        private void btnTiket_Click(object sender, EventArgs e)
        {
            showUserControls(userControl[4]);
        }

        private void btnPembayaran_Click(object sender, EventArgs e)
        {
            showUserControls(userControl[5]);
        }

        private void btnPengaturan_Click(object sender, EventArgs e)
        {
            showUserControls(userControl[6]);
        }
    }
}