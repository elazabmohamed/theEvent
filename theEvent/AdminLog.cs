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
    public partial class AdminLog : Form
    {
        public AdminLog()
        {
            InitializeComponent();
        }

        private void logAdmin_Click(object sender, EventArgs e)
        {

            if (tbEmail.Text == "" || tbEmail.Text.IndexOf('@') < 1 || tbEmail.Text == "")
            {
                MessageBox.Show("Your information are either incorrect or uncomplete");
            }

            else
            {
                CheckLogModel Model = new CheckLogModel();
                Model.Email = tbEmail.Text.Trim();
                Model.Password = tbPassword.Text.Trim();
                foreach (IDataConnection db in GlobalConf.Connections)
                {
                    if (db.CheckAdmin(Model))
                    {
                        HomePageAdmin h = new HomePageAdmin(tbEmail.Text);
                        h.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("You are not an Admin!");
                    }
                }
            }
        }
    }
}
