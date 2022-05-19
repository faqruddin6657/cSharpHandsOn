using System;
using System.IO;

namespace ConsoleApp2
{

    class AllModules
    {
        public void UserModule()
        {
            int j,i=0;
            FileStream fs = new FileStream(@"C:\Users\shaik\OneDrive\Desktop\New folder\userModule", FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            
            
            
                sw.WriteLine("USERID\t\t\tFNAME\t\t\t\tLNAME\t\t\t\tEMAIL\t\t\t\tPHONE\n");

            while (i < 5)
            {
                Console.WriteLine("Enter username,firstname,lastname,email,phoneno");
                String str = Console.ReadLine();
                String[] str2 = str.Split(",");
                for (j = 0; j < str2.Length; j++)
                {
                    sw.Write(str2[j] + "\t\t\t");

                }
                sw.Write("\n");
                i++;
            }
              
            sw.Close();
            fs.Close();

        }

        public void CategoryModule()
        {
            int j, i = 0;
            FileStream fs = new FileStream(@"C:\Users\shaik\OneDrive\Desktop\New folder\CategoryModule.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);



            sw.WriteLine("CATEGORYID\t\t\tCATEGORYTYPE\n");

            while (i < 5)
            {
                Console.WriteLine("CategoryId,CategoryType");
                String str = Console.ReadLine();
                String[] str2 = str.Split(",");
                for (j = 0; j < str2.Length; j++)
                {
                    sw.Write(str2[j] + "\t\t\t");

                }
                sw.Write("\n");
                i++;
            }

            sw.Close();
            fs.Close();

        }

        public void ProductModule()
        {
            int j, i = 0;
            FileStream fs = new FileStream(@"C:\Users\shaik\OneDrive\Desktop\New folder\ProductModule.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);



            sw.WriteLine("PRODUCTID\t\t\tCATEGORYTYPE\t\t\t\tPRODUCTNAME\t\t\t\tQUANTITY\t\t\t\tPRICE\n");

            while (i < 5)
            {
                Console.WriteLine("Enter productid,categorytype,productname,quantity,price");
                String str = Console.ReadLine();
                String[] str2 = str.Split(",");
                for (j = 0; j < str2.Length; j++)
                {
                    sw.Write(str2[j] + "\t\t\t\t");

                }
                sw.Write("\n");
                i++;
            }

            sw.Close();
            fs.Close();

        }


        public void SalesModule()
        {
            int j, i = 0;
            FileStream fs = new FileStream(@"C:\Users\shaik\OneDrive\Desktop\New folder\SalesModule.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);



            sw.WriteLine("SALESID\t\tPRODUCTID\t\tPRICE\t\tSALESDATE\n");

            while (i < 5)
            {
                Console.WriteLine("Enter salesid,productid,price,salesdate");
                String str = Console.ReadLine();
                String[] str2 = str.Split(",");
                for (j = 0; j < str2.Length; j++)
                {
                    sw.Write(str2[j] + "\t\t\t");

                }
                sw.Write("\n");
                i++;
            }

            sw.Close();
            fs.Close();

        }
    }
    class program
    {

        public static void Main(String[] args)
        {
            AllModules allinone = new AllModules();
            allinone.SalesModule();
            
            Console.ReadKey();




        }

    }
}
