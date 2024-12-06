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
    public partial class DetailJadwalControl : UserControl
    {
        private Dashboard dashboard;
        public DetailJadwalControl(Dashboard dashboard)
        {
            InitializeComponent();
            this.dashboard = dashboard;
        }

        private void btnNextToKeterangan_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null) btn.ForeColor = Color.FromArgb(223, 31, 44);
        }

        private void btnNextToKeterangan_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null) btn.ForeColor = Color.Black;
        }

        private void btnBackToJadwal_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(btn != null) btn.ForeColor = Color.FromArgb(223, 31, 44);
        }

        private void btnBackToJadwal_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null) btn.ForeColor = Color.Black;
        }

        private void btnBackToJadwal_Click(object sender, EventArgs e)
        {
            dashboard.showUserControls(dashboard.userControl[1]);
        }

        private void btnNextToKeterangan_Click(object sender, EventArgs e)
        {
            dashboard.showUserControls(dashboard.userControl[3]);
        }
    }
}
