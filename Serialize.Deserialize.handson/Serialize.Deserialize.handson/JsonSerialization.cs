using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Serialize.Deserialize.handson
{
    internal class JsonSerialization
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee(){id=1,name="faqruddin",designation="manager",salary=100000,location="hyderabad" },
            new Employee(){id=1,name="subramanyam",designation="software eng",salary=10000,location="hyderabad" },
            new Employee(){id=1,name="adnan",designation="intern",salary=50000,location="hyderabad" },
            new Employee(){id=1,name="karthik",designation="sales manager",salary=70000,location="hyderabad" },
            new Employee(){id=1,name="mohammed",designation="assistant",salary=90000,location="hyderabad" }
        };

        public void Jserialize()
        {
            FileStream fs = new FileStream(@"C:\Users\shaikh faqruddin\OneDrive\Desktop\CSharpHandsOn\cSharpHandsOn\Serialize.Deserialize.handson\jsonserialize.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sr = new StreamWriter(fs);
            string result=(string)JsonConvert.SerializeObject(employees);
            sr.Write(result);
            sr.Close();
            fs.Close();
         
            Console.WriteLine("json serialized the list in the file");
            Console.ReadLine();
            
        }

        public void JDeserialize()
        {
            string result;
            FileStream fs = new FileStream(@"C:\Users\shaikh faqruddin\OneDrive\Desktop\CSharpHandsOn\cSharpHandsOn\Serialize.Deserialize.handson\jsonserialize.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs); 
            result = sr.ReadToEnd();  
            
            
            List<Employee> D1employee =JsonConvert.DeserializeObject<List<Employee>>(result);
            foreach(Employee e in D1employee)
            {
                Console.WriteLine(e.name);
            }
            Console.ReadLine();
            
        }
    }
}
