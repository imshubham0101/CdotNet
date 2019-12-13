using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeraPointerNS;
using _11StudentLib;

namespace _10Basic
{
   
    class Program
    {
        static void Main(string[] args)
        {
            //EventHandler pointer = new EventHandler(CallMeOnClick);
            MyDelegate pointer = new MyDelegate(SayHello);

            //Button btn1 = new Button();
            Student s1 = new Student();

            //btn1.Click += pointer;
            s1.Admitted += pointer;

            //You actually click on button
            s1.DoAdmit("abc");
            Console.ReadLine();

        }

        //public void CallMeOnClick(object sender, EventArgs e)
        static void SayHello(string name)
        {
            // MessageBox.Show("Test");
            Console.WriteLine("Welcome " + name);
        }

    }
    
}
