using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops.HandsOn
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Subclass sub = new Subclass();
            //sub.Greet();
            ParDemo parDemo = new ParDemo();  //partial class demo
            parDemo.printname();
            
        }
    }
}
