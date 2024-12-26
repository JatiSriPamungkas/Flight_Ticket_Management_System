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
    public partial class KeteranganJadwalControl : UserControl
    {
        private Dashboard dashboard;
        public KeteranganJadwalControl(Dashboard dashboard)
        {
            InitializeComponent();
            this.dashboard = dashboard;
        }

        private void btnNextToKeterangan_Click(object sender, EventArgs e)
        {
            dashboard.showUserControls(dashboard.userControl[2]);
        }

        private void btnNextToKeterangan_MouseEnter(object sender, EventArgs e)
        {
            btnNextToKeterangan.ForeColor = Color.FromArgb(223, 31, 44);
        }

        private void btnNextToKeterangan_MouseLeave(object sender, EventArgs e)
        {
            btnNextToKeterangan.ForeColor = Color.Black;
        }

        private void btnNextToPembayaran_Click(object sender, EventArgs e)
        {
            dashboard.showUserControls(dashboard.userControl[6]);
            dashboard.btnJadwal.Enabled = false;
            dashboard.btnPembayaran.Enabled = true;
        }
    }
}
