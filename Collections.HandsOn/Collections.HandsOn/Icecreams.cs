using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.HandsOn
{
    internal class Icecreams
    {
       public List<string> Icecream = new List<string>();
        public void AddFlvours()
        {
            Console.WriteLine("enter the flavour to be added");
            string flavour = Console.ReadLine();
            Icecream.Add(flavour);
        }
        public void DisplayFlavours()
        {
            foreach(string flavour in Icecream)
            {
                Console.WriteLine(flavour); 
            }
        }
        public void RemoveFlavour()
        {
            Console.WriteLine("enter the flavour to be removed");
            string rmflavour = Console.ReadLine();
            if(Icecream.Contains(rmflavour))
            {
                Icecream.Remove(rmflavour);
            }
        }
    }
}
