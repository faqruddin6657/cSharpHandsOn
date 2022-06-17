using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection.HandsOn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           TestReflection testReflection = new TestReflection();
            Type type= typeof(TestReflection);
            var members = type.GetMembers();
            var properties = type.GetProperties();
            var methods = type.GetMethods();

            var methodname = type.GetMethod("ShowDetails");  //reflection to for executing method
            object obj = Activator.CreateInstance(type);
            methodname.Invoke(obj, null);
            Console.ReadLine();

        

        }
    }
}
