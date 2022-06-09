using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serializationDesirialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            serialDerial serialDerial = new serialDerial();
            serialDerial.xmldeserialize();
        }
    }
}
