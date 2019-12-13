using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Features
{
   //Auto Generated
    public partial class Student
    {
        partial void Validate(string propertyName,object propertyValue);

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                Validate("Name", value);
            }
        }
        private int _Age;

        public int Age
        {
            get { return _Age; }
            set
            {
                _Age = value;
                Validate("Age", value);
            }
        }



    }
  
}
