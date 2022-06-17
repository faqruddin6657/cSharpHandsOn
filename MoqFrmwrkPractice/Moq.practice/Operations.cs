using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moqpractice
{
    public interface IOperations
    {
         int Add(int a,int b);
        int subtract(int a, int b);
        int multiply(int a, int b);    
        int divide(int a,int b);  

    }

    internal class Moperations:IOperations
    {
        public int Add(int a, int b)
        {
            return a+b;
        }
        public int subtract(int a, int b)
        {
            return a-b;
        }
        public int multiply(int a, int b)
        {
            return a*b;
        }
        public int divide(int a, int b)
        {
            return a/b;
        }
    }
}
