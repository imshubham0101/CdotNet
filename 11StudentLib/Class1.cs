using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeraPointerNS;

namespace _11StudentLib
{
    public class Student //public class Button
    {
        //public event EventHandler Click;
        public event MyDelegate Admitted;

        //Did user do left mouse button click on button area?Check it..
        public void DoAdmit(string name)
        {
            Admitted(name);
            //Click(this, new EventArgs());
        }
    }
}

namespace MeraPointerNS
{
    // public delegate void EventHandler(object sender, EventArgs e);
    public delegate void MyDelegate(string msg);
}
