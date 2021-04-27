using System;
using System.Collections.Generic;

namespace AuditPOC.Data
{
    public partial class Countries
    {
        public Countries()
        {
            Employees = new HashSet<Employees>();
        }

        public int CountryId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Employees> Employees { get; set; }
    }
}
