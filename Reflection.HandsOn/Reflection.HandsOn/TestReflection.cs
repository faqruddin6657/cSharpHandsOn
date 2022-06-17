using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection.HandsOn
{
    internal class TestReflection
    {
        int StudentId = 1; //{ get; set; }
        string Name = "faqruddin";//{ get; set; }
        int mobile = 3343434;//{ get; set; }
        string course = "cse";//{ get; set; }
        string college = "guru nanak"; //{ get; set; }
        string email = "faq@gmailcom"; //{ get; set; }

        public void ShowDetails()
        {
            Console.WriteLine("the following are the details");
            Console.WriteLine(StudentId+" "+ Name + " " + mobile + " " + course +" "+college + " " + email);
        }
        public void UpdateMobile()
        {
            Console.WriteLine("enter mobile");
           int newmob= Convert.ToInt32(Console.ReadLine());
            mobile= newmob; 
        }

        public void updateEmail()
        {
            Console.WriteLine("enter new email");
            string newemail = Console.ReadLine();
            email= newemail;

        }
    }

   
}
