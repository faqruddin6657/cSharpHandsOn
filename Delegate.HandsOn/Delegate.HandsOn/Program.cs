using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.HandsOn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{id=1,name="vineet",salary=10000,experience=1 },
                new Employee{id=2,name="balaram",salary=5000,experience=2 },
                new Employee{id=3,name="ali",salary=50000,experience=3 },
                new Employee{id=4,name="sourav",salary=10000,experience=4 },
                new Employee{id=5,name="abhishek",salary=20000,experience=5 },
                new Employee{id=6,name="aruna",salary=30000,experience=6 },
            };
            Ispromote ispromote = new Ispromote(Employee.Topromote);
            Employee.Promotion(employees, ispromote);
        }
    }
}
