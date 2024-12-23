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

namespace Flight_Ticket_Management.Controls
{
    public partial class PendaftaranControl : UserControl
    {
        Dashboard dashboard;
        public PendaftaranControl(Dashboard dashboard)
        {
            InitializeComponent();
            this.dashboard = dashboard;
        }

        private bool ValidateForm()
        {
            txtNamaLengkap.Text = string.Empty;
            txtNoIdentitas.Text = string.Empty;
            txtTanggalLahir.Text = string.Empty;
            txtAlamat.Text = string.Empty;
            txtNomorTelepon.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtJenisKelamin.Text = string.Empty;
            txtKewarganegaraan.Text = string.Empty;

            cmbKeberangkatan.SelectedIndex = -1;
            cmbTujuan.SelectedIndex = -1;
            cmbKelas.SelectedIndex = -1;
            cmbPenumpang.SelectedIndex = -1;

            return false;
            /*foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox && string.IsNullOrEmpty(textBox.Text)) return false;
                if (control is ComboBox comboBox && comboBox.SelectedIndex == -1) return false;
            }
            return true;*/
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                /*dashboard.btnJadwal.Enabled = true;
                dashboard.btnPembayaran.Enabled = true;
                dashboard.btnTiket.Enabled = true;*/
                MessageBox.Show("Semua Form telah Terisi!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Tolong isi semua Form!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
