using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using theEvent.Models;
using System.Data;
using System.IO;
using Dapper;
using System.Data.SqlClient;

namespace theEvent.DataAccess
{

    public class SqliteConnector : IDataConnection
    {

        /// <summary>
        ///                                                     Filling the DatagridViews with the proper info
        /// </summary>
        /// 

        public void CheckDatabase()
        {

            using (SqlConnection c = new SqlConnection(GlobalConf.CnnString("CheckDB")))
            {
                var database = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"SQL", "Create_Database.sql"));
                var CreateDB= "CREATE DATABASE THEVENT;";
                c.Open();
                try
                {
                    using (SqlCommand cmd1 = new SqlCommand(database, c))
                    {
                        cmd1.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    using (SqlCommand cmd1 = new SqlCommand(CreateDB, c))
                    {
                        cmd1.ExecuteNonQuery();
                    }
                }
                using (SqlCommand cmd1 = new SqlCommand(database, c))
                {

                    cmd1.ExecuteNonQuery();
                }


            }
        }




        public DataTable FillDataPerson(DataTable data)
        {
            using (SqlConnection c = new SqlConnection(GlobalConf.CnnString("MyDatabaseDeneme")))
            {
                string query1 = "DROP VIEW IF EXISTS FnameLnameASFullname; ";
                string query2 = "CREATE VIEW FnameLnameASFullname " +
                                "AS SELECT fname + ' ' + lname AS FullName, email FROM tblPerson ";
                string query3 = "SELECT* from FnameLnameASFullname ";
                c.Open();
                using (SqlCommand cmd1 = new SqlCommand(query1, c))
                {
                    cmd1.ExecuteNonQuery();
                }
                using (SqlCommand cmd2 = new SqlCommand(query2, c))
                {
                    cmd2.ExecuteNonQuery();
                }
                using (SqlCommand cmd3 = new SqlCommand(query3, c))
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd3);
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        public DataTable FillDataPersonForHomePage(DataTable data, string email)
        {
            using (SqlConnection c = new SqlConnection(GlobalConf.CnnString("MyDatabaseDeneme")))
            {
                string query = "SELECT COALESCE(fname, lname) AS FullName, " +
                               "STUFF(email,CHARINDEX('@',email,1)+1, " +
                               "CHARINDEX('.',email,1)-CHARINDEX('@',email,1),'****') AS StuffedEmail " +
                               " from tblPerson " +
                               "where location=(select location from tblPerson where email='" + email + "') ";

                //c.Open();
                using (SqlCommand cmd = new SqlCommand(query, c))
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }



        
        public DataTable FillDataAdmins(DataTable data)
        {
            using (SqlConnection c = new SqlConnection(GlobalConf.CnnString("MyDatabaseDeneme")))
            {
                string query1 = "DROP FUNCTION IF EXISTS  fillDataAdmins ";
                string query2 = "CREATE FUNCTION fillDataAdmins(@Type nvarchar(10)) " +
                                "RETURNS TABLE AS RETURN(SELECT fname +' ' + lname AS FullName, email " +
                                "from tblPerson " +
                                "where type = @Type) ";
                string query3 = "SELECT* from fillDataAdmins('Admin')";
                c.Open();
                using (SqlCommand cmd1 = new SqlCommand(query1, c))
                {
                    cmd1.ExecuteNonQuery();
                }
                using (SqlCommand cmd2 = new SqlCommand(query2, c))
                {
                    cmd2.ExecuteNonQuery();
                }
                using (SqlCommand cmd3 = new SqlCommand(query3, c))
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd3);
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }




        public DataTable FillDataMembers(DataTable data)
        {

            using (SqlConnection c = new SqlConnection(GlobalConf.CnnString("MyDatabaseDeneme")))
            {
                string query1 = "DROP INDEX IF EXISTS tblPerson.IX_tblPerson_Name  ";
                string query2 = "Create NonClustered Index IX_tblPerson_Name " +
                                "ON tblPerson(fName) ";
                string query3 = "SELECT fname + ' ' + lname AS FullName, email FROM tblPerson " +
                                "WITH(INDEX(IX_tblPerson_Name)) WHERE type = 'Member'";
                c.Open();
                using (SqlCommand cmd1 = new SqlCommand(query1, c))
                {
                    cmd1.ExecuteNonQuery();
                }
                using (SqlCommand cmd2 = new SqlCommand(query2, c))
                {
                    cmd2.ExecuteNonQuery();
                }
                using (SqlCommand cmd3 = new SqlCommand(query3, c))
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd3);
                    adapter.Fill(dt);
                    return dt;
                }
            }

        }

        public DataTable FillDataEvents(DataTable data)
        {
            using (SqlConnection c = new SqlConnection(GlobalConf.CnnString("MyDatabaseDeneme")))
            {
                string query1 = "DROP FUNCTION IF EXISTS EventTable ";
                string query2 = "Create Function EventTable() " +
                                "Returns @Table Table(Name nvarchar(MAX), Date nvarchar(MAX), Location nvarchar(50), Type nvarchar(10), " +
                                "PeopleInvited nvarchar(MAX), Note nvarchar(MAX)) " +
                                "as " +
                                "Begin " +
                                "Insert into @Table " +
                                "SELECT eventName as Name, CONVERT(varchar(20), eventDate) as Date, " +
                                "eventLocation as Location, eventType as Type, " +
                                "invitedMembers as PeopleInvited, eventNote as Note " +
                                "From tblEvent " +
                                "Return " +
                                "End ";
                string query3 = "SELECT* FROM EventTable()";
                c.Open();
                using (SqlCommand cmd1 = new SqlCommand(query1, c))
                {
                    cmd1.ExecuteNonQuery();
                }
                using (SqlCommand cmd2 = new SqlCommand(query2, c))
                {
                    cmd2.ExecuteNonQuery();
                }
                using (SqlCommand cmd3 = new SqlCommand(query3, c))
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd3);
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }



        public DataTable FillDataEventsForFeedBack(DataTable data)
        {
            string query= "SELECT eventid, review, fname+' ' + lname as ReviewerName, eventName, " +
                            " makerEmail, eventType, eventLocation, CAST(eventDate as nvarchar(20)), invitedMembers, eventNote " +
                            "From tblReview A " +
                            "RIGHT JOIN tblEvent B " +
                            "ON B.eventid = A.reviewedEventId " +
                            "LEFT JOIN tblPerson C " +
                            "ON C.id = A.reviewerId ";           
            using (SqlConnection c = new SqlConnection(GlobalConf.CnnString("MyDatabaseDeneme")))
            {
                c.Open();
                using (SqlCommand cmd = new SqlCommand(query, c))
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }


        public int FillAdminCount()
        {
            string query = "SELECT COUNT(*) " +
                "AS TotalAdminNumber " +
                "FROM tblPerson WHERE type = 'Admin' GROUP BY type";
            using (SqlConnection c = new SqlConnection(GlobalConf.CnnString("MyDatabaseDeneme")))
            {
                c.Open();
                using (SqlCommand cmd = new SqlCommand(query, c))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public int FillMemberCount(string typeToBeSearched)
        {
            string query1 = "DROP PROCEDURE IF EXISTS spGetPersonCount;";
            string query2 = "Create Procedure spGetPersonCount " +
                            "@type nvarchar(10), " +
                            "@PersonCount int Output " +
                            "as " +
                            "Begin " +
                            "Select @PersonCount = COUNT(id) " +
                            "from tblPerson " +
                            "WHERE type = @type " +
                            "END ";
            string query3 = "Declare @TotalCount int " +
                            "Execute spGetPersonCount '"+ typeToBeSearched + "',@TotalCount " +
                            "Output " +
                            "SELECT @TotalCount ";


            using (SqlConnection c = new SqlConnection(GlobalConf.CnnString("MyDatabaseDeneme")))
            {
                c.Open();
                using (SqlCommand cmd1 = new SqlCommand(query1, c))
                {
                    cmd1.ExecuteNonQuery();
                }
                using (SqlCommand cmd2 = new SqlCommand(query2, c))
                {
                    cmd2.ExecuteNonQuery();
                }

                using (SqlCommand cmd3 = new SqlCommand(query3, c))
                {
                    return Convert.ToInt32(cmd3.ExecuteScalar());
                }
            }
        }


        public DataTable FillDataForAdminSearchByName(DataTable data, string name)
        {
            using (SqlConnection c = new SqlConnection(GlobalConf.CnnString("MyDatabaseDeneme")))
            {
                string query1 = "DROP FUNCTION IF EXISTS  fillDataAdmins ";
                string query2 = "CREATE FUNCTION fillDataAdmins(@Type nvarchar(10)) " +
                                "RETURNS TABLE AS RETURN(SELECT fname +' ' + lname AS FullName, email " +
                                "from tblPerson " +
                                "WHERE (fname LIKE '%" + name + "%' or lname LIKE '%" + name + "%' or email LIKE '%" + name + "%') and (type=@Type) )";
                string query3 = "SELECT* from fillDataAdmins('Admin')";
                c.Open();
                using (SqlCommand cmd1 = new SqlCommand(query1, c))
                {
                    cmd1.ExecuteNonQuery();
                }
                using (SqlCommand cmd2 = new SqlCommand(query2, c))
                {
                    cmd2.ExecuteNonQuery();
                }
                using (SqlCommand cmd3 = new SqlCommand(query3, c))
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd3);
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        public DataTable FillDataForEventSearchByName(DataTable data, string name)
        {

            string query = "SELECT eventName, " +
                "DATENAME(month, eventDate)+' '+DATENAME(day, eventDate)+' '+ " +
                "DATENAME(year, eventDate)+' '+DATENAME(hour, eventDate)+':'+ " +
                "DATENAME(MINUTE, eventDate), eventLocation, eventType, " +
                "invitedMembers, eventNote FROM tblEvent WHERE eventName LIKE '%" + name + "%'";

            using (SqlConnection c = new SqlConnection(GlobalConf.CnnString("MyDatabaseDeneme")))
            {
                c.Open();
                using (SqlCommand cmd = new SqlCommand(query, c))
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        public DataTable FillDataForMemberSearchByName(DataTable data, string name)
        {
            using (SqlConnection c = new SqlConnection(GlobalConf.CnnString("MyDatabaseDeneme")))
            {
                string query1 = "DROP INDEX IF EXISTS tblPerson.IX_tblPerson_Name  ";
                string query2 = "Create NonClustered Index IX_tblPerson_Name " +
                                "ON tblPerson(fName) ";
                string query3 = "SELECT fname + ' ' + lname AS FullName, email FROM tblPerson " +
                                "WITH(INDEX(IX_tblPerson_Name)) WHERE (fname LIKE '%"+name+"' or lname LIKE '%"+name+"' or email LIKE '%"+name+"%') " +
                                " and (type='Member') ";
                c.Open();
                using (SqlCommand cmd1 = new SqlCommand(query1, c))
                {
                    cmd1.ExecuteNonQuery();
                }
                using (SqlCommand cmd2 = new SqlCommand(query2, c))
                {
                    cmd2.ExecuteNonQuery();
                }
                using (SqlCommand cmd3 = new SqlCommand(query3, c))
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd3);
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        public DataTable FillDataForAdminSearchByLocation(DataTable data, string location)
        {
            string query = "SELECT fname +' ' + lname AS FullName, location FROM tblPerson WHERE (location LIKE '" + location + "%') and (type='Admin')";
            using (SqlConnection c = new SqlConnection(GlobalConf.CnnString("MyDatabaseDeneme")))
            {
                c.Open();
                using (SqlCommand cmd = new SqlCommand(query, c))
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        public DataTable FillDataForEventSearchByLocation(DataTable data, string location)
        {
            string query = "SELECT eventName, eventDate, eventLocation, eventType FROM tblEvent WHERE eventLocation LIKE '%" + location + "%'";
            using (SqlConnection c = new SqlConnection(GlobalConf.CnnString("MyDatabaseDeneme")))
            {
                c.Open();
                using (SqlCommand cmd = new SqlCommand(query, c))
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable FillDataForMemberSearchByLocation(DataTable data, string location)
        {
            string query = "SELECT fname + ' ' + lname AS FullName, location FROM tblPerson WHERE location LIKE '" + location + "%' and type='Member'";
            using (SqlConnection c = new SqlConnection(GlobalConf.CnnString("MyDatabaseDeneme")))
            {
                c.Open();
                using (SqlCommand cmd = new SqlCommand(query, c))
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }


        public DataTable FillDataForAdminDelete(DataTable data, string name)
        {  
            string query = "SELECT fname, lname, email FROM tblPerson WHERE (fname LIKE '%" + name + "%' or lname LIKE '%" + name + "%' or email LIKE '%" + name + "%') and (type='Admin')";
            using (SqlConnection c = new SqlConnection(GlobalConf.CnnString("MyDatabaseDeneme")))
            {
                c.Open();
                using (SqlCommand cmd = new SqlCommand(query, c))
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    return dt;
                }
            }
            
        }
        public DataTable FillDataForMemberDelete(DataTable data, string name)
        {
            string query = "SELECT fname, lname, email FROM tblPerson WHERE (fname LIKE '%" + name + "%' or lname  LIKE '%" + name + "%' or email LIKE '%" + name + "%') and (type='Member')";
            using (SqlConnection c = new SqlConnection(GlobalConf.CnnString("MyDatabaseDeneme")))
            {
                c.Open();
                using (SqlCommand cmd = new SqlCommand(query, c))
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    return dt;
                }
            }
            
        }
        public DataTable FillDataForEventDelete(DataTable data, string name)
        {  
            string query = "SELECT eventid,eventName, eventType, eventLocation, eventDate, eventNote, invitedMembers FROM tblEvent WHERE eventName LIKE '%" + name + "%'";
            using (SqlConnection c = new SqlConnection(GlobalConf.CnnString("MyDatabaseDeneme")))
            {
                c.Open();
                using (SqlCommand cmd = new SqlCommand(query, c))
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    return dt;
                }
            }
            
        }
        public DataTable FillDataForEventUpdate(DataTable data, string name, string email)
        {
            string query = "SELECT eventid,eventName, eventType, eventLocation, EventDate, eventNote, invitedMembers FROM tblEvent WHERE eventName LIKE '%" + name + "%' and makerEmail='" + email + "'";
            using (SqlConnection c = new SqlConnection(GlobalConf.CnnString("MyDatabaseDeneme")))
            {
                c.Open();
                using (SqlCommand cmd = new SqlCommand(query, c))
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable FillDataMessage(DataTable data, string email)
        {
            //string query = "Select  A.fname + ' ' + A.lname AS Fullname, B.message, B.messagedate From tblPerson A JOIN tblMessage B ON A.id = B.senderid Where B.recieverid = (select id from tblPerson where email = '" + email+ "') ORDER BY B.messagedate ASC";
            string query = "DECLARE @LOCAL_TABLEVARIABLE TABLE (Fullname nvarchar(50), " +
                             "message nvarchar(max), " +
                             "messagedate datetime," +
                             " recieverid int) " +
                             "INSERT INTO @LOCAL_TABLEVARIABLE(Fullname, message, messagedate,recieverid) " +
                             "Select A.fname + ' ' + A.lname AS Fullname, B.message, B.messagedate , B.recieverid " +
                             "From tblPerson A " +
                             "JOIN tblMessage B " +
                             "ON A.id = B.senderid " +
                             "Where B.recieverid = (select id from tblPerson where email = '"+email+"') or " +
                             "B.senderid = (select id from tblPerson where email = '" + email + "') ORDER BY B.messagedate ASC " +
                             "Update @LOCAL_TABLEVARIABLE " +
                             "Set Fullname = 'Me to '+(select fname+' '+lname from tblPerson where id=recieverid) " +
                             "where Fullname = (select fname + ' ' + lname from tblPerson where email = '" + email + "'  ) " +
                             "Select Fullname, message, messagedate From @LOCAL_TABLEVARIABLE ";

            using (SqlConnection c = new SqlConnection(GlobalConf.CnnString("MyDatabaseDeneme")))
            {
                c.Open();
                using (SqlCommand cmd = new SqlCommand(query, c))
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }



        /// <summary>
        ///                                                                   MEMBER LOG IN VERIFICATION
        /// </summary>
        public bool CheckMember(CheckLogModel Model)
        {
            using (SqlConnection connection = new SqlConnection(GlobalConf.CnnString("MyDatabaseDeneme")))
            {
                connection.Open();
                string query = "SELECT* FROM tblPerson WHERE email='" + Model.Email + "' AND password='" + Model.Password + "'";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (!dr.Read())
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
            }
        }
        /// <summary>
        ///                                                                   MEMBER LOG IN VERIFICATION
        /// </summary>
        public bool CheckAdmin(CheckLogModel Model)
        {
            using (SqlConnection connection = new SqlConnection(GlobalConf.CnnString("MyDatabaseDeneme")))
            {
                connection.Open();
                string query = "SELECT* FROM tblPerson WHERE email='" + Model.Email + "' AND password='" + Model.Password + "' AND type='Admin'";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (!dr.Read())
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
            }
        }


        /// <summary>
        ///                                  PERSON METHODS : CREATE-UPDATE-DELETE
        /// </summary>
        public PersonModel CreatePerson(PersonModel Model)
        {

            using (SqlConnection connection = new SqlConnection(GlobalConf.CnnString("MyDatabaseDeneme")))
            {
                connection.Open();
                string query = "INSERT INTO tblPerson(type, fname, lname, location, email, password, birthdate, registration)values('" + Model.Type + "',TRIM('" + Model.FirstName + "')," +
                                " UPPER(TRIM('" + Model.LastName + "')), '" + Model.Location + "', TRIM('" + Model.Email + "'), TRIM('" + Model.Password + "'), '" + Model.BirthDate + "', GETDATE())";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            return Model;
        }
        public PersonModel UpdatePerson(PersonModel Model)
        {
            using (SqlConnection connection = new SqlConnection(GlobalConf.CnnString("MyDatabaseDeneme")))
            {
                connection.Open();
                string query = "UPDATE tblPerson SET location='" + Model.Location + "', fname= '"
                + Model.FirstName + "', lname= '" + Model.LastName + "', birthdate='" + Model.BirthDate + "', password= '" + Model.Password + "'WHERE email= '" + Model.Email + "'";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            return Model;
        }

        public PersonModel DeletePerson(PersonModel Model)
        {

            using (SqlConnection connection = new SqlConnection(GlobalConf.CnnString("MyDatabaseDeneme")))
            {
                connection.Open();
                string query = "DELETE FROM tblPerson WHERE email='" + Model.Email + "'";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            return Model;
        }



        /// <summary>
        ///                                    EVENT METHODS : CREATE-UPDATE-DELETE
        /// </summary>

        public EventModel CreateEvent(EventModel Model)
        {
            using (SqlConnection connection = new SqlConnection(GlobalConf.CnnString("MyDatabaseDeneme")))
            {
                connection.Open();
                string query = "INSERT INTO tblEvent(" +
                    "eventLocation, invitedMembers, eventType, eventNote, eventDate, eventName, makerEmail)values(" +
                   "'" + Model.EventLocation + "'," +
                   " '" + Model.InvitedMembers + "', '" + Model.EventType + "', '" + Model.EventNote + "', '" + Model.EventDate + "', '" + Model.EventName + "', '" + Model.EventMakerName + "')";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
            }
            return Model;
        }



        // UPDATE AN EVENT
        public EventModel UpdateEvent(EventModel Model, string makerEmail)
        {
            using (SqlConnection connection = new SqlConnection(GlobalConf.CnnString("MyDatabaseDeneme")))
            {
                connection.Open();
                string query = "UPDATE tblEvent SET eventName = '" + Model.EventName + "', eventLocation='" + Model.EventLocation + "', invitedMembers= '"
                + Model.InvitedMembers + "', eventType= '" + Model.EventType + "', eventNote='" + Model.EventNote + "', eventDate= '" + Model.EventDate + "'WHERE eventid= '" + Model.EventID + "'";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            return Model;
        }




        public postEvent UpdateEventFeedBack(postEvent Model, string email)
        {
            using (SqlConnection connection3 = new SqlConnection(GlobalConf.CnnString("MyDatabaseDeneme")))
            {
                connection3.Open();
                string query = "INSERT INTO tblReview(reviewerId, review, reviewedEventId)values((select id from tblPerson where email = '"+email+"'),'"+Model.Review+"', "+Model.EventID+")";
                using (SqlCommand cmd = new SqlCommand(query, connection3))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            return Model;
        }

        public EventModel DeleteEvent(EventModel Model)
        {
            using (SqlConnection connection = new SqlConnection(GlobalConf.CnnString("MyDatabaseDeneme")))
            {
                connection.Open();
                string query = "DELETE FROM tblEvent WHERE eventid='" + Model.EventID + "'";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            return Model;
        }



        public MessageModel SendMessage(MessageModel Model, string email, string messagedEmail)
        {
            using (SqlConnection connection1 = new SqlConnection(GlobalConf.CnnString("MyDatabaseDeneme")))
            {
                connection1.Open();
                string query3 = "INSERT INTO tblMessage(senderid, recieverid, message, messagedate)values((select id from tblPerson where email='" + email + "'), (select id from tblPerson where email = '" + messagedEmail + "'), '" + Model.Message + "', GETDATE())";
                using (SqlConnection connection3 = new SqlConnection(GlobalConf.CnnString("MyDatabaseDeneme")))
                {
                    connection3.Open();
                    using (SqlCommand cmd = new SqlCommand(query3, connection3))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                return Model;
            }
        }

        public bool HappyBirthDay(string email)
        {
            string query = "Select email from tblPerson " +
                "where day(birthdate)= Day(Getdate()) and month(birthdate)= month(Getdate()) and email='"+email+"'";
            using (SqlConnection connection = new SqlConnection(GlobalConf.CnnString("MyDatabaseDeneme")))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (!dr.Read())
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
            }
        }
    }
}