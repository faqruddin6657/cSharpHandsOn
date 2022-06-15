using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAdapter.HandsOn
{
    internal class Program
    {
        public static void Insert()
        {
            DataTable dt = new DataTable();
            Console.WriteLine("enter id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter customer name");
            string customer =Console.ReadLine();
            Console.WriteLine("enter email id");
            string email= Console.ReadLine();
            Console.WriteLine("enter mobile number");
            string mob = Console.ReadLine();
            Console.WriteLine("enter address");
            string address = Console.ReadLine();
            string connectionstr = @"Data Source=FAQRUDDIN\SQLEXPRESS;Initial Catalog=OranizationDB;Integrated Security=True";
            SqlConnection sq = new SqlConnection(connectionstr);
            SqlDataAdapter adp = new SqlDataAdapter("insert into customer values("+id+",'"+customer+"','"+email+"','"+mob+"','"+address+"')",sq);
            int res = adp.Fill(dt);
            if(res>0)
            {
                Console.WriteLine("the records are added in the database");
            }
            
        }
        public static void Delete()
        {
            Console.WriteLine("enter the name of the customer to be delted");
            string name = Console.ReadLine();
            DataTable dt = new DataTable();
            string connectionstr = @"Data Source=FAQRUDDIN\SQLEXPRESS;Initial Catalog=OranizationDB;Integrated Security=True";
            SqlConnection sq = new SqlConnection(connectionstr);
            SqlDataAdapter adp = new SqlDataAdapter("delete from customer where cusname='"+name+"'", sq);
            int res = adp.Fill(dt);
            if (res > 0)
            {
                Console.WriteLine("the customer details has been deleted");
            }
        }

        public static void Select()
        {
            DataTable dt = new DataTable();
            string connectionstr = @"Data Source=FAQRUDDIN\SQLEXPRESS;Initial Catalog=OranizationDB;Integrated Security=True";
            SqlConnection sq = new SqlConnection(connectionstr);
            SqlDataAdapter adp = new SqlDataAdapter("select * from customer", sq);
            int res = adp.Fill(dt);
            if (res > 0)
            {
                Console.WriteLine("the customer table contains the following records"+"\n");
            }

           

            for(int i=0;i<dt.Rows.Count;i++)
            {
                for(int j=0;j<dt.Columns.Count;j++)
                {
                    Console.Write(dt.Rows[i][j].ToString()+"\t");
                }
                Console.WriteLine();
            }
        }

        public static void UpdateMobile()
        {
            
            Console.WriteLine("enter the name of the customer to be delted");
            string name = Console.ReadLine();
            Console.WriteLine("enter the mobile number to be updated");
            string mobile = Console.ReadLine();
            DataTable dt = new DataTable();
            string connectionstr = @"Data Source=FAQRUDDIN\SQLEXPRESS;Initial Catalog=OranizationDB;Integrated Security=True";
            SqlConnection sq = new SqlConnection(connectionstr);
            SqlDataAdapter adp = new SqlDataAdapter("update customer set mobile='"+mobile+"' where cusname='"+name+"'", sq);
            int res = adp.Fill(dt);
            if (res > 0)
            {
                Console.WriteLine("the customer details has been deleted");
            }

        }
        static void Main(string[] args)
        {
            //Insert();
            //UpdateMobile();
            // Delete();
            Select();


        }
    }
}
