using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using theEvent.DataAccess;
using theEvent.Models;
using Dapper;
using System.Data.SqlClient;

namespace theEvent
{
    public partial class UpdateInfo : Form
    {
        public UpdateInfo(string email)
        {
            InitializeComponent();
            LogLabel.Text = email;
        }

        private void UpdateInfo_Load(object sender, EventArgs e)
        {
            using (SqlConnection c = new SqlConnection(GlobalConf.CnnString("MyDatabaseCity")))
            {
                string query = "SELECT city FROM tblCity";
                c.Open();
                using (SqlCommand cmd = new SqlCommand(query, c))
                {
                    DataTable dt = new DataTable();
                     SqlDataAdapter adapter  = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    // fetching the names of cities from database file to combobox
                    foreach (DataRow dr in dt.Rows)
                    {
                        cbCity.Items.Add(dr["city"].ToString());
                    }
                }
            }
        }

        private void BUpdate_Click(object sender, EventArgs e)
        {
            Member model = new Member();
            model.FirstName = tbFName.Text.Trim();
            model.LastName = tbLName.Text.Trim();
            model.Email = LogLabel.Text;
            model.Password = tbPassword.Text.Trim();
            model.Location = cbCity.Text;
            model.BirthDate = dateTimePicker1.Value.ToString().Trim();
            if (model.FirstName == "" || model.LastName == "" || model.Email == "" || model.Email.IndexOf('@') < 1 || model.Email.IndexOf(".com") < 1 || model.Password == "" || model.Location == "")
            {
                MessageBox.Show("Your information are either incorrect or uncomplete");
            }
            else
            {
                foreach (IDataConnection db in GlobalConf.Connections)
                {
                    db.UpdatePerson(model);

                }

                MessageBox.Show("Updated!");
                this.Close();

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
