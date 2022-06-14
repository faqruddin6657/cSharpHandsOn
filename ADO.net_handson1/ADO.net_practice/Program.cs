using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace ADO.net_practice
{
    internal class Program
    {
        public static void FetchingtheRecords()
        {
            CustomerDetails customerDetails = new CustomerDetails();
            DataTable dt = new DataTable();
            dt = customerDetails.FetchRecordsOfCustomer();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    Console.Write(dt.Rows[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public static void FetchingTheRecById()
        {
            CustomerDetails customerdetails = new CustomerDetails();
            DataTable dataTable = new DataTable();
            dataTable = customerdetails.SelectCustomersById();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    Console.WriteLine(dataTable.Rows[i][j]);
                }

            }
        }
        static void Main(string[] args)
        {
            CustomerDetails customer = new CustomerDetails();
            customer.Insert();
            customer.Delete();
            customer.UpdateMobile();
            

        }
    }
}
