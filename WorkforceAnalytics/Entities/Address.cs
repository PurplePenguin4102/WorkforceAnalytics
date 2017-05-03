using System;
using System.Collections.Generic;
using System.Text;
using Entities.Enums;

namespace Entities
{
    public class Address
    {
        // combined Key
        public int Id { get; set; }
        public AddressType Type { get; set; }
        // FK
        public int WorkerId { get; set; }
        // properties
        public int BuildingNo { get; set; }
        public int StreetNo { get; set; }
        public string POBox { get; set; } // not allowed for home address
        public string StreetName { get; set; }
        public string Suburb { get; set; }
        public State State { get; set; } 
        public string PostCode { get; set; }
    }
}
