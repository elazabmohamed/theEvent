using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theEvent.Models
{
    public class PersonModel
    {
        public long ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName()
        {
            string fullName = FirstName + ' ' + LastName;
            return fullName;
        }

        public string Email { get; set; }
        public string Password { get; set; }
        public string Location { get; set; }
        public string BirthDate { get; set; }
        public string Type { get; set; }
        public DateTime Registration { get; set; }

    }
    public class Admin : PersonModel
    {
        // addind a constructor to throw a default value for type
        public Admin(string type = "Admin")
        {
            Type = type;
        }
    }
    public class Member : PersonModel
    {
        // addind a constructor to throw a default value for type
        public Member(string type = "Member")
        {
            Type = type;
        }
    }
}
