using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Features
{
    //Programmer Written
    public partial class Student
    {
       
        public string GetStudentDetails()
        {
            return "Some student details";
        }
        partial void Validate(string propertyName, object propertyValue)
        {
            //Do Validation
        }
    }
    public partial class Maths
    {
        public int Sub(int x, int y)
        {
            return x - y;
        }
    }
}
