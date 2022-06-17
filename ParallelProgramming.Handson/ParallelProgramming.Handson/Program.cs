using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ParallelProgramming.Handson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParallelDemo demo = new ParallelDemo();  
            Thread t1 = new Thread(demo.Students);
            Thread t2 = new Thread(demo.Teachers);  
            t1.Start(); 
            t2.Start();
            //   demo.PrintFruits();    // without data parallel

            //   demo.PrintFruit__async();  //data parallel

            //  demo.demInvoke();
            Console.ReadLine();
           

        }

    }
}
