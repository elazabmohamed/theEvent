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
    public partial class UpdateMember : Form
    {
        public UpdateMember(string email)
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
                dataGridView2.DataSource = db.FillDataForMemberDelete(dt, tbName.Text);
            }
        }
        private void BUpdate_Click(object sender, EventArgs e)
        {
            UpdatePersonInfo s = new UpdatePersonInfo(LogLabel.Text, dataGridView2.CurrentCell.Value.ToString());
            s.ShowDialog();
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
