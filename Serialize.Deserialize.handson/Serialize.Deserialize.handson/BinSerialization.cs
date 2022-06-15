using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Serialize.Deserialize.handson
{
    internal class BinSerialization
    {


        public void Binaryformatter()//binary formatter
        {
            FileStream fs = new FileStream(@"C:\Users\shaikh faqruddin\OneDrive\Desktop\CSharpHandsOn\cSharpHandsOn\Serialize.Deserialize.handson\bin.serialize.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fs,"faqruddin");
            sw.Close();
            fs.Close();
        }

        public void XmlSerialization()
        {
            FileStream fs = new FileStream(@"C:\Users\shaikh faqruddin\OneDrive\Desktop\CSharpHandsOn\cSharpHandsOn\Serialize.Deserialize.handson\xml.serialize.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            //var employee = new { id = 1, name = "faqruddin", mobile = "8787", location = "hyderabad" };
           // List<Employee> employees = new List<Employee>() { id = 1, };
           
            XmlSerializer xmlserializer = new XmlSerializer(typeof(string));
            xmlserializer.Serialize(fs,"faqruddin" );
         
            Console.WriteLine("the deserialization output is ");
            
                sw.Close();
               fs.Close();
        }

        public void jsonserialization()
        {
            List<string> names = new List<string>() { "faqruddin", "rasool", "ghouse", "azher" };
            JsonSerializer jsonSerializer = new JsonSerializer();
            FileStream fs = new FileStream(@"C:\Users\shaikh faqruddin\OneDrive\Desktop\CSharpHandsOn\cSharpHandsOn\Serialize.Deserialize.handson\json.serialize.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            JsonWriter jsonwriter =new JsonTextWriter(sw);
            jsonSerializer.Serialize(jsonwriter, names);
            jsonwriter.Close();
            sw.Close ();
            fs.Close();
            
        }

        public void jsondeserialization()
        {
            FileStream fs = new FileStream(@"C:\Users\shaikh faqruddin\OneDrive\Desktop\CSharpHandsOn\cSharpHandsOn\Serialize.Deserialize.handson\json.serialize.txt", FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            JsonSerializer jsonserializer = new JsonSerializer();
            JsonReader js = new JsonTextReader(sw);
            var obj=jsonserializer.Deserialize(js);
            List<string> dnames = new List<string>();
            dnames = (List<string>)obj;
            


        }


       
    }
}
