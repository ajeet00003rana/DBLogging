using System;
using System.Collections.Generic;

namespace AuditPOC.Data
{
    public partial class Employees
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public int CountryId { get; set; }
        public bool Smoker { get; set; }
        public int MaritalStatus { get; set; }
        public int Gender { get; set; }
        public DateTime? JoinedDate { get; set; }
        public DateTime? ExitDate { get; set; }
        public int JobCategoryId { get; set; }
        public string Comment { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public virtual Countries Country { get; set; }
        public virtual JobCategories JobCategory { get; set; }
    }
}
