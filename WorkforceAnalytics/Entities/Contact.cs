using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Contact
    {
        public int Id { get; set; }
        // FK
        public int WorkerId { get; set; }
        // properties
        public string PhoneAreaCode { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxAreaCode { get; set; }
        public string FaxNumber { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
    }
}
