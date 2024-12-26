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
            DialogResult result = MessageBox.Show("Apakah Anda yakin untuk melanjutkan ke menu Pembayaran?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            

            if(result == DialogResult.Yes) dashboard.showUserControls(dashboard.userControl[7]);
        }
    }
}
