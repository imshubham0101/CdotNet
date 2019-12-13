using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09Basics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button btn1 = new Button();
            btn1.Text = "Click Me";

            EventHandler pointer =  new EventHandler(CallMeOnClick);
            btn1.Click += pointer;
            this.Controls.Add(btn1);
        }

        public void CallMeOnClick(object sender,EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
