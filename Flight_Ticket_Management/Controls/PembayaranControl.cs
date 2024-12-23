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
    public partial class PembayaranControl : UserControl
    {
        private Dashboard dashboard;
        public PembayaranControl(Dashboard dashboard)
        {
            InitializeComponent();
            this.dashboard = dashboard;
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            dashboard.showUserControls(dashboard.userControl[7]);
        }
    }
}
