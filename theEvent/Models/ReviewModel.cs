using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theEvent.Models
{
    public class ReviewModel
    {
        public long ReviewID { get; set; }
        public long ReviewerID { get; set; }

        public long ReviewedEvent { get; set; }
        public string Review { get; set; }
    }
}
