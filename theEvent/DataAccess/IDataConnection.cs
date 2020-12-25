using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using theEvent.Models;

namespace theEvent.DataAccess
{
    /// <summary>
    /// As mentioned in the GlobalConf file, if we happen to use more than one databse, 
    /// the functions for the other database will be added here below the sqlite functions as an easy and in a more efficient way
    /// </summary>
    public interface IDataConnection
    {
        void CheckDatabase();
        EventModel CreateEvent(EventModel Model);
        postEvent UpdateEventFeedBack(postEvent Model, string email);
        int FillAdminCount();
        int FillMemberCount(string typeToBeSearched);
        EventModel UpdateEvent(EventModel Model, string makerEmail);
        EventModel DeleteEvent(EventModel Model);
        PersonModel CreatePerson(PersonModel Model);
        PersonModel UpdatePerson(PersonModel Model);
        PersonModel DeletePerson(PersonModel Model);
        bool CheckMember(CheckLogModel Model);
        bool CheckAdmin(CheckLogModel Model);
        DataTable FillDataPerson(DataTable dt);
        DataTable FillDataPersonForHomePage(DataTable dt, string email);
        DataTable FillDataEvents(DataTable dt);
        DataTable FillDataAdmins(DataTable data);
        DataTable FillDataMembers(DataTable data);
        DataTable FillDataForAdminSearchByName(DataTable data, string name);
        DataTable FillDataForMemberSearchByName(DataTable data, string name);
        DataTable FillDataForEventSearchByName(DataTable data, string name);
        DataTable FillDataForAdminDelete(DataTable data, string name);
        DataTable FillDataForMemberDelete(DataTable data, string name);
        DataTable FillDataForEventDelete(DataTable data, string name);
        DataTable FillDataForAdminSearchByLocation(DataTable data, string name);
        DataTable FillDataForMemberSearchByLocation(DataTable data, string location);
        DataTable FillDataForEventSearchByLocation(DataTable data, string location);
        DataTable FillDataEventsForFeedBack(DataTable data);
        DataTable FillDataForEventUpdate(DataTable data, string name, string email);
        DataTable FillDataMessage(DataTable data, string email);
        MessageModel SendMessage(MessageModel Model, string email, string messagedEmail);
        bool HappyBirthDay(string email);

    }



}
