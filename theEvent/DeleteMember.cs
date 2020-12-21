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
    public partial class DeleteMember : Form
    {
        public DeleteMember()
        {
            InitializeComponent();
            FillDataGridViewFriends();
        }
        private void FillDataGridViewFriends()
        {
            DataTable dt = new DataTable();
            foreach (IDataConnection db in GlobalConf.Connections)
            {
                dataGridView2.DataSource = db.FillDataForMemberDelete(dt, tbName.Text);
            }
        }
        private void BDelete_Click(object sender, EventArgs e)
        {
            Admin model = new Admin();
            model.Email = dataGridView2.CurrentCell.Value.ToString();
            foreach (IDataConnection db in GlobalConf.Connections)
            {
                db.DeletePerson(model);
            }
            FillDataGridViewFriends();
        }

        private void DeleteMember_Load(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            FillDataGridViewFriends();
        }
    }
}
