using System;
using System.Collections.Generic;

namespace AuditPOC.Data
{
    public partial class JobCategories
    {
        public JobCategories()
        {
            Employees = new HashSet<Employees>();
        }

        public int JobCategoryId { get; set; }
        public string JobCategoryName { get; set; }

        public virtual ICollection<Employees> Employees { get; set; }
    }
}
