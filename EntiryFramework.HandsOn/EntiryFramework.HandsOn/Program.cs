using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntiryFramework.HandsOn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OranizationDBEntities oranizationDBEntities = new OranizationDBEntities();
            
            Employee employee = new Employee();
            employee.eid = Convert.ToInt32(Console.ReadLine());
            employee.ename =Console.ReadLine();
            employee.designation =Console.ReadLine();
            oranizationDBEntities.Employees.Add(employee);
            oranizationDBEntities.SaveChanges();
        }
    }
}
