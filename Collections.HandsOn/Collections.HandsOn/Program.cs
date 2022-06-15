using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.HandsOn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Icecreams icecreams = new Icecreams();
            while(true)
            {
                Console.WriteLine("for displaying flavours press 1 ");
                Console.WriteLine("for adding flavours press 2 ");
                Console.WriteLine("for removing flavours press 3 ");
                int choice =Convert.ToInt32(Console.ReadLine());
                if(choice==1)
                {
                    icecreams.DisplayFlavours();

                }
                else if(choice==2)
                {
                    icecreams.AddFlvours();
                }
                else if(choice==3)
                {
                    icecreams.RemoveFlavour();
                }
                else
                {
                    Console.WriteLine("enter a valid choice");
                }
            }
        }
    }
}
