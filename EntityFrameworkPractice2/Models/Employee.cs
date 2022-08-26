using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Employee
    {
        [Key]
        public int RollNo { get; set; }
        public int Name { get;set; }
        public string Address { get;set; }
        
    }
}
