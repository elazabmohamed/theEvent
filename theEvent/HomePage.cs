using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using theEvent.DataAccess;
using theEvent.Models;
using Dapper;
using System.Data.SqlClient;

namespace theEvent
{
    public partial class HomePage : Form
    {
        public HomePage(string Email)
        {
            InitializeComponent();
            LogLabel.Text = Email;
            HBD();
            FillDataGridViewFriends();
            FillDataEvents();


        }

        private void HBD()
        {
            foreach (IDataConnection db in GlobalConf.Connections)
            {
                if (db.HappyBirthDay(LogLabel.Text))
                {

                    MessageBox.Show("HAPPY BIRTHDAY!");
                    //this.Hide();

                }
                else
                {
                   // MessageBox.Show("You are not registered!");
                }
            }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddEvent E = new AddEvent(LogLabel.Text);
            E.ShowDialog();
        }
        
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

      
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FeedBack s = new FeedBack(LogLabel.Text);
            s.ShowDialog();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            foreach (IDataConnection db in GlobalConf.Connections)
            {
                dataGridView2.DataSource = db.FillDataEvents(dt);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            foreach (IDataConnection db in GlobalConf.Connections)
            {
                dataGridView1.DataSource = db.FillDataPersonForHomePage(dt, LogLabel.Text);
            }
        }

        private void EventName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Tools E = new Tools(LogLabel.Text);
            E.ShowDialog();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            
        }
        private void HomePage_FormClosing(object sender, EventArgs e)
        {
           
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ShowMessage s = new ShowMessage(LogLabel.Text);
            s.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
