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
    public partial class SendMessage : Form
    {
        public SendMessage(string email)
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
                dataGridView1.DataSource = db.FillDataPerson(dt);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BAddMessage_Click(object sender, EventArgs e)
        {
            MessageModel model = new MessageModel();
            
            model.Message = tbMessage.Text;

            foreach (IDataConnection db in GlobalConf.Connections)
            {
                db.SendMessage(model, LogLabel.Text, dataGridView1.CurrentCell.Value.ToString());
            }
            FillDataGridView();
            
        }
    }
}
