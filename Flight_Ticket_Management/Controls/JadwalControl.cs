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

namespace Flight_Ticket_Management.Controls
{
    public partial class JadwalControl : UserControl
    {
        private int noUrut;
        private ListViewItem item;
        private Dashboard dashboard;
        private string[] dataPesawat;
        private List<Jadwal> listJadwal = new List<Jadwal>();
        public JadwalControl(Dashboard dashboard)
        {
            InitializeComponent();
            this.dashboard = dashboard;

            Jadwal jadwal1 = new Jadwal()
            {
                Maskapai = "Garuda Indonesia",
                JenisPesawat = "GA-120",
                WaktuKeberangkatan = "20:00",
                WaktuSampai = "22:00",
                Harga = 1500000,
                Asal = "Jakarta",
                Tujuan = "Yogyakarta"
            };

            Jadwal jadwal2 = new Jadwal()
            {
                Maskapai = "Garuda Indonesia",
                JenisPesawat = "GA-140",
                WaktuKeberangkatan = "22:00",
                WaktuSampai = "24:00",
                Harga = 1500000,
                Asal = "Yogyakarta",
                Tujuan = "Jakarta"
            };

            listJadwal.Add(jadwal1);
            listJadwal.Add(jadwal2);
        }

        private void ShowData()
        {
            try
            {
                if (listJadwal != null)
                {
                    lvwJadwal.Items.Clear();


                    foreach (var data in listJadwal)
                    {
                        noUrut = lvwJadwal.Items.Count + 1;
                        item = new ListViewItem(noUrut.ToString());

                        item.SubItems.Add(data.Maskapai);
                        item.SubItems.Add(data.JenisPesawat);
                        item.SubItems.Add(data.WaktuKeberangkatan);
                        item.SubItems.Add(data.WaktuSampai);
                        item.SubItems.Add(data.Harga.ToString());
                        item.SubItems.Add(data.Asal);
                        item.SubItems.Add(data.Tujuan);

                        lvwJadwal.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        private void JadwalControl_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnPilih_Click(object sender, EventArgs e)
        {
            if (lvwJadwal.SelectedItems.Count > 0)
            {
                // Mendapatkan item yang dipilih
                ListViewItem selectedItem = lvwJadwal.SelectedItems[0];

                // Mengakses data dari sub-item
                string maskapai = selectedItem.SubItems[1].Text;
                string jenisPesawat = selectedItem.SubItems[2].Text;
                string waktuKeberangkatan = selectedItem.SubItems[3].Text;
                string waktuSampai = selectedItem.SubItems[4].Text;
                string harga = selectedItem.SubItems[5].Text;
                string asal = selectedItem.SubItems[6].Text;
                string tujuan = selectedItem.SubItems[7].Text;

                dashboard.showUserControls(dashboard.userControl[2]);
            } else
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
