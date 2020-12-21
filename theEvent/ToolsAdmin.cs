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
    public partial class ToolsAdmin : Form
    {
        public ToolsAdmin(string email)
        {
            InitializeComponent();
            LogLabel.Text = email;
            FillAdminMemberInfo();
        }


        private void FillAdminMemberInfo()
        {
            DataTable dt = new DataTable();
            foreach (IDataConnection db in GlobalConf.Connections)
            {
                labelForAdminNumber.Text = db.FillAdminCount().ToString();
                labelForMemberNumber.Text = db.FillMemberCount("Member").ToString();
            }

        }



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Signup s = new Signup();
            s.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            SignupAdmin s = new SignupAdmin();
            s.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            DeleteAdmin d = new DeleteAdmin();
            d.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            DeleteMember d = new DeleteMember();
            d.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            SearchAdminN s = new SearchAdminN();
            s.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            SearchMemberN s = new SearchMemberN();
            s.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            SearchAdminL s = new SearchAdminL();
            s.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            SearchMemberL s = new SearchMemberL();
            s.ShowDialog();
        }

        private void ToolsAdmin_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            UpdateInfo s = new UpdateInfo(LogLabel.Text);
            s.ShowDialog();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            DeleteEvent s = new DeleteEvent();
            s.ShowDialog();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            UpdateAdmin s = new UpdateAdmin(LogLabel.Text);
            s.ShowDialog();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            UpdateMember s = new UpdateMember(LogLabel.Text);
            s.ShowDialog();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            SearchEventN s = new SearchEventN();
            s.ShowDialog();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            SearchEventL s = new SearchEventL();
            s.ShowDialog();
        }
    }
}
