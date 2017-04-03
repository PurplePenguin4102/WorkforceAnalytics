using System;
using Entities.Enums;

namespace Entities
{
    public class Worker
    {
        public int Id { get; set; }
        public WorkerType Type { get; set; }
        public Title Title { get; set; }
        public Gender Gender { get; set; }
        public string FamilyName { get; set; }
        public string GivenName { get; set; } // stored as "FirstName;MName1,MName2," if the UI differentiates it
        public DateTime DateOfBirth { get; set; }
        public DateTime SignupDate { get; set; }
        
        // navigation properties
        public Contact ContactDetails;
        public Address HomeAddress;
        public Address PostalAddress;
    }
}
