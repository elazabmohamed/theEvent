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
using theEvent.Models;
using theEvent.DataAccess;
using System.Configuration;

namespace theEvent
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Log_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Signup r = new Signup();
            r.ShowDialog();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text == "" || tbEmail.Text.IndexOf('@') < 1 || tbEmail.Text.IndexOf(".com")<1 || tbPassword.Text == "")
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
                    if (db.CheckMember(Model)){

                        HomePage h = new HomePage(tbEmail.Text);
                        h.ShowDialog();
                        //this.Hide();
                        
                    }
                     else
                    {
                        MessageBox.Show("You are not registered!");
                    }  
                }  
            }  
        }

        private void label8_Click(object sender, EventArgs e)
        {
            AdminLog log = new AdminLog();
            log.ShowDialog();
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
