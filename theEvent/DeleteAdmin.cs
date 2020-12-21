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
    public partial class DeleteAdmin : Form
    {
        public DeleteAdmin()
        {
            InitializeComponent();
            FillDataGridView();
        }
        private void FillDataGridView()
        {
            DataTable dt = new DataTable();
            foreach (IDataConnection db in GlobalConf.Connections)
            {
                dataGridView2.DataSource = db.FillDataForAdminDelete(dt, tbName.Text);
            }
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void BDelete_Click(object sender, EventArgs e)
        {
            Admin model = new Admin();
            model.Email = dataGridView2.CurrentCell.Value.ToString();
            foreach (IDataConnection db in GlobalConf.Connections)
            {
                db.DeletePerson(model);
            }
            FillDataGridView();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void DeleteAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
