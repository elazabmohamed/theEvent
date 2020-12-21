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
using System.Data.SqlClient;
using Dapper;

namespace theEvent
{
    public partial class UpdateEvent2 : Form
    {
        public UpdateEvent2(string email,  int eventid)
        {
            InitializeComponent();
            LogLabel2.Text = email;
            eventIDHolder.Text = eventid.ToString();

            fill_combobox();
            fill_cehckedlistbox();
            dateTimePicker1.MinDate = DateTime.Today;
        }
        private void fill_combobox()
        {
            string query = "SELECT city FROM tblCity";
            using (SqlConnection c = new SqlConnection(GlobalConf.CnnString("MyDatabaseCity")))
            {
                c.Open();
                using (SqlCommand com = new SqlCommand(query, c))
                {
                    using (DataTable dt = new DataTable())
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                        {
                            adapter.Fill(dt);

                            // fetching the names of cities from database file to combobox
                            foreach (DataRow dr in dt.Rows)
                            {
                                cbCity.Items.Add(dr["city"].ToString());
                            }
                        }
                    }
                }
            }
        }
            private void fill_cehckedlistbox()
        {
            DataTable dt = new DataTable();
            foreach (IDataConnection db in GlobalConf.Connections)
            {
                checkedListBox1.DataSource = db.FillDataPerson(dt);
                checkedListBox1.DisplayMember = "FullName";
            }
        }
        private void BAddEvent_Click(object sender, EventArgs e)
        {
            EventModel model = new EventModel();
            model.InvitedMembers = "";
            foreach (object item in checkedListBox1.CheckedItems)
            {

                DataRowView row = item as DataRowView;
                model.InvitedMembers += row["FullName"] + ".";
                model.InvitedMembers += Environment.NewLine;
                // to add another column
                // invitedMember += "CustomerId: " + row["CustomerId"];
                //invitedMember += Environment.NewLine;
                //invitedMember += Environment.NewLine;
            }

            // dateTimePicker1.Format = DateTimePickerFormat.Custom;
            // dateTimePicker1.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            //string tarih = Convert.ToDateTime(dateTimePicker1.Value).ToString("yyyy-MM-dd");
            //model.EventDate = Convert.ToDateTime(tarih);
            
            model.EventDate = dateTimePicker1.Text.Trim();
            model.EventLocation = cbCity.Text.Trim();
            model.EventType = cbType.Text.Trim();
            model.EventNote = tbNote.Text.Trim();
            model.EventName = EventName.Text.Trim();
            model.EventMakerName = LogLabel2.Text;
            model.EventID = Int32.Parse(eventIDHolder.Text.Trim());
            foreach (IDataConnection db in GlobalConf.Connections)
            {
                db.UpdateEvent(model, LogLabel2.Text);
            }
            MessageBox.Show("Event Updated!");
        
        }

        private void EventName_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateEvent2_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
