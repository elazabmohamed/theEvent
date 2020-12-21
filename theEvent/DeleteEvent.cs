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
    public partial class DeleteEvent : Form
    {
        public DeleteEvent()
        {
            InitializeComponent();
            FillDataGridView();
        }
        private void FillDataGridView()
        {
            DataTable dt = new DataTable();
            foreach (IDataConnection db in GlobalConf.Connections)
            {
                dataGridView2.DataSource = db.FillDataForEventDelete(dt, tbName.Text);
            }
        }
        private void BDelete_Click(object sender, EventArgs e)
        {

            EventModel model = new EventModel();
            model.EventID = (int)dataGridView2.CurrentCell.Value;
            foreach (IDataConnection db in GlobalConf.Connections)
            {
                db.DeleteEvent(model);
            }
            FillDataGridView();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
