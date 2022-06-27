using OrderAssignmentEFrmwok;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAssignmentEFrmwork
{
    internal class program
    {
       
        public static void Main()
        {
            Customer customer = new Customer();
            
            while(true)
            {
                Console.WriteLine("enter 1 for customer login");
                Console.WriteLine("press 2 for customer registeration");
                int choice =Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:customer.Login(); break;
                    case 2:customer.Registeration();break;
                    case 3:return;break;
                    default:Console.WriteLine("enter a valid input");break;
                }
            }
        }
    }
}
