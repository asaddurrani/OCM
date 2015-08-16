using System;
using System.Collections.Generic;

namespace Models.DomainModels
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerMiddleName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerMobileNumber1 { get; set; }
        public string CustomerMobileNumber2 { get; set; }
        public string CustomerLandline { get; set; }
        public string CustomerEmailAddress { get; set; }
        public string CustomerAddress { get; set; }
        public DateTime? CustomerCreatedDate { get; set; }
        public string CustomerDescription { get; set; }

        public virtual ICollection<OilChangeRecord> OilChangeRecords { get; set; }
    }
}
