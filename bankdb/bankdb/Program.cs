using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace bankdb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //accountDetails ac = new accountDetails();
           //Console.WriteLine(ac.insertInAccountDetails());
            Employees employees = new Employees();
            employees.insertInAccountDetails();
        }
    }
}
