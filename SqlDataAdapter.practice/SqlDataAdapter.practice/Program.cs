using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace sqlDataAdapter.practice
{
    
   
    internal class Program { 
        public static void withSqldataAdapter()
        {
             string constr = @"Data Source=FAQRUDDIN\SQLEXPRESS;Initial Catalog=OranizationDB;Integrated Security=True";
            try
            {
                DataTable dt = new DataTable();
                SqlConnection sq = new SqlConnection(constr);
                SqlDataAdapter dadp = new SqlDataAdapter("select * from customer", sq);
                dadp.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        Console.WriteLine(dt.Rows[i][j]);
                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void withoutAdapter()
        {
            DataTable dt = new DataTable();
            string constr = @"Data Source=FAQRUDDIN\SQLEXPRESS;Initial Catalog=OranizationDB;Integrated Security=True";
            SqlConnection sq= new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("select * from customer",sq);
            sq.Open();
            SqlDataReader result=cmd.ExecuteReader();
            dt.Load(result);
            sq.Close();
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    Console.WriteLine(dt.Rows[i][j]);
                }
            }

        }

        public static void Main()
        {
            withoutAdapter();
            //withSqldataAdapter();
        }
    

    
    
       
        
    }
}
