using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkPractice3.Models
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        public int Name { get; set; }
        public string Address { get; set; }
    }
}
