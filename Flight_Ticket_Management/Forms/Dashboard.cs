﻿using Flight_Ticket_Management.Controls;
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
        public NotifikasiTiketControl notifikasiTiketControl;
        public PembayaranControl pembayaranControl;
        public VerifikasiPembayaranTiketControl verifikasiPembayaranTiketControl;
        public PengaturanControl pengaturanControl;

        public Form login;

        public Dashboard(Form loginForm)
        {
            pendaftaranControl = new PendaftaranControl(this);
            jadwalControl = new JadwalControl(this);
            detailjadwalControl = new DetailJadwalControl(this);
            keteranganJadwalControl = new KeteranganJadwalControl(this);
            tiketControl = new TiketControl(this);
            notifikasiTiketControl = new NotifikasiTiketControl(this);
            pembayaranControl = new PembayaranControl(this);
            verifikasiPembayaranTiketControl = new VerifikasiPembayaranTiketControl(this);
            pengaturanControl = new PengaturanControl(this);

            login = loginForm;

            InitializeComponent();

            userControl = new UserControl[] {
                pendaftaranControl, // [0]
                jadwalControl, // [1]
                detailjadwalControl, // [2]
                keteranganJadwalControl, // [3]
                tiketControl, // [4]
                notifikasiTiketControl, // [5]
                pembayaranControl, // [6]
                verifikasiPembayaranTiketControl, // [7]
                pengaturanControl // [8]
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
            showUserControls(userControl[6]);
        }

        private void btnPengaturan_Click(object sender, EventArgs e)
        {
            showUserControls(userControl[8]);
        }
    }
}