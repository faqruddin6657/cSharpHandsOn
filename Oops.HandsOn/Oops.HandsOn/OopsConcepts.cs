using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops.HandsOn
{
    internal abstract class Mobile //******************************************abstract class concepts
    {
        public void callingfeature()
        {
            Console.WriteLine("yes");
        }
        public abstract void multitasking();

        public abstract void GameFeatures();


    }

    internal class SmartPhone : Mobile
    {
        public override void multitasking()
        {
            Console.Write("yes");
        }

        public override void GameFeatures()
        {
            Console.WriteLine("yes");
        }

    }

    internal class FeaturePhone : Mobile
    {
        public override void multitasking()
        {
            Console.Write("No");
        }

        public override void GameFeatures()
        {
            Console.WriteLine("No");
        }

    }
    internal class Mathematics   //****************************************************** method loading
    {
        int a = 10, b = 20, c = 30;
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Add(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }
    }

    internal class Superclass  //************************************************** method overriding
    {
        public virtual void Greet()
        {
            Console.WriteLine("hello");
        }
    }

    internal class Subclass : Superclass
    {
        public override void Greet()
        {
            Console.WriteLine("namaste");
        }
    }

    interface A  //*****************************************interfaces
    {
        void method1();
        void method2();
    }

    interface B
    {
        void method3();
        void method4();
    }

    internal class InerfaceDem : A, B
    {
        public void method1()
        {
            //implementation
        }
        public void method2()
        {
            //implementation
        }
        public void method3()
        {
            //implementation
        }
        public void method4()
        {
            //implementation
        }
    }

    internal sealed class sealedDemo// ******************************* sealed class
    {
        public void pr()
        {
            Console.WriteLine("this is sealed class and cannot be inherited");
        }
    }

    internal partial class ParDemo// *********************************** partial class 
    {
        public string name;
    }
    internal partial class ParDemo
    {
        public void printname()
        {
            name = "faqruddin";
            Console.WriteLine(name);
        }
    }

    
}
