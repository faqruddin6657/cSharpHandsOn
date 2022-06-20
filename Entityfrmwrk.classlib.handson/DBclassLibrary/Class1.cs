
using Microsoft.EntityFrameworkCore;
using DBclassLibrary.Entities;


namespace DBclassLibrary
{
    public class DemoDbContext : DbContext
    {

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeEducation> EmployeeEducations {get;set; }  

        public DemoDbContext()
        {

        }
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=FAQRUDDIN\SQLEXPRESS;Database=entityframeworkprac;Trusted_Connection=True");
        }
        
    }
}