using System;
using System.Collections.Generic;

namespace AuditPOC.Data
{
    public partial class College
    {
        public int Id { get; set; }
        public string CollegeName { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public DateTime? StartDate { get; set; }
    }
}
