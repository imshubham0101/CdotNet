using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeraPointerNS;
using _11StudentLib;

namespace _11Basic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            //MyDelegate pointer = new MyDelegate(Student_Admitted);
            //student.Admitted += pointer;

            //student.Admitted += new MyDelegate(Student_Admitted);

            //student.Admitted +=Student_Admitted;

            student.Admitted += Student_Admitted;
            student.DoAdmit("ABC");
        }

        private void Student_Admitted(string msg)
        {
            MessageBox.Show("Kaisa hai " + msg);
        }
    }
}
