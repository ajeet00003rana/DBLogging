using System;
using System.Collections.Generic;

namespace AuditPOC.Data
{
    public partial class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public DateTime? HireDate { get; set; }
        public int? CollegeId { get; set; }
        public int? DepartmentId { get; set; }
        public int? RoleId { get; set; }
    }
}
