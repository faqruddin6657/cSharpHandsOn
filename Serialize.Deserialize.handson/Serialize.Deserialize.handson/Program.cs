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
           BinSerialization binSerialization = new BinSerialization();
            //binSerialization.Binaryformatter();
            //binSerialization.jsonserialization();
            binSerialization.jsondeserialization();
        }
    }
}
