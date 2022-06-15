using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DelegateDemo dem = new DelegateDemo();
            DelegateHandler dl = new DelegateHandler(dem.Add);
            dl += dem.sub;
            dl += dem.mul;
            dl += new DelegateHandler(dem.div);
            //or we can use dl= new Delegateobj(obj1.methodname)  or dl+= obj.methodname
            dl(10, 5);

            
        }
    }
}
