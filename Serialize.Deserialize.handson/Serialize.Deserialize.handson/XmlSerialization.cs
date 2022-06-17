using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Serialize.Deserialize.handson
{
 
    internal class XmlSerialDerial
    {
        
      
        public void XmlSerial()
        {
            List<Employee> employees = new List<Employee>()
        {
            new Employee(){id=1,name="faqruddin",designation="manager",salary=100000,location="hyderabad" },
            new Employee(){id=1,name="subramanyam",designation="software eng",salary=10000,location="hyderabad" },
            new Employee(){id=1,name="adnan",designation="intern",salary=50000,location="hyderabad" },
            new Employee(){id=1,name="karthik",designation="sales manager",salary=70000,location="hyderabad" },
            new Employee(){id=1,name="mohammed",designation="assistant",salary=90000,location="hyderabad" }
        };

            FileStream fs = new FileStream(@"C:\Users\shaikh faqruddin\OneDrive\Desktop\CSharpHandsOn\cSharpHandsOn\Serialize.Deserialize.handson\xmlserial.txt", FileMode.Create, FileAccess.Write);
            XmlSerializer xmlSerialization = new XmlSerializer(typeof(List<Employee>));
            xmlSerialization.Serialize(fs,employees);
            fs.Close(); 
           
        }

        public void XmlDeserial()
        {
            
            string a = "";
            FileStream fs = new FileStream(@"C:\Users\shaikh faqruddin\OneDrive\Desktop\CSharpHandsOn\cSharpHandsOn\Serialize.Deserialize.handson\xmlserial.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            XmlSerializer xmlSerialization = new XmlSerializer(typeof(List<Employee>));
            object obj=xmlSerialization.Deserialize(fs);
            List<Employee> employees = (List<Employee>)obj;

            foreach(Employee employee in employees)
            {
                Console.WriteLine(employee.name);
            }
            Console.ReadLine();


        }
    }
}
