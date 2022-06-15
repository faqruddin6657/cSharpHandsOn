using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Practice
{
    public delegate void DelegateHandler(int a, int b);
    internal class DelegateDemo
    {
        public void Add(int a ,int b)
        {
            Console.WriteLine(a + b);
        }
        public void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public void mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public void div(int a, int b)
        {
            Console.WriteLine(a /b);
        }
        public void Avg(int a, int b,int c)
        {
            Console.WriteLine((a + b+c)/3);
        }
    }

    internal class DelegateCreation
    {
            
    }
}
