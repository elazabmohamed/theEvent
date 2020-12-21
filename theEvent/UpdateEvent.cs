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
    public partial class UpdateEvent : Form
    {
        public UpdateEvent(string email)
        {
            InitializeComponent();
            LogLabel.Text = email;
            FillDataGridView();
        }

        private void FillDataGridView()
        {
            DataTable dt = new DataTable();
            foreach (IDataConnection db in GlobalConf.Connections)
            {
               // int eventID= (int)dataGridView1.CurrentCell.Value;
                dataGridView1.DataSource = db.FillDataForEventUpdate(dt, tbName.Text, LogLabel.Text);
            }
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BUpdate_Click(object sender, EventArgs e)
        {
            int eventID = (int)dataGridView1.CurrentCell.Value;
            UpdateEvent2 s = new UpdateEvent2(LogLabel.Text, eventID);
            s.ShowDialog();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            FillDataGridView();
        }
    }
}
