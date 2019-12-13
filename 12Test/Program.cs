using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Test
{
    public delegate string MyDelegate();
    class Program
    {
       
        static void Main(string[] args)
        {
            //Any other code if needed goes here...
            //------------------------------------
            //------------------------------------
            //------------------------------------

            B bObj = new B();

            MyDelegate pointer = new MyDelegate(bObj.M2);
            A obj = new A();
            obj.M1(pointer);

        }
    }

    public class A
    {
        public void M1(MyDelegate pointer) //<--one parameter is allowed
        {
            //Only one paramater is allowed to M1
            //and that parameter is not B / Object / String
            //You will not create object of B here
            //No inheritance
            //No down casting / upcasting
            //No Static Usage
            //No Events
            //No class here has a base
            //No Abstract / Interface / OverLoading / OverRiding / Virtual
            //No DLL to be referrred
            //Call M2 from B here.
            //Print output of M2 here.

           string result =  pointer();
           Console.WriteLine(result);
        }
    }

    public class B
    {
        public string M2()
        {
            return "M2 from B";
        }
    }
}
