using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace ADO.net_practice
{
    internal class CustomerDetails
    {
        //customer table in the database contains id,cusname,email,mobile,address
        public static string sqlconnectionstr= @"Data Source=FAQRUDDIN\SQLEXPRESS;Initial Catalog=OranizationDB;Integrated Security=True";
        public void Insert()
        {
            SqlConnection sqlConnection = new SqlConnection(sqlconnectionstr);
            Console.WriteLine("enter customer id");
            int id =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter customer name");
            string cusname = Console.ReadLine();
            Console.WriteLine("enter customer email address");
            string email = Console.ReadLine();
            Console.WriteLine("enter customer mobile number");
            string mobile = Console.ReadLine();
            Console.WriteLine("enter customer address");
            string address = Console.ReadLine();
            SqlCommand cmd = new SqlCommand("insert into customer values("+id+",'"+cusname+"','"+email+"','"+mobile+"','"+address+"')",sqlConnection);
            sqlConnection.Open();
            int val=cmd.ExecuteNonQuery();
            sqlConnection.Close();
            if(val>0)
            {
                Console.WriteLine("the query is executed");
            }
            else
            {
                Console.WriteLine("the query is not executed");
            }

        }
        public void Delete()
        {
            SqlConnection sqlConnection = new SqlConnection(sqlconnectionstr);
            Console.WriteLine("enter customer id whose record is to be deleted");
            int id = Convert.ToInt32(Console.ReadLine());

            SqlCommand cmd = new SqlCommand("delete from customer where id ="+id+"", sqlConnection);
            sqlConnection.Open();
            int val = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            if (val > 0)
            {
                Console.WriteLine("the query is executed");
            }
            else
            {
                Console.WriteLine("the query is not executed");
            }
        }
        public void UpdateMobile()
        {
            SqlConnection sqlConnection = new SqlConnection(sqlconnectionstr);
            Console.WriteLine("enter mobile number to be updated");
            string mobile = Console.ReadLine();
            

            Console.WriteLine("enter employee id whose mobile is to updated");
            long id = Convert.ToInt32(Console.ReadLine());

            SqlCommand cmd = new SqlCommand("update customer set mobile='"+mobile+"' where id =" + id + "", sqlConnection);
            sqlConnection.Open();
            int val = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            if (val > 0)
            {
                Console.WriteLine("the query is executed");
            }
            else
            {
                Console.WriteLine("the query is not executed");
            }

        }
        public DataTable FetchRecordsOfCustomer()
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnection = new SqlConnection(sqlconnectionstr);
            SqlCommand cmd = new SqlCommand("select * from customer", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            dt.Load(sqlDataReader);
            sqlConnection.Close();
            return dt;
            
        }

        public DataTable SelectCustomersById()
        {
            Console.WriteLine("enter the id whose record you want to fetch");
            int id = Convert.ToInt32(Console.ReadLine());
            DataTable dt = new DataTable();
            SqlConnection sqlConnection = new SqlConnection(sqlconnectionstr);
            SqlCommand cmd = new SqlCommand("select * from customer where id ="+id+"", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            dt.Load(sqlDataReader);
            sqlConnection.Close();
            return dt;
        }

        
        
    }
}
