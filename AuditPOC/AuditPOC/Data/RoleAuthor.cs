using System;
using System.Collections.Generic;

namespace AuditPOC.Data
{
    public partial class RoleAuthor
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public string AccessPages { get; set; }
    }
}
