
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBclassLibrary.Entities
{
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }    
        public string? Address { get; set; } 

        public ICollection<EmployeeEducation>? Employees { get; set; }    


    }
}
