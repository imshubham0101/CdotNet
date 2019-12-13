using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Basics
{
   // public delegate void EventHandler(object sender, EventArgs e);
    public delegate void MyDelegate(string msg);
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
            Console.WriteLine("Hello " + name);
        }
       
    }

    
    public class Student //public class Button
    {
        //public event EventHandler Click;
        public event MyDelegate  Admitted;

        //Did user do left mouse button click on button area?Check it..
        public void DoAdmit(string name)
        {
            Admitted(name);
            //Click(this, new EventArgs());
        }
    }
}
