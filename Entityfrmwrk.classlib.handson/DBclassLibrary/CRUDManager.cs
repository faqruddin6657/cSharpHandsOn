
using Microsoft.EntityFrameworkCore;
using DBclassLibrary.Entities;

namespace DBclassLibrary
{
    public class CRUDManager
    {
        private DemoDbContext demoDbContext;
        public CRUDManager()
        {
            demoDbContext = new DemoDbContext();
        }

        public Employee GetEmplpoyeeById(int employeeId)
        {
            
            var employee = demoDbContext.Employees.Where(x => x.Id == employeeId)
                            .AsNoTracking()
                            .FirstOrDefaultAsync().Result;

            if (employee == null)
            {
                throw new Exception($"Employee with ID:{employeeId} Not Found");
            }

            return employee;
        }

        public List<Employee> GetAllEmployees()
        {
            var employee = demoDbContext.Employees.ToList();
            return employee;
        }
        public void Insert(Employee employee)
        {
            demoDbContext.Employees.Add(employee);
            demoDbContext.SaveChanges();
        }

        public void Update(int employeeId, Employee modifiedEmployee)
        {
            var employee = demoDbContext.Employees.Where(x => x.Id == employeeId).FirstOrDefault();
            if (employee == null)
            {
                throw new Exception($"Employee with ID:{employeeId} Not Found");
            }

            employee.Name = modifiedEmployee.Name;
            employee.Address = modifiedEmployee.Address;

         
            demoDbContext.Employees.Update(employee);

           
            demoDbContext.SaveChanges();
        }

        public void Delete(int employeeId)
        {
            var employee = demoDbContext.Employees.Where(x => x.Id == employeeId).FirstOrDefault();
            if (employee == null)
            {
                throw new Exception($"Employee with ID:{employeeId} Not Found");
            }

            
            demoDbContext.Employees.Remove(employee);

            
            demoDbContext.SaveChanges();
        }

        public EmployeeEducation GetEmplpoyeeEducationRecordsById(int edId)     //for employee education
        {

            var employeeEd = demoDbContext.EmployeeEducations.Where(x => x.Id ==edId )
                            .AsNoTracking()
                            .FirstOrDefaultAsync().Result;

            if (employeeEd == null)
            {
                throw new Exception($"Employee with ID:{edId} Not Found");
            }

            return employeeEd;
        }

        public List<EmployeeEducation> GetAllEmployeeEdRecords()
        {
            var employeeEd = demoDbContext.EmployeeEducations.ToList();
            return employeeEd;
        }
        public void InsertEmpEd(EmployeeEducation employeeEd)
        {
            demoDbContext.EmployeeEducations.Add(employeeEd);
            demoDbContext.SaveChanges();
        }

        public void UpdateEmployeeEd(int employeeEdid, EmployeeEducation modifiedEmployeeEd)
        {
            var employeeEd = demoDbContext.EmployeeEducations.Where(x => x.Id == employeeEdid).FirstOrDefault();
            if (employeeEd == null)
            {
                throw new Exception($"Employee with ID:{employeeEdid} Not Found");
            }

            employeeEd.CourseName = modifiedEmployeeEd.CourseName;
            employeeEd.UniversityName = modifiedEmployeeEd.UniversityName;
            employeeEd.PassingYear = modifiedEmployeeEd.PassingYear;
            employeeEd.MarksPercentage = modifiedEmployeeEd.MarksPercentage;
            
            demoDbContext.EmployeeEducations.Update(employeeEd);


            demoDbContext.SaveChanges();
        }

        public void DeleteEmployeeEd(int employeeEdId)
        {
            var employeeEd = demoDbContext.EmployeeEducations.Where(x => x.Id == employeeEdId).FirstOrDefault();
            if (employeeEd == null)
            {
                throw new Exception($"Employee with ID:{employeeEdId} Not Found");
            }


            demoDbContext.EmployeeEducations.Remove(employeeEd);


            demoDbContext.SaveChanges();
        }
    }
}
