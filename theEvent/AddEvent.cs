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
using System.Data.SqlClient;
using Dapper;

namespace theEvent
{
    public partial class AddEvent : Form
    {
        public AddEvent(string Email)
        {
             
            
            InitializeComponent();
            fill_cehckedlistbox();
            fill_combobox();
            LogLabel2.Text = Email;
            dateTimePicker1.MinDate = DateTime.Today;
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void fill_combobox()
        {

            // adding the names of the cities to the combobox
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
        private void AddEvent_Load(object sender, EventArgs e)
        {    
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
            model.EventDate = dateTimePicker1.Text.Trim();
            model.EventLocation = cbCity.Text.Trim();
            model.EventType = cbType.Text.Trim();
            model.EventNote = tbNote.Text.Trim();
            model.EventName = EventName.Text.Trim();
            model.EventMakerName = LogLabel2.Text;
           foreach (IDataConnection db in GlobalConf.Connections)
            {
                db.CreateEvent(model);
            }
            MessageBox.Show("Event Added!");

        }
        
        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
