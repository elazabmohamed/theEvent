using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using theEvent.DataAccess;
using theEvent.Models;

namespace theEvent
{
    public partial class SearchMemberL : Form
    {
        public SearchMemberL()
        {
            InitializeComponent();
            FillDataGridView();
        }
        private void FillDataGridView()
        {

            DataTable dt = new DataTable();
            foreach (IDataConnection db in GlobalConf.Connections)
            {
                dataGridView1.DataSource = db.FillDataForMemberSearchByLocation(dt, tbLocation.Text);
            }
        }
        private void tbLocation_TextChanged(object sender, EventArgs e)
        {
            FillDataGridView();
        }
    }
}
