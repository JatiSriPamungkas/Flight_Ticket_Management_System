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
    public partial class NotifikasiTiketControl : UserControl
    {
        private Dashboard dashboard;
        public NotifikasiTiketControl(Dashboard dashboard)
        {
            InitializeComponent();
            this.dashboard = dashboard;
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            dashboard.showUserControls(dashboard.userControl[4]);
        }
    }
}
