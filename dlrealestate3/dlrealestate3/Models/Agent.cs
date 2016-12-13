using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dlrealestate3.Models
{
    public class Agent
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public int CellNumber { get; set; }
        public string EmailAddress { get; set; }
        public string PhotoUrl { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Property> Properties { get; set; }
    }
}