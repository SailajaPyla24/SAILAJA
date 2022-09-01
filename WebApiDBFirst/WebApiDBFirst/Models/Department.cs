using System;
using System.Collections.Generic;

namespace WebApiDBFirst.Models
{
    public partial class Department
    {
        public Department()
        {
            Students = new HashSet<Student>();
        }

        public int DepartmentId { get; set; }
        public string? DepartmentIdname { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
