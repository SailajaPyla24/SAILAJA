using System;
using System.Collections.Generic;

namespace WebApiDBFirst.Models
{
    public partial class Student
    {
        public int RollNo { get; set; }
        public string? Name { get; set; }
        public string? Subject { get; set; }
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; } = null!;
    }
}
