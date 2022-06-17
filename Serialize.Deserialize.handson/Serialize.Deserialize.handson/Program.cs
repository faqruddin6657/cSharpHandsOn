using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialize.Deserialize.handson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JsonSerialization jsonSerialization = new JsonSerialization();
            //jsonSerialization.Jserialize();
            //jsonSerialization.JDeserialize();
            BinarySerialization binarySerialization = new BinarySerialization();
          //  binarySerialization.Bserial();
           // binarySerialization.BDeserial();

            XmlSerialDerial xmlSerialDerial = new XmlSerialDerial();
            //xmlSerialDerial.XmlSerial();
            xmlSerialDerial.XmlDeserial();
        }
    }
}
