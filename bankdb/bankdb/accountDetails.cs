using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace bankdb
{
    internal class accountDetails
    {
        public static string dbconnection = @"Data Source=FAQRUDDIN\SQLEXPRESS;Initial Catalog=bankDataBase;Integrated Security=True";
        public string insertInAccountDetails()
        {
            Console.WriteLine("enter the account number");
            int acc = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter your name");
            string name =Console.ReadLine();

            Console.WriteLine("enter the mobile number");
            int mob = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the address");
            string address = Console.ReadLine();
        
            String query = "insert into Details(account_number,customer_name,mobile_number,customer_address) values(" + acc + ",'" + name + "'," + mob + ",'" + address + "')";
            
           
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
