using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Contact
    {
        int Id { get; set; }
        // FK
        int WorkerId { get; set; }
        // properties
        string PhoneAreaCode { get; set; }
        string PhoneNumber { get; set; }
        string FaxAreaCode { get; set; }
        string FaxNumber { get; set; }
        string Email { get; set; }
        string Mobile { get; set; }
    }
}
