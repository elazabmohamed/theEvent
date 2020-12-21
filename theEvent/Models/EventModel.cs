using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theEvent.Models
{
   public class EventModel 
    {
        public int EventID { get; set; }
        public string EventMakerName { get; set; }
        public string EventName { get; set; }
        public string EventLocation { get; set; }
        public string EventDate { get; set; }
        public string EventType { get; set; }
        public string EventNote { get; set; }
        public string InvitedMembers { get; set; }
       
        
    }

    public class postEvent : EventModel 
    {
        public string Attendance { get; set; }
        public string Review { get; set; }
    }
}
