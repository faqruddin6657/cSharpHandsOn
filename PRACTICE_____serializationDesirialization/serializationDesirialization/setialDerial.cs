using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace serializationDesirialization
{
    internal class serialDerial
    {
        //serialization and deserialization in C#
        //xml and json 
        public void binarySerialize()
        {
            string empname = "faqruddin";
            string company = "kellton";
            string phone = "348348";
            FileStream fs = new FileStream(@"C:\Users\shaikh faqruddin\OneDrive\Desktop\sh..handson\cSharpHandsOn\serializationDesirialization\ser.txt", FileMode.Open, FileAccess.Write);

          //formatter
            BinaryFormatter bf = new BinaryFormatter();
             bf.Serialize(fs, empname);
            fs.Close();
        }

       
        public void xmldeserialize()
        {
            FileStream fs = new FileStream(@"C:\Users\shaikh faqruddin\OneDrive\Desktop\sh..handson\cSharpHandsOn\serializationDesirialization\ser.txt", FileMode.Open, FileAccess.Write);
            // annonymous type ... object initializes automatically
            var emp = new { ename = "mallesh", eid = 343, salary = 10000 };
            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));
           // xmlSerializer.Serialize(fs, emp);
           // fs.Close();



        }

        public void xmlDeserialize()
        {
            FileStream fs = new FileStream(@"C:\Users\shaikh faqruddin\OneDrive\Desktop\sh..handson\cSharpHandsOn\serializationDesirialization\ser.txt", FileMode.Open, FileAccess.Read);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));
            Employee emp1 = (Employee)xmlSerializer.Deserialize(fs);

            Console.WriteLine(emp1.ename);
            fs.Close();
        }

    }
}
