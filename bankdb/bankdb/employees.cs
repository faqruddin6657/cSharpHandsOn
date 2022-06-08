using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace bankdb
{
    internal class Employees
    {
        public static string dbconnection = @"Data Source=FAQRUDDIN\SQLEXPRESS;Initial Catalog=bankDataBase;Integrated Security=True";
        public string insertInAccountDetails()
        {
            Console.WriteLine("enter the employee number");
            int empno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the employee name");
            String ename = Console.ReadLine();

            Console.WriteLine("enter enter mobile number");
            int mobile = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the enter address");
            string address = Console.ReadLine();

            Console.WriteLine("enter the designation");
            string designation = Console.ReadLine();

            String query = "insert into employeeDetails values(" + empno + ",'" + ename + "'," + mobile + ",'" + address + "','" +designation+ "')";


            SqlConnection sq = new SqlConnection(dbconnection);
            SqlCommand cmd = new SqlCommand(query, sq);
            sq.Open();
            cmd.ExecuteNonQuery();
            sq.Close();
            return "executed";
        }

        public String deleteInAccountDetails()
        {
            return "";
        }

        public String updateInAccountDetails()
        {
            return "";
        }

        public void fetchInAccountDetails()
        {

        }
    }
}
