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
    public partial class FeedBack : Form
    {
        public FeedBack(string email)
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
                dataGridView1.DataSource = db.FillDataEventsForFeedBack(dt);
            }
        }
            private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BAddReview_Click(object sender, EventArgs e)
        {
         
            postEvent model = new postEvent();

            model.EventName = dataGridView1.ToString();
            model.Review = tbFeedBack.Text;
            model.EventID = (int)dataGridView1.CurrentCell.Value;
            
            foreach (IDataConnection db in GlobalConf.Connections)
            {
                db.UpdateEventFeedBack(model, LogLabel.Text);
            }
            FillDataGridView();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
