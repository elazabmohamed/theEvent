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
    public partial class HomePageAdmin : Form
    {
        public HomePageAdmin(string Email)
        {
            InitializeComponent();
            LogLabel.Text = Email;
            FillDataGridViewFriends();
            FillDataEvents();

        }
        private void FillDataGridViewFriends()
        {
            DataTable dt = new DataTable();
            foreach (IDataConnection db in GlobalConf.Connections)
            {
                dataGridView1.DataSource = db.FillDataPersonForHomePage(dt, LogLabel.Text);
            }
        }
        private void FillDataEvents()
        {
            DataTable dt = new DataTable();
            foreach (IDataConnection db in GlobalConf.Connections)
            {
                dataGridView2.DataSource = db.FillDataEvents(dt);
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ToolsAdmin E = new ToolsAdmin(LogLabel.Text);
            E.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddEvent E = new AddEvent(LogLabel.Text);
            E.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            foreach (IDataConnection db in GlobalConf.Connections)
            {
                dataGridView2.DataSource = db.FillDataEvents(dt);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            foreach (IDataConnection db in GlobalConf.Connections)
            {
                dataGridView1.DataSource = db.FillDataPersonForHomePage(dt, LogLabel.Text);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FeedBack s = new FeedBack(LogLabel.Text);
            s.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ShowMessage s = new ShowMessage(LogLabel.Text);
            s.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
