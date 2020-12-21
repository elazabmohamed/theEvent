using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theEvent.Models
{
    public class MessageModel
    {
        public long MessageID { get; set; }
        public long SenderID { get; set; }
        
        public long RecieverID { get; set; }
        public string Message { get; set; }

    }

}
