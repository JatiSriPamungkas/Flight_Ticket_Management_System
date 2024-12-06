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
    public partial class JadwalControl : UserControl
    {
        private int noUrut;
        private ListViewItem item;
        private Dashboard dashboard;

        public JadwalControl(Dashboard dashboard)
        {
            InitializeComponent();
            this.dashboard = dashboard;
        }

        private void btnTest_Click_1(object sender, EventArgs e)
        {
            noUrut = lvwJadwal.Items.Count + 1;

            item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add("Garuda Indonesia");
            item.SubItems.Add("GA-410");
            item.SubItems.Add("18:00");
            item.SubItems.Add("20:00");
            item.SubItems.Add("Rp 1,500,000");
            item.SubItems.Add("Jakarta (HLP)");
            item.SubItems.Add("Yogyakarta (YIA)");

            lvwJadwal.Items.Add(item);
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            dashboard.showUserControls(dashboard.userControl[2]);
        }
    }
}
