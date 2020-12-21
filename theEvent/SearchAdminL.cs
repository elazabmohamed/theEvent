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
    public partial class SearchAdminL : Form
    {
        public SearchAdminL()
        {
            InitializeComponent();
            FillDataGridView();
        }
        private void FillDataGridView()
        {

            DataTable dt = new DataTable();
            foreach (IDataConnection db in GlobalConf.Connections)
            {
                dataGridView1.DataSource = db.FillDataForAdminSearchByLocation(dt, tbLocation.Text);
            }
        }
        private void tbName_TextChanged(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
