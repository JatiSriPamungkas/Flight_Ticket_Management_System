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
    public partial class PengaturanControl : UserControl
    {
        private Dashboard dashboard;
        public PengaturanControl(Dashboard dashboard)
        {
            InitializeComponent();
            this.dashboard = dashboard;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            dashboard.Hide();
            dashboard.login.Show();
        }
    }
}
