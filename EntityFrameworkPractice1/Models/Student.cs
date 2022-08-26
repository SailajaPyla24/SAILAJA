using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkPractice1.Models
{
    public class Student
    {
        [Key]
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }

        public string Address { get; set; }
    }
}
