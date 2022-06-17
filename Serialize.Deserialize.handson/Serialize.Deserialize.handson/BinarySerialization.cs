using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Serialize.Deserialize.handson
{
    internal class BinarySerialization
    {
        String name = "Shaikh Faqruddin";
        public void Bserial()
        {
            FileStream fs = new FileStream(@"C:\Users\shaikh faqruddin\OneDrive\Desktop\CSharpHandsOn\cSharpHandsOn\Serialize.Deserialize.handson\binserialize.txt", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, name);
            fs.Close();
        }

        public void BDeserial()
        {
            FileStream fs = new FileStream(@"C:\Users\shaikh faqruddin\OneDrive\Desktop\CSharpHandsOn\cSharpHandsOn\Serialize.Deserialize.handson\binserialize.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            string output = (string)binaryFormatter.Deserialize(fs);
            Console.WriteLine("the output after binary deserialization: "+output);
            fs.Close ();
            Console.ReadLine();
        }
    }
}
