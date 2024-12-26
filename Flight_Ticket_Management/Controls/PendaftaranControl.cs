using Flight_Ticket_Management.Forms;
using Flight_Ticket_Management.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Flight_Ticket_Management.Controls
{
    public partial class PendaftaranControl : UserControl
    {
        Dashboard dashboard;
        private DateTime? nullableDate = null;
        public List<Penumpang> listPenumpang = new List<Penumpang>();

        public PendaftaranControl(Dashboard dashboard)
        {
            InitializeComponent();
            this.dashboard = dashboard;
        }
        private void ResetForm()
        {
            txtNamaLengkap.Text = string.Empty;
            txtNoIdentitas.Text = string.Empty;
            dtmTanggalLahir.CustomFormat = " ";
            txtAlamat.Text = string.Empty;
            txtNomorTelepon.Text = string.Empty;
            txtEmail.Text = string.Empty;
            rbtnLaki.Checked = false;
            rbtnPerempuan.Checked = false;
            txtKewarganegaraan.Text = string.Empty;

            cmbKeberangkatan.SelectedIndex = -1;
            cmbTujuan.SelectedIndex = -1;
            cmbKelas.SelectedIndex = -1;
            cmbPenumpang.SelectedIndex = -1;
        }

        private void ClearDateTimePicker()
        {
            nullableDate = null;
            dtmTanggalLahir.Format = DateTimePickerFormat.Custom;
            dtmTanggalLahir.CustomFormat = " "; // Tampilkan kosong
        }

        private string GetSelectedRadioButtonText()
        {
            // Periksa setiap RadioButton secara manual
            if (rbtnLaki.Checked) return rbtnLaki.Text;
            if (rbtnPerempuan.Checked) return rbtnPerempuan.Text;

            return null; // Tidak ada RadioButton yang dipilih
        }

        private bool ValidateForm()
        {
            // Cek setiap TextBox
            if (string.IsNullOrEmpty(txtNoIdentitas.Text))
            {
                MessageBox.Show("Nomor Identitas belum diisi!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtNamaLengkap.Text))
            {
                MessageBox.Show("Nama Lengkap belum diisi!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dtmTanggalLahir.CustomFormat == " ")
            {
                MessageBox.Show("Tanggal Lahir belum diisi!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (GetSelectedRadioButtonText() == null)
            {
                MessageBox.Show("Jenis Kelamin belum diisi!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtAlamat.Text))
            {
                MessageBox.Show("Alamat belum diisi!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtNomorTelepon.Text))
            {
                MessageBox.Show("Nomor Telepon belum diisi!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Email belum diisi!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtKewarganegaraan.Text))
            {
                MessageBox.Show("Kewarganegaraan belum diisi!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            // Cek setiap ComboBox
            if (cmbKeberangkatan.SelectedIndex == -1)
            {
                MessageBox.Show("Keberangkatan belum dipilih!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbTujuan.SelectedIndex == -1)
            {
                MessageBox.Show("Tujuan belum dipilih!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbKelas.SelectedIndex == -1)
            {
                MessageBox.Show("Kelas belum dipilih!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbPenumpang.SelectedIndex == -1)
            {
                MessageBox.Show("Jumlah Penumpang belum dipilih!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {

                if (ValidateForm())
                {
                    Penumpang penumpang = new Penumpang();

                    penumpang.NoIdentitas = txtNoIdentitas.Text;
                    penumpang.NamaLengkap = txtNamaLengkap.Text;
                    penumpang.TanggalLahir = dtmTanggalLahir.Value.ToString();
                    penumpang.JenisKelamin = GetSelectedRadioButtonText();
                    penumpang.Alamat = txtAlamat.Text;
                    penumpang.NomorTelepon = txtNomorTelepon.Text;
                    penumpang.Email = txtEmail.Text;
                    penumpang.Kewarganegaraan = txtKewarganegaraan.Text;
                    penumpang.Keberangkatan = cmbKeberangkatan.SelectedItem.ToString();
                    penumpang.Tujuan = cmbTujuan.SelectedItem.ToString();
                    penumpang.Kelas = cmbKelas.SelectedItem.ToString();
                    penumpang.JumlahPenumpang = cmbPenumpang.SelectedItem.ToString();

                    listPenumpang.Add(penumpang);

                    MessageBox.Show("Semua form telah terisi!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dashboard.showUserControls(dashboard.userControl[1]);
                    dashboard.btnPendaftaran.Enabled = false;
                    dashboard.btnJadwal.Enabled = true;
                    // dashboard.btnPembayaran.Enabled = true;
                    // dashboard.btnTiket.Enabled = true;
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void dtmTanggalLahir_ValueChanged(object sender, EventArgs e)
        {
            dtmTanggalLahir.CustomFormat = "";
            nullableDate = dtmTanggalLahir.Value;
            dtmTanggalLahir.Format = DateTimePickerFormat.Short; // Kembalikan format saat nilai dipilih
        }
    }
}
