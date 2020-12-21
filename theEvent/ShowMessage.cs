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
    public partial class ShowMessage : Form
    {
        public ShowMessage(string email)
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
                    dataGridView1.DataSource = db.FillDataMessage(dt, LogLabel.Text);
            }
        }
        private void ShowMessage_Load(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                tbMessage.Text = dataGridView1.CurrentCell.Value.ToString();
            }
            else
            {
                tbMessage.Text  = "No Messages! Sorry";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SendMessage s = new SendMessage(LogLabel.Text);
            s.ShowDialog();

        }
    }
}
