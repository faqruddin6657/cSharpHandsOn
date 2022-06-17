using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProgramming.Handson
{
    internal class ParallelDemo
    {
        #region printfruit__synchronous
        public void PrintFruits()
        {
            List<String> fruits = new List<string>() { "apple", "mango", "grapes", "straberry", "pineapple" };

            foreach(String fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }
        #endregion

        #region printfruit__asynchronous__dataParallel

        public void ShowFruit(string fr )
        {
            Console.WriteLine(fr);
        }

        public void PrintFruit__async() // data parallel
        {
            Console.WriteLine();
            List<String> fruits = new List<string>() { "apple", "mango", "grapes", "straberry", "pineapple" };
            Parallel.ForEach(fruits, item => ShowFruit(item));
        }

        #endregion

        #region parallel.invoke
        public void demInvoke()
        {
            Parallel.Invoke(Students,Teachers);
        }

        public void Students()
        {
            List<string> students = new List<string>()
            {
                "faqruddin","rasool","ghouse","sadiya","nagma","shahnaz","azhar"
            };
           
            foreach(string student in students)
            {
                Console.WriteLine("Student:  "+student);
                Thread.Sleep(1000);
            }
            

        }

        public void Teachers()
        {
            List<string> teachers = new List<string>()
            {
                "mujeeb","kulsum","hameeda","badaruddin","rayees"
            };
           
            foreach (string teacher in teachers)
            {
                Console.WriteLine("Teacher:  "+teacher);
                Thread.Sleep(1000);
            }

        }


        #endregion


    }
}
