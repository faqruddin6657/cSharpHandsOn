using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.HandsOn
{
    public delegate bool Ispromote(Employee employee);
    internal class DelegateDemo
    {
    }
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int  experience { get; set; }
        public int salary { get; set; } 

        public static void Promotion(List<Employee> emplist,Ispromote ispromote)
        {
            foreach(Employee emp in emplist)
            {
                if(ispromote(emp))
                {
                    Console.WriteLine("promoted "+emp.name);
                }
            }

        }

        public static Boolean Topromote(Employee emp)
        {
            Boolean flag = false;
            if(emp.experience>3)
            {
                flag = true;
            }
            return flag;

        }
    }
}
